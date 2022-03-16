using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
using MySoccerWorld.Models.Entities;
using MySoccerWorld.Models.Services;
using MySoccerWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Controllers
{
    public class ClubsController : Controller
    {
        private readonly ILogger<ClubsController> _logger;
        private readonly SoccerContext db;
        public ClubsController(ILogger<ClubsController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index(ClubsSort sortType = ClubsSort.ClubId)
        {
            IQueryable<Club> clubs = db.Clubs.Include(c => c.Country).Include(c => c.CoachTeams).ThenInclude(c => c.Coach);
            ViewData["NameSort"] = sortType == ClubsSort.NameAsc ? ClubsSort.NameDesc : ClubsSort.NameAsc;
            ViewData["CountrySort"] = sortType == ClubsSort.CountryAsc ? ClubsSort.CountryDesc : ClubsSort.CountryAsc;
            clubs = sortType switch
            {
                ClubsSort.CountryAsc => clubs.OrderBy(c => c.Country.Name),
                ClubsSort.CountryDesc => clubs.OrderByDescending(c => c.Country.Name),
                ClubsSort.NameDesc => clubs.OrderByDescending(c => c.Name),
                ClubsSort.NameAsc => clubs.OrderBy(c => c.Name),
                _ => clubs.OrderBy(c => c.Id),
            };
            return View(await clubs.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            var players = await db.Players.Include(p=>p.Country).Include(p => p.PlayerTeams.OrderBy(p => p.Season)).ThenInclude(p => p.Player).ToListAsync();
            var clubPlayers = players.Where(p => p.PlayerTeams.LastOrDefault().TeamId == id).ToList();
            var club = await db.Clubs.Include(c => c.Ratings).ThenInclude(r => r.Tournament).ThenInclude(t => t.Season)
                                                           .Include(c => c.Country)
                                                           .Include(c => c.PlayerTeams).ThenInclude(p => p.Team)
                                                           .Include(c => c.CoachTeams).ThenInclude(c => c.Team).FirstOrDefaultAsync(c => c.Id == id);
            var matches = db.Matches.Include(m => m.Tournament).Include(m => m.Home).Include(m => m.Away)
                                           .Include(m => m.Goals).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Include(m => m.Asists).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Where(m => m.HomeTeam == id || m.AwayTeam == id).ToList();
            var stats = new ClubStats(club, matches);
            var clubView = new ClubViewModel()
            {
                Team = club,
                Matches = matches,
                Players = clubPlayers,
                Stats = stats,
                Ratings = club.Ratings.OrderBy(t => t.Tournament.LeagueId)
            };
            return View(clubView);
        }
        public async Task<IActionResult> ClubMatches(int id)
        {
            var matches = await db.Matches.Include(m => m.Tournament).Include(m => m.Home).Include(m => m.Away)
                                           .Include(m => m.Goals).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Include(m => m.Asists).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Where(m => m.HomeTeam == id || m.AwayTeam == id).OrderBy(m=>m.Data).ToListAsync();
            return View(matches);
        }
    }
}

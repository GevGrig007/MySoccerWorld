using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class NationalsController : Controller
    {
        private readonly ILogger<NationalsController> _logger;
        private readonly SoccerContext db;
        public NationalsController(ILogger<NationalsController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index(ClubsSort sortType = ClubsSort.ClubId)
        {
            IQueryable<National> nationals = db.Nationals.Include(c => c.CoachTeams).ThenInclude(c => c.Coach);
            ViewData["NameSort"] = sortType == ClubsSort.NameAsc ? ClubsSort.NameDesc : ClubsSort.NameAsc;
            ViewData["CountrySort"] = sortType == ClubsSort.CountryAsc ? ClubsSort.CountryDesc : ClubsSort.CountryAsc;
            nationals = sortType switch
            {
                ClubsSort.CountryAsc => nationals.OrderBy(c => c.Region),
                ClubsSort.CountryDesc => nationals.OrderByDescending(c => c.Region),
                ClubsSort.NameDesc => nationals.OrderByDescending(c => c.Name),
                ClubsSort.NameAsc => nationals.OrderBy(c => c.Name),
                _ => nationals.OrderBy(c => c.Id),
            };
            return View(await nationals.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            var players = await db.Players.Include(p => p.PlayerTeams.OrderBy(p => p.Season)).ThenInclude(p => p.Player).ToListAsync();
            var nationalPlayers = players.Where(p => p.PlayerTeams.FirstOrDefault().TeamId == id).ToList();
            var national = await db.Nationals.Include(c => c.Ratings).ThenInclude(r => r.Tournament).ThenInclude(t => t.Season)
                                                           .Include(c => c.PlayerTeams).ThenInclude(p => p.Team)
                                                           .Include(c => c.CoachTeams).ThenInclude(c => c.Team).FirstOrDefaultAsync(c => c.Id == id);
            var matches = db.Matches.Include(m => m.Tournament).Include(m => m.Home).Include(m => m.Away)
                                           .Include(m => m.Goals).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Include(m => m.Asists).ThenInclude(g => g.PlayerTeam).ThenInclude(p => p.Player)
                                           .Where(m => m.HomeTeam == id || m.AwayTeam == id).ToList();
            var stats = new ClubStats(national, matches);
            var clubView = new NationalViewModel()
            {
                Team = national,
                Matches = matches,
                Players = nationalPlayers,
                Stats = stats,
                Ratings = national.Ratings.OrderBy(t => t.Tournament.LeagueId)
            };
            return View(clubView);
        }
        public IActionResult CreatePlayer(int id)
        {
            National national = db.Nationals.Find(id);
            ViewBag.Players = db.Players.Include(p => p.PlayerTeams).Where(p => p.Country.Name == national.Name).ToList();
            return View(national);
        }

        [HttpPost]
        public IActionResult CreatePlayer(National national, int[] selectedPlayers)
        {
            Team newNational = db.Teams.Include(n => n.PlayerTeams).ThenInclude(p=>p.Player).FirstOrDefault(n => n.Id == national.Id);
            newNational.Name = national.Name;
            if (selectedPlayers != null)
            {
                foreach (var c in db.Players.Include(c=>c.PlayerTeams).Where(c => selectedPlayers.Contains(c.Id)))
                {
                    if (c.PlayerTeams.Any(c => c.Team == newNational)) { } 
                    else {
                        PlayerTeam playerTeams = new() { PlayerId =c.Id, TeamId = national.Id };
                        db.Add(playerTeams);
                    }           
                }
            }
            db.SaveChanges();
            return RedirectToAction("Details", new { id = newNational.Id });
        }
        public IActionResult CreateNational()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateNational([Bind("Name,Country,REgion")] National national)
        {
            if (ModelState.IsValid)
            {
                db.Add(national);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(national);
        }
    }
}

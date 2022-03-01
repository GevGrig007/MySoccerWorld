using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
using MySoccerWorld.Models.Services;
using MySoccerWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SoccerContext db;
        public TournamentsController(ILogger<HomeController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var leagues = await db.Leagues.ToListAsync();
            return View(leagues);
        }
        public async Task<IActionResult> OnlyRegional()
        {
            var leagues = await db.Leagues.Where(l => l.Type == "Regional").ToListAsync();
            return View("Index", leagues);
        }
        public async Task<IActionResult> OnlyEuroCups()
        {
            var leagues = await db.Leagues.Where(l => l.Type == "EuroCup").ToListAsync();
            return View("Index", leagues);
        }
        public async Task<IActionResult> OnlyNational()
        {
            var leagues = await db.Leagues.Where(l => l.Type == "National").ToListAsync();
            return View("Index", leagues);
        }
        // Details
        public async Task<IActionResult> RegionalDetails(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams.OrderBy(p => p.Season))
                .Include(t => t.BestPlayers).ThenInclude(b => b.PlayerTeam).ThenInclude(p => p.Player)
                .Include(t => t.Season)
                .Include(t => t.Matches)
                .Include(t => t.Matches).ThenInclude(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .Include(t => t.Matches).ThenInclude(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .FirstOrDefaultAsync(x => x.Id == id);
            var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToList();
            var standings = new Standing();
            var tournamentStandings = standings.CalculatingTable(tournament.Matches, tournament.Teams);
            var tournamentView = new TournamentViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                Matches = tournament.Matches.ToList(),
                Goals = goalscorers,
                Asists = asisters,
                BestPlayer = bestplayers,
                TournamentStandings = tournamentStandings.OrderByDescending(c => c.Points)
                                                         .ThenByDescending(c => c.GoalDifference)
                                                         .ThenByDescending(c => c.GoalsFor)
            };
            return View(tournamentView);
        }
    }
}

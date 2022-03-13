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
    public class LeaguesController : Controller
    {
        private readonly ILogger<LeaguesController> _logger;
        private readonly SoccerContext db;
        public LeaguesController(ILogger<LeaguesController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var leagues = await db.Leagues.ToListAsync();
            return View(leagues);
        }
        [HttpPost]
        public IActionResult Create(League league)
        {
            db.Add(league);
            db.SaveChanges();
            return RedirectToAction("Index", "Leagues");
        }
        public IActionResult Edit(int id)
        {
            var league = db.Leagues.FirstOrDefault(c => c.Id == id);
            return PartialView(league);
        }
        [HttpPost]
        public IActionResult Edit(League league)
        {
            db.Update(league);
            db.SaveChanges();
            return RedirectToAction("Index", "Leagues");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var league = db.Leagues.FirstOrDefault(c => c.Id == id);
            return PartialView(league);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(League league)
        {
            db.Remove(league);
            db.SaveChanges();
            return RedirectToAction("Index", "Leagues");
        }
        [HttpPost]
        public IActionResult CreateSeason(double dataseason)
        {
            Season season = new()
            {
                Data = dataseason
            };
            db.Seasons.Add(season);
            db.SaveChanges();
            return View();
        }
        public async Task<IActionResult> Details(int id)
        {
            var league = await db.Leagues.Include(l => l.Tournaments).ThenInclude(c => c.Season)
                                         .Include(l => l.Tournaments).ThenInclude(t => t.Ratings)
                                         .FirstOrDefaultAsync(l => l.Id == id);
            var tournaments = db.Tournaments.Include(t => t.Ratings).Where(t => t.LeagueId == id).ToList();
            var goalscorers = db.PlayerTeams.Include(p => p.Team).Include(p => p.Player).Include(p => p.Goals.Where(g => g.Match.Tournament.LeagueId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.Tournament.LeagueId == id));
            var macthes = db.Matches.Where(m => m.Tournament.LeagueId == id).Include(m => m.Home).Include(m => m.Away).ToList();
            var leagueView = new LeagueViewModel()
            {
                League = league,
                Tournaments = tournaments,
                Goals = goalscorers,
                Asists = asisters,
                Ratings = db.Ratings.Include(r => r.Team).Where(r => r.Tournament.LeagueId == id).Where(r => r.Tournament.Division == "1").ToList(),
                Matches = macthes
            };
            if (macthes.Count > 0) { var leagueStat = new LeagueStats(league, macthes); leagueView.Stats = leagueStat; }
            return View(leagueView);
        }
    }
}

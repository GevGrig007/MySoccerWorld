using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
using MySoccerWorld.Models.Entities;
using MySoccerWorld.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ILogger<RatingsController> _logger;
        private readonly SoccerContext db;
        public RatingsController(ILogger<RatingsController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public IActionResult Index()
        {
            var clubs = db.Clubs.Include(c => c.Ratings).Include(c => c.Country).ToList();
            return View(clubs);
        }
        public IActionResult NationalRanking()
        {
            var nationals = db.Nationals.Include(c => c.Ratings).ToList();
            return View(nationals);
        }
        public async Task<IActionResult> RatingsCreate()
        {
            var tournaments = await db.Tournaments.Include(t => t.Season).Include(t => t.Ratings).Include(t=>t.League).ToListAsync();
            return View(tournaments);
        }
        public IActionResult CalculateRating(int id)
        {
            var tournament = db.Tournaments.Include(t => t.Teams).Include(t => t.Matches).Include(t => t.League).FirstOrDefault(t => t.Id == id);
            var ratings = new TeamRating();
            if (tournament.TournamentType == TournamentType.Regular || tournament.TournamentType == TournamentType.RegularScandinav)
            {
                var ratingView = ratings.TeamRatingsRegular(tournament);
                return View(ratingView);
            }
            else
            {
                var ratingView = ratings.TeamRatingEuroCup(tournament);
                return View(ratingView);
            }
        }
        [HttpPost, ActionName("CalculateRating")]
        public IActionResult CalculateRatingCreate(int id)
        {
            var tournament = db.Tournaments.Include(t => t.Ratings).Include(t => t.Teams).Include(t => t.Matches).Include(t => t.League).FirstOrDefault(t => t.Id == id);
            var ratings = new TeamRating();
            if (tournament.TournamentType == TournamentType.Regular || tournament.TournamentType == TournamentType.RegularScandinav)
            {
                var ratingView = ratings.TeamRatingsRegular(tournament);
                if (tournament.Ratings.Count() == 0)
                {
                    db.Ratings.AddRange(ratingView);
                    db.SaveChanges();
                }
            }
            else
            {
                var ratingView = ratings.TeamRatingEuroCup(tournament);
                if (tournament.Ratings.Count() == 0)
                {
                    db.Ratings.AddRange(ratingView);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("RatingsCreate");
        }
        public async Task<IActionResult> TopScorers()
        {
            var players = await db.Players.Include(p => p.Country).Include(p => p.PlayerTeams)
                                                                  .ThenInclude(p => p.Goals)
                                                                  .Include(p=>p.PlayerTeams)
                                                                  .ThenInclude(p=>p.Asists)
                                                                  .ToListAsync();
            return View(players);
        }
        public async Task<IActionResult> SeasonalScorer(int? id)
        {
            Season season;
            if (id != null) { season = await db.Seasons.FirstOrDefaultAsync(s => s.Id == id); }
            else { season = await db.Seasons.OrderBy(s => s.Id).LastOrDefaultAsync(); } 
            var players = await db.Players.Include(p => p.Country).Include(p => p.PlayerTeams)
                                                                  .ThenInclude(p => p.Goals.Where(g=>g.Match.Tournament.Season==season))
                                                                  .Include(p => p.PlayerTeams)
                                                                  .ThenInclude(p => p.Asists.Where(g => g.Match.Tournament.Season == season))
                                                                  .ToListAsync();
            ViewBag.Seasons = await db.Seasons.OrderByDescending(s=>s.Data).ToListAsync();
            return View(players);
        }
    }
}

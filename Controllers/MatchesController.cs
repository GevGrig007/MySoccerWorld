using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
using MySoccerWorld.Models.Entities;
using MySoccerWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Controllers
{
    public class MatchesController : Controller
    {
        private readonly ILogger<MatchesController> _logger;
        private readonly SoccerContext db;
        public MatchesController(ILogger<MatchesController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var match = await db.Matches.Include(m => m.Home)
                                  .Include(m => m.Away)
                                  .FirstOrDefaultAsync(m => m.Id == id);
            ViewData["AwayTeam"] = new SelectList(db.Teams, "Id", "Name", match.AwayTeam);
            ViewData["HomeTeam"] = new SelectList(db.Teams, "Id", "Name", match.HomeTeam);
            ViewData["TournamentId"] = new SelectList(db.Tournaments, "Id", "Name", match.TournamentId);
            return View(match);
        }
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,Round,Group,Neytral,Data,HomeTeam,AwayTeam,HomeScore,AwayScore,HomeEx,AwayEx,HomePen,AwayPen,TournamentId")] Match match)
        {
            db.Matches.Update(match);
            await db.SaveChangesAsync();
            return RedirectToAction("Matches", "Tournaments", new { id = match.TournamentId });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var match = await db.Matches.Include(m => m.Home)
                                  .Include(m => m.Away)
                                  .FirstOrDefaultAsync(m => m.Id == id);
            return View(match);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var match = await db.Matches.FindAsync(id);
            db.Matches.Remove(match);
            await db.SaveChangesAsync();
            return RedirectToAction("Matches", "Tournaments", new { id = match.TournamentId });
        }
        public async Task<IActionResult> EditScore(int id)
        {
            var match = await db.Matches.Include(m => m.Home).Include(m => m.Away)
                                        .Include(m => m.Tournament).ThenInclude(m => m.League)
                                        .FirstOrDefaultAsync(m => m.Id == id);
            var players = db.Players.Include(p => p.PlayerTeams.OrderBy(p => p.Season)).ThenInclude(p => p.Player)
                                     .Include(p => p.PlayerTeams).ThenInclude(p => p.Goals)
                                     .Include(p => p.PlayerTeams).ThenInclude(p => p.Asists)
                                    .ToList();
            if (match.Tournament.League.Type == "National")
            {
                var matchView = new MatchViewModel()
                {
                    Match = match,
                    HomePlayers = players.Where(p => p.PlayerTeams.FirstOrDefault().TeamId == match.HomeTeam).ToList(),
                    AwayPlayers = players.Where(p => p.PlayerTeams.FirstOrDefault().TeamId == match.AwayTeam).ToList()
                };
                return View(matchView);
            }
            else
            {
                var matchView = new MatchViewModel()
                {
                    Match = match,
                    HomePlayers = players.Where(p => p.PlayerTeams.LastOrDefault().TeamId == match.HomeTeam).ToList(),
                    AwayPlayers = players.Where(p => p.PlayerTeams.LastOrDefault().TeamId == match.AwayTeam).ToList()
                };
                return View(matchView);
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> EditScore(int id, [Bind("Id,Round,Neytral,Data,HomeTeam,AwayTeam,HomeScore,AwayScore,TournamentId,Group")] Match match)
        {
            db.Update(match);
            await db.SaveChangesAsync();
            var tournament = db.Tournaments.Find(match.TournamentId);
            var link = "";
            if (tournament.TournamentType == TournamentType.Regular)
            {
                link = "RegionalDetails";
            }
            else if (tournament.TournamentType == TournamentType.EuroCup)
            {
                link = "EuroCupDetails";
            }
            else if (tournament.TournamentType == TournamentType.EuroCupKnockOut)
            {
                link = "EuroCupKnockOut";
            }
            else if (tournament.TournamentType == TournamentType.National8)
            {
                link = "NationalDetails";
            }
            else if (tournament.TournamentType == TournamentType.NationalEuro)
            {
                link = "NationalEuro";
            }
            else if (tournament.TournamentType == TournamentType.Qualification)
            {
                link = "Qualification";
            }
            return RedirectToAction(link, "Tournaments", new { id = match.Tournament.Id });
        }
        [HttpPost]
        public async Task<IActionResult> GoalsAdd([Bind("MatchId,PlayerTeamId")] Goal goal)
        {
            var match = await db.Matches.FirstOrDefaultAsync(m => m.Id == goal.MatchId);
            await db.Goals.AddRangeAsync(goal);
            await db.SaveChangesAsync();
            return RedirectToAction("EditScore", "Matches", new { id = match.Id });
        }
        [HttpPost]
        public async Task<IActionResult> AsistAdd([Bind("MatchId,PlayerTeamId")] Asist asist)
        {
            await db.Asists.AddRangeAsync(asist);
            await db.SaveChangesAsync();
            return RedirectToAction("EditScore", "Matches", new { id = asist.MatchId });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
using MySoccerWorld.Models.Entities;
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
    }
}

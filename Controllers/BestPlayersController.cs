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
    public class BestPlayersController : Controller
    {
        private readonly ILogger<BestPlayersController> _logger;
        private readonly SoccerContext db;
        public BestPlayersController(ILogger<BestPlayersController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public IActionResult Create(int id)
        {
            var tournament = db.Tournaments.Find(id);
            ViewBag.Players = new SelectList(db.Players.Include(p => p.PlayerTeams).OrderBy(p => p.Name), "Id", "Name");
            ViewData["TournamentId"] = tournament.Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(int[] TournamentId, int[] Position, int[] PlayerTeamId)
        {
            for (int i = 0; i < TournamentId.Length; i++)
            {
                var player = db.Players.Include(p => p.PlayerTeams).ThenInclude(p=>p.Season).FirstOrDefault(p => p.Id == PlayerTeamId[i]);
                var playerTeam = player.PlayerTeams.Where(p=>p.Season!=null).LastOrDefault();
                var bestplayer = new BestPlayer()
                {
                    TournamentId = TournamentId[i],
                    PlayerTeamId = playerTeam.Id,
                    Position = Position[i]
                };
                db.Add(bestplayer);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Shedulles", new { id = TournamentId[1] });
        }
        public async Task<IActionResult> Edit(int id)
        {
            var bestPlayer = await db.BestPlayers.FindAsync(id);
            ViewData["PlayerTeamId"] = new SelectList(db.PlayerTeams.Include(p => p.Player), "Id", "Player.Name", bestPlayer.PlayerTeamId);
            ViewData["TournamentId"] = new SelectList(db.Tournaments, "Id", "Name", bestPlayer.TournamentId);
            return View(bestPlayer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,TournamentId,Position,PlayerTeamId")] BestPlayer bestPlayer)
        {
            db.Update(bestPlayer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Shedulles", new { id = bestPlayer.TournamentId });
        }

    }
}

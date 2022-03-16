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
    public class PlayersController : Controller
    {
        private readonly ILogger<PlayersController> _logger;
        private readonly SoccerContext db;
        public PlayersController(ILogger<PlayersController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index(PlayersSort sortType = PlayersSort.PlayerId)
        {
            IQueryable<Player> players = db.Players.Include(p => p.PlayerTeams.OrderBy(p => p.Season)).ThenInclude(p => p.Team).Include(p => p.Country);
            ViewData["NameSort"] = sortType == PlayersSort.NameAsc ? PlayersSort.NameDesc : PlayersSort.NameAsc;
            players = sortType switch
            {
                PlayersSort.NameAsc => players.OrderBy(p => p.Name),
                PlayersSort.NameDesc => players.OrderByDescending(p => p.Name),
                _ => players.OrderBy(p => p.Id)
            };
            return View(await players.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            var player = await db.Players.Include(p => p.PlayerTeams).ThenInclude(p => p.Team)                                         
                                         .Include(p => p.PlayerTeams).ThenInclude(p => p.Season)
                                         .Include(p => p.PlayerTeams).ThenInclude(p => p.Goals)
                                         .Include(p => p.PlayerTeams).ThenInclude(p => p.Asists).FirstOrDefaultAsync(p => p.Id == id);
            return View(player);
        }
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(db.Countries.OrderBy(c => c.Name), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,CountryId")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Add(player);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(db.Countries, "Id", "Id", player.CountryId);
            return View(player);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            var player = await db.Players.Include(p => p.Country).FirstOrDefaultAsync(p => p.Id == id);
            ViewData["CountryId"] = new SelectList(db.Countries.OrderBy(c => c.Name), "Id", "Name", player.CountryId);
            return View(player);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CountryId")] Player player)
        {
            db.Update(player);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            var player = await db.Players
                .Include(p => p.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            return View(player);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await db.Players.FindAsync(id);
            db.Players.Remove(player);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult PlayerTeams()
        {
            ViewData["PlayerId"] = new SelectList(db.Players.OrderBy(p => p.Name), "Id", "Name");
            ViewData["SeasonId"] = new SelectList(db.Seasons, "Id", "Data");
            ViewData["TeamId"] = new SelectList(db.Teams, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult PlayerTeams([Bind("Id,PlayerId,TeamId,SeasonId")] PlayerTeam playerTeam)
        {
            db.Add(playerTeam);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddPlayerTeams(int id)
        {
            var player = db.Players.Find(id);
            ViewData["PlayerId"] = player;
            ViewData["SeasonId"] = new SelectList(db.Seasons.OrderByDescending(s => s.Data), "Id", "Data");
            ViewData["TeamId"] = new SelectList(db.Teams, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddPlayerTeams([Bind("PlayerId,TeamId,SeasonId")] PlayerTeam playerTeam)
        {
            db.Add(playerTeam);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

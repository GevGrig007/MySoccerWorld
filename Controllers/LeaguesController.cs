using Microsoft.AspNetCore.Mvc;
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
    public class LeaguesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SoccerContext db;
        public LeaguesController(ILogger<HomeController> logger, SoccerContext context)
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
    }
}

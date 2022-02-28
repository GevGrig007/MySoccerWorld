using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySoccerWorld.Models;
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
    }
}

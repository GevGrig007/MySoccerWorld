using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ShedullesController : Controller
    {
        private readonly ILogger<ShedullesController> _logger;
        private readonly SoccerContext db;
        public ShedullesController(ILogger<ShedullesController> logger, SoccerContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .Include(t => t.Matches)
                .Include(t => t.Matches).ThenInclude(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .Include(t => t.Matches).ThenInclude(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .FirstOrDefaultAsync(x => x.Id == id);
            var teams = tournament.Teams.ToList();
            ViewBag.Teams = new SelectList(teams, "Id", "Name");
            ViewBag.BestPlayers = await db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToListAsync();
            return View(tournament);
        }
        // Add Teams
        [HttpGet]
        public IActionResult AddTeams(int id)
        {
            Tournament tournament = db.Tournaments.Include(t => t.Teams).Include(t => t.League).FirstOrDefault(t => t.Id == id);
            if (tournament == null)
            {
                return NotFound();
            }
            ViewBag.Clubs = db.Clubs.Where(c => c.Country.Region == tournament.League.Region).ToList();
            ViewBag.EuroClubs = db.Clubs.ToList();
            ViewBag.Nationals = db.Nationals.OrderBy(n=>n.Region).ToList();
            return View(tournament);
        }
        [HttpPost]
        public IActionResult AddTeams(Tournament tournament, int[] selectedClubs)
        {
            Tournament newTournament = db.Tournaments.Include(t => t.Teams).FirstOrDefault(t => t.Id == tournament.Id);
            newTournament.Name = tournament.Name;
            newTournament.Teams.Clear();
            if (selectedClubs != null)
            {
                foreach (var c in db.Teams.Where(c => selectedClubs.Contains(c.Id)))
                {
                    newTournament.Teams.Add(c);
                }
            }
            db.Entry(newTournament).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", new { id = newTournament.Id });
        }
        // Sheduelles

        [HttpPost]
        public async Task<IActionResult> ShedulleFor9(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.GenerateFor9Teams(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleFor12(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.GenerateFor12Teams(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleFor16(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.GenerateFor16Teams(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleGroup(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            if (teams.Count == 32)
            {
                var groupAteams = new List<Team> { teams[0], teams[1], teams[2], teams[3] };
                var groupBteams = new List<Team> { teams[4], teams[5], teams[6], teams[7] };
                var groupCteams = new List<Team> { teams[8], teams[9], teams[10], teams[11] };
                var groupDteams = new List<Team> { teams[12], teams[13], teams[14], teams[15] };
                var groupEteams = new List<Team> { teams[16], teams[17], teams[18], teams[19] };
                var groupFteams = new List<Team> { teams[20], teams[21], teams[22], teams[23] };
                var groupGteams = new List<Team> { teams[24], teams[25], teams[26], teams[27] };
                var groupHteams = new List<Team> { teams[28], teams[29], teams[30], teams[31] };
                var groupA = new TournamentGroup { Name = "A" };
                var groupAm = groupA.GroupShedulle(tournament, groupAteams, data);
                db.Matches.AddRange(groupAm);
                var groupB = new TournamentGroup { Name = "B" };
                var groupBm = groupB.GroupShedulle(tournament, groupBteams, data);
                db.Matches.AddRange(groupBm);
                var groupC = new TournamentGroup { Name = "C" };
                var groupCm = groupC.GroupShedulle(tournament, groupCteams, data);
                db.Matches.AddRange(groupCm);
                var groupD = new TournamentGroup { Name = "D" };
                var groupDm = groupD.GroupShedulle(tournament, groupDteams, data);
                db.Matches.AddRange(groupDm);
                var groupE = new TournamentGroup { Name = "E" };
                var groupEm = groupE.GroupShedulle(tournament, groupEteams, data);
                db.Matches.AddRange(groupEm);
                var groupF = new TournamentGroup { Name = "F" };
                var groupFm = groupF.GroupShedulle(tournament, groupFteams, data);
                db.Matches.AddRange(groupFm);
                var groupG = new TournamentGroup { Name = "G" };
                var groupGm = groupG.GroupShedulle(tournament, groupGteams, data);
                db.Matches.AddRange(groupGm);
                var groupH = new TournamentGroup { Name = "H" };
                var groupHm = groupH.GroupShedulle(tournament, groupHteams, data);
                db.Matches.AddRange(groupHm);
                db.SaveChanges();
            }
            else if (teams.Count == 20)
            {
                var groupAteams = new List<Team> { teams[0], teams[1], teams[2], teams[3], teams[4] };
                var groupBteams = new List<Team> { teams[5], teams[6], teams[7], teams[8], teams[9] };
                var groupCteams = new List<Team> { teams[10], teams[11], teams[12], teams[13], teams[14] };
                var groupDteams = new List<Team> { teams[15], teams[16], teams[17], teams[18], teams[19] };
                var groupA = new TournamentGroup { Name = "A" };
                var groupAm = groupA.EuroGroupShedulle(tournament, groupAteams, data);
                db.Matches.AddRange(groupAm);
                var groupB = new TournamentGroup { Name = "B" };
                var groupBm = groupB.EuroGroupShedulle(tournament, groupBteams, data);
                db.Matches.AddRange(groupBm);
                var groupC = new TournamentGroup { Name = "C" };
                var groupCm = groupC.EuroGroupShedulle(tournament, groupCteams, data);
                db.Matches.AddRange(groupCm);
                var groupD = new TournamentGroup { Name = "D" };
                var groupDm = groupD.EuroGroupShedulle(tournament, groupDteams, data);
                db.Matches.AddRange(groupDm);     
            }
            else if (teams.Count == 16)
            {
                var groupAteams = new List<Team> { teams[0], teams[1], teams[2], teams[3] };
                var groupBteams = new List<Team> { teams[4], teams[5], teams[6], teams[7] };
                var groupCteams = new List<Team> { teams[8], teams[9], teams[10], teams[11] };
                var groupDteams = new List<Team> { teams[12], teams[13], teams[14], teams[15] };
                var groupA = new TournamentGroup { Name = "A" };
                var groupAm = groupA.GroupShedulle(tournament, groupAteams, data);
                db.Matches.AddRange(groupAm);
                var groupB = new TournamentGroup { Name = "B" };
                var groupBm = groupB.GroupShedulle(tournament, groupBteams, data);
                db.Matches.AddRange(groupBm);
                var groupC = new TournamentGroup { Name = "C" };
                var groupCm = groupC.GroupShedulle(tournament, groupCteams, data);
                db.Matches.AddRange(groupCm);
                var groupD = new TournamentGroup { Name = "D" };
                var groupDm = groupD.GroupShedulle(tournament, groupDteams, data);
                db.Matches.AddRange(groupDm);
            }
            else if (teams.Count == 8)
            {
                var groupAteams = new List<Team> { teams[0], teams[1], teams[2], teams[3] };
                var groupBteams = new List<Team> { teams[4], teams[5], teams[6], teams[7] };
                var groupA = new TournamentGroup { Name = "A" };
                var groupAm = groupA.GroupShedulle(tournament, groupAteams, data);
                db.Matches.AddRange(groupAm);
                var groupB = new TournamentGroup { Name = "B" };
                var groupBm = groupB.GroupShedulle(tournament, groupBteams, data);
                db.Matches.AddRange(groupBm);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleKnockOut32(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Shedulle32(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleKnockOut16(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Shedulle16(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleKnockOut8(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Shedulle8(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleKnockOutQuarterDouble(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.QuartersDouble(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleKnockOutSemiDouble(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.SemiDouble(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleFinal(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Final(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedullEuro8(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.ShedulleEuro8(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleQuarter(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Quarters(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
        [HttpPost]
        public async Task<IActionResult> ShedulleSemi(int id, int[] clubs, double data)
        {
            Tournament tournament = await db.Tournaments.FindAsync(id);
            var teams = new List<Team>();
            for (var i = 0; i < clubs.Length; i++)
            {
                var team = db.Teams.Find(clubs[i]);
                teams.Add(team);
            };
            var generateShedulle = new CreatorShedulles();
            var fixtures = generateShedulle.Semi(tournament, teams, data);
            db.Matches.AddRange(fixtures);
            db.SaveChanges();
            return RedirectToAction("Index", "Tournaments");
        }
    }
}

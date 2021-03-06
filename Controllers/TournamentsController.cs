using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class TournamentsController : Controller
    {
        private readonly ILogger<TournamentsController> _logger;
        private readonly SoccerContext db;
        public TournamentsController(ILogger<TournamentsController> logger, SoccerContext context)
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
                .Include(t => t.Season)
                .FirstOrDefaultAsync(x => x.Id == id);
            var matches = await db.Matches.Where(x => x.TournamentId == id).Include(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .Include(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .ToListAsync();
            var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = await db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToListAsync();
            if (matches.Count > 0)
            {
                var standings = new Standings();
                var tournamentStandings = standings.CalculatingTable(tournament.Matches, tournament.Teams);
                var tournamentView = new TournamentViewModel()
                {
                    Tournament = tournament,
                    Teams = tournament.Teams.ToList(),
                    Matches = matches,
                    Goals = goalscorers,
                    Asists = asisters,
                    BestPlayer = bestplayers,
                    TournamentStandings = tournamentStandings.OrderByDescending(c => c.Points)
                                                             .ThenByDescending(c => c.GoalDifference)
                                                             .ThenByDescending(c => c.GoalsFor)
                };
                return View(tournamentView);
            }
            var emptyTournamnet = new TournamentViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                Matches = matches,
                BestPlayer = bestplayers
            };
            return View(emptyTournamnet);
        }
        public async Task<IActionResult> EuroCupDetails(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .FirstOrDefaultAsync(x => x.Id == id);
            var matches = await db.Matches.Where(x => x.TournamentId == id).Include(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .Include(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .ToListAsync();
            var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = await db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToListAsync();
            var groups = new TournamentGroup();
            if (matches.Count > 0)
            {
                var tournamentsGroup = groups.Group8(tournament);
                var tournamentView = new EuroCupViewModel()
                {
                    Tournament = tournament,
                    Teams = tournament.Teams.ToList(),
                    Matches = matches,
                    Goals = goalscorers,
                    Asists = asisters,
                    BestPlayer = bestplayers,
                    Groups = tournamentsGroup
                };
                return View(tournamentView);
            };
            var emptyTournamnet = new EuroCupViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                Matches = matches,
                BestPlayer = bestplayers
            };
            return View(emptyTournamnet);
        }
        public async Task<IActionResult> EuroCupKnockOut(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .FirstOrDefaultAsync(x => x.Id == id);
            var matches = await db.Matches.Where(x => x.TournamentId == id).Include(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .Include(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .ToListAsync();
            var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToList();
            var tournamentView = new KnockOutViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                Matches = matches,
                Goals = goalscorers,

                Asists = asisters,
                BestPlayer = bestplayers
            };
            return View(tournamentView);
        }
        public async Task<IActionResult> NationalDetails(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .FirstOrDefaultAsync(x => x.Id == id);
            var matches = await db.Matches.Where(x => x.TournamentId == id).Include(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .Include(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .ToListAsync();
            //var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var goalscorers = db.PlayerTeams.Where(p=>p.Goals.Where(g=>g.Match.TournamentId==id).Count()>0).Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToList();
            var groups = new TournamentGroup();
            if (matches.Count > 0)
            {
                var tournamentsGroup = groups.Group2(tournament);
                var tournamentView = new EuroCupViewModel()
                {
                    Tournament = tournament,
                    Teams = tournament.Teams.ToList(),
                    Matches = matches,
                    Goals = goalscorers,
                    Asists = asisters,
                    BestPlayer = bestplayers,
                    Groups = tournamentsGroup
                };
                return View(tournamentView);
            };
            var emptyTournamnet = new EuroCupViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                BestPlayer = bestplayers,
                Matches = matches
            };
            return View(emptyTournamnet);
        }
        public async Task<IActionResult> NationalEuro(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .FirstOrDefaultAsync(x => x.Id == id);
            var matches = await db.Matches.Where(x => x.TournamentId == id).Include(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .Include(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                                          .ToListAsync();
            var goalscorers = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Goals.Where(g => g.Match.TournamentId == id));
            var asisters = db.PlayerTeams.Include(p => p.Player).Include(p => p.Team).Include(p => p.Asists.Where(g => g.Match.TournamentId == id));
            var bestplayers = db.BestPlayers.Include(b => b.PlayerTeam).ThenInclude(p => p.Player)
                                            .Include(b => b.PlayerTeam).ThenInclude(p => p.Team)
                                            .Where(p => p.TournamentId == id).ToList();
            var groups = new TournamentGroup();
            if (matches.Count > 0)
            {
                var tournamentsGroup = groups.EuroGroup(tournament);
                var tournamentView = new EuroCupViewModel()
                {
                    Tournament = tournament,
                    Teams = tournament.Teams.ToList(),
                    Matches = matches,
                    Goals = goalscorers,
                    Asists = asisters,
                    BestPlayer = bestplayers,
                    Groups = tournamentsGroup
                };
                return View(tournamentView);
            };
            var emptyTournamnet = new EuroCupViewModel()
            {
                Tournament = tournament,
                Teams = tournament.Teams.ToList(),
                BestPlayer = bestplayers,
                Matches = matches
            };
            return View(emptyTournamnet);
        }
        public async Task<IActionResult> Qualification(int id)
        {
            var tournament = await db.Tournaments
                .Include(t => t.League)
                .Include(t => t.Teams).ThenInclude(t => t.PlayerTeams)
                .Include(t => t.Season)
                .Include(t => t.Matches)
                .Include(t => t.Matches).ThenInclude(m => m.Goals).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .Include(t => t.Matches).ThenInclude(m => m.Asists).ThenInclude(p => p.PlayerTeam).ThenInclude(pt => pt.Player)
                .FirstOrDefaultAsync(x => x.Id == id);
            var view = new QualificationViewModel()
            {
                Tournament = tournament,
                Matches = tournament.Matches.ToList()
            };
            return View(view);
        }
        // CRUD Tournaments 
        public async Task<IActionResult> TournamentManage(int id)
        {
            var tournaments = await db.Tournaments.Include(t => t.Season).Where(t => t.LeagueId == id).ToListAsync();
            ViewBag.Leagues = new SelectList(db.Leagues, "Id", "Name");
            ViewBag.Seasons = new SelectList(db.Seasons.OrderByDescending(s=>s.Data), "Id", "Data");
            return View(tournaments);
        }
        [HttpPost]
        public IActionResult Create(Tournament tournament)
        {
            ViewBag.Leagues = new SelectList(db.Leagues, "Id", "Name", tournament.LeagueId);
            ViewBag.Seasons = new SelectList(db.Seasons, "Id", "Data", tournament.SeasonId);
            db.Update(tournament);
            db.SaveChanges();
            return RedirectToAction("TournamentManage", "Tournaments", new { id = tournament.LeagueId });
        }
        public async Task<IActionResult> Edit(int id)
        {
            var tournament = await db.Tournaments.Include(t => t.Season).Include(t => t.League).FirstOrDefaultAsync(t => t.Id == id);
            ViewBag.Leagues = new SelectList(db.Leagues, "Id", "Name");
            ViewBag.Seasons = new SelectList(db.Seasons, "Id", "Data");
            return PartialView(tournament);
        }
        [HttpPost]
        public IActionResult Edit(Tournament tournament)
        {
            ViewBag.Leagues = new SelectList(db.Leagues, "Id", "Name", tournament.LeagueId);
            ViewBag.Seasons = new SelectList(db.Seasons, "Id", "Data", tournament.SeasonId);
            db.Update(tournament);
            db.SaveChanges();
            return RedirectToAction("TournamentManage", "Tournaments", new { id = tournament.LeagueId });
        }
        [HttpPost]
        public IActionResult EditBP(int id, BPSchema bp)
        {
            var tournament = db.Tournaments.Find(id);
            tournament.BestPlayerSchema = bp;
            db.Update(tournament);
            db.SaveChanges();
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
            return RedirectToAction(link, "Tournaments", new { id = tournament.Id });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var tournament = await db.Tournaments.Include(t => t.Season).Include(t => t.League).FirstOrDefaultAsync(t => t.Id == id);
            return PartialView(tournament);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(Tournament tournament)
        {
            db.Remove(tournament);
            db.SaveChanges();
            return RedirectToAction("TournamentManage", "Tournaments", new { id = tournament.LeagueId });
        }
        // Matches
        public async Task<IActionResult> Matches(int id)
        {
            var tournament = await db.Tournaments.Include(t => t.Matches).ThenInclude(m => m.Home)
                                   .Include(t => t.Matches).ThenInclude(m => m.Away)
                                   .Include(t => t.Season)
                                   .FirstOrDefaultAsync(t => t.Id == id);
            return View(tournament);
        }
        // GoalScorers
        public async Task<IActionResult> GoalScorers(int id)
        {
            var tournament = await db.Tournaments.FirstOrDefaultAsync(p => p.Id == id);
            var players =await db.PlayerTeams.Include(p=>p.Player).Include(p=>p.Team)
                                             .Include(p=>p.Player).ThenInclude(p=>p.Country)
                                             .Include(p => p.Goals.Where(g => g.Match.Tournament == tournament))
                                             .Include(p => p.Asists.Where(g => g.Match.Tournament == tournament)).ToListAsync();
            var awards = await db.TournamentAwards.Include(a => a.PlayerTeam).ThenInclude(p => p.Player)
                                                  .Include(a => a.PlayerTeam).ThenInclude(p => p.Team)
                                                  .Include(a => a.CoachTeam).ThenInclude(p => p.Coach)
                                                  .Include(a => a.CoachTeam).ThenInclude(p => p.Team)
                                                  .Where(t => t.TournamentId == id).ToListAsync();
            var view = new GoalScorersViewModel()
            {
                PlayerTeams = players,
                Tournament = tournament,
                TournamentAwards = awards
            };
            return View(view);
        }
        public IActionResult CreateAwards(int id)
        {
            Tournament tournament = db.Tournaments.Find(id);
            ViewBag.Tournament = tournament;
            ViewBag.Players = new SelectList(db.Players.Include(p => p.PlayerTeams).OrderBy(p => p.Name), "Id", "Name");
            ViewBag.Coaches = new SelectList(db.Coaches.Include(p => p.CoachTeams).OrderBy(p => p.Name), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateAwards(int TournamentId, int? PlayerTeamId , int? CoachTeamId, AwardsType AwardsName)
        {
            var tournamentaward = new TournamentAward();
            if (PlayerTeamId != null)
            {
                var player = db.Players.Include(p => p.PlayerTeams).ThenInclude(p => p.Season).FirstOrDefault(p => p.Id == PlayerTeamId);
                var playerTeam = player.PlayerTeams.Where(p => p.Season != null).LastOrDefault();
                tournamentaward.PlayerTeamId = playerTeam.Id;
                tournamentaward.TournamentId = TournamentId;
                tournamentaward.AwardsName = AwardsName;
                db.Add(tournamentaward);
                db.SaveChanges();
            }
            if(CoachTeamId != null)
            {
                var coach = db.Coaches.Include(p => p.CoachTeams).ThenInclude(p => p.Season).FirstOrDefault(p => p.Id == CoachTeamId);
                var coachteam = coach.CoachTeams.Where(p => p.Season != null).LastOrDefault();
                tournamentaward.CoachTeamId = coachteam.Id;
                tournamentaward.TournamentId = TournamentId;
                tournamentaward.AwardsName = AwardsName;
                db.Add(tournamentaward);
                db.SaveChanges();
            }
            return RedirectToAction("GoalScorers",  new { id = TournamentId });
        }
    }
}

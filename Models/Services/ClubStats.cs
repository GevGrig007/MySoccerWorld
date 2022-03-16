using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Services
{
    public class ClubStats
    {
        public int Games { get; set; }
        public int? GoalsFor { get; set; }
        public int? GoalsAgainst { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }
        public Match OverResultGame { get; set; }
        public Match MaxWin { get; set; }

        public ClubStats(Team team, List<Match> matches)
        {
            Games = matches.Count();
            List<Match> Homes = matches.Where(m => m.HomeTeam == team.Id).ToList();
            List<Match> Aways = matches.Where(m => m.AwayTeam == team.Id).ToList();
            Win = Homes.Count(m => m.HomeScore > m.AwayScore) + Aways.Count(m => m.AwayScore > m.HomeScore);
            Draw = matches.Count(m => m.HomeScore == m.AwayScore);
            Lost = Homes.Count(m => m.HomeScore < m.AwayScore) + Aways.Count(m => m.AwayScore < m.HomeScore);
            GoalsFor = Homes.Sum(m => m.HomeScore) + Homes.Sum(m => m.HomeEx) + Aways.Sum(m => m.AwayEx) + Aways.Sum(m => m.AwayScore);
            GoalsAgainst = Homes.Sum(m => m.AwayScore) + Homes.Sum(m => m.AwayEx) + Aways.Sum(m => m.HomeEx) + Aways.Sum(m => m.HomeScore);
            OverResultGame = matches.OrderBy(m => m.HomeScore + m.AwayScore).Last();
            MaxWin = Homes.OrderByDescending(m => (m.HomeScore - m.AwayScore) - (m.AwayScore - m.HomeScore)).First();
        }
    }
}

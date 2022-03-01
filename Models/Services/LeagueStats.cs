using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Services
{
    public class LeagueStats
    {
        public int Games { get; set; }
        public int? Goals { get; set; }
        public Match OverResultGame { get; set; }
        public Match MaxWin { get; set; }
        public double? AverageTotal { get; set; }
        public LeagueStats(League league, List<Match> matches)
        {
            Games = matches.Count();
            Goals = matches.Sum(m => m.HomeScore + m.AwayScore);
            OverResultGame = matches.OrderBy(m => m.HomeScore + m.AwayScore).Last();
            MaxWin = matches.OrderByDescending(m => (m.HomeScore - m.AwayScore) - (m.AwayScore - m.HomeScore)).First();
            AverageTotal = matches.Average(m => m.HomeScore + m.AwayScore);
        }
    }
}

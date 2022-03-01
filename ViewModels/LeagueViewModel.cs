using MySoccerWorld.Models.Entities;
using MySoccerWorld.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.ViewModels
{
    public class LeagueViewModel
    {
        public League League { get; set; }
        public List<Tournament> Tournaments { get; set; }
        public IEnumerable<PlayerTeam> Goals { get; set; }
        public IEnumerable<PlayerTeam> Asists { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public List<Match> Matches { get; set; }
        public LeagueStats Stats { get; set; }
    }
}

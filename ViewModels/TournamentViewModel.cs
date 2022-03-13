using MySoccerWorld.Models.Entities;
using MySoccerWorld.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.ViewModels
{
    public class TournamentViewModel
    {
        public Tournament Tournament { get; set; }
        public List<Team> Teams { get; set; }
        public List<Match> Matches { get; set; }
        public IEnumerable<PlayerTeam> Goals { get; set; }
        public IEnumerable<PlayerTeam> Asists { get; set; }
        public List<BestPlayer> BestPlayer { get; set; }
        public IEnumerable<TournamentTable> TournamentStandings { get; set; }
    }
}

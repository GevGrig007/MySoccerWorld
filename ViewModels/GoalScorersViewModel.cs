using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.ViewModels
{
    public class GoalScorersViewModel
    {
        public Tournament Tournament { get; set; }
        public IEnumerable<PlayerTeam> PlayerTeams { get; set; }
        public IEnumerable<TournamentAward> TournamentAwards { get; set; }
    }
}

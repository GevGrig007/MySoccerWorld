using MySoccerWorld.Models.Entities;
using MySoccerWorld.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.ViewModels
{
    public class ClubViewModel
    {
        public Club Team { get; set; }
        public List<Match> Matches { get; set; }
        public List<Player> Players { get; set; }
        public ClubStats Stats { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
    }
}

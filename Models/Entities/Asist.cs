using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Entities
{
    public class Asist
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        public int PlayerTeamId { get; set; }
        public PlayerTeam PlayerTeam { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Entities
{
    public class SeasonalAward
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public virtual Season Season { get; set; }
        public int PlayerTeamId { get; set; }
        public virtual PlayerTeam PlayerTeam { get; set; }
        public AwardsType AwardsName { get; set; }
        public CoachTeam BestCoach { get; set; }

    }
}

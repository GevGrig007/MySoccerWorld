using System.Collections.Generic;

namespace MySoccerWorld.Models.Entities
{
    public class TournamentAward
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public virtual Tournament Tournament { get; set; }
        public AwardsType AwardsName { get; set; }
        public int? PlayerTeamId { get; set; }
        public virtual PlayerTeam PlayerTeam { get; set; }        
        public int? CoachTeamId { get; set; }
        public virtual CoachTeam CoachTeam { get; set; }
    }
}

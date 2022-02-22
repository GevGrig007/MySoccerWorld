using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models
{
    public class MatchesMap : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasOne
                (match => match.Home)
                .WithMany(Team => Team.Homes)
                .HasForeignKey(match => match.HomeTeam)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne
                (match => match.Away)
                .WithMany(Team => Team.Aways)
                .HasForeignKey(match => match.AwayTeam)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

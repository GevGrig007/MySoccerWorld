using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Services
{
    public class Standing
    {
        public static readonly int PointsForWin = 3;
        public static readonly int PointsForDraw = 1;
        public static readonly int PointsForLoss = 0;
        public List<TournamentTable> CalculatingTable(IEnumerable<Match> matches, ICollection<Team> teams)
        {
            var table = new List<TournamentTable>();
            foreach (var team in teams)
            {
                var HomeGames = matches
                    .Where(fixture => fixture.HomeScore != null && fixture.Home.Id == team.Id)
                    .ToArray();
                var AwayGames = matches
                    .Where(fixture => fixture.AwayScore != null && fixture.Away.Id == team.Id)
                    .ToArray();
                var Games = HomeGames.Length + AwayGames.Length;
                var Win = HomeGames.Count(fixture => fixture.HomeScore > fixture.AwayScore) +
                    AwayGames.Count(fixture => fixture.AwayScore > fixture.HomeScore);
                var Draw = HomeGames.Count(fixture => fixture.HomeScore == fixture.AwayScore) +
                    AwayGames.Count(fixture => fixture.AwayScore == fixture.HomeScore);
                var Lost = HomeGames.Count(fixture => fixture.HomeScore < fixture.AwayScore) +
                    AwayGames.Count(fixture => fixture.AwayScore < fixture.HomeScore);
                var GoalsFor = HomeGames.Sum(fixture => fixture.HomeScore) +
                    AwayGames.Sum(fixture => fixture.AwayScore);
                var GoalsAgainst = HomeGames.Sum(fixture => fixture.AwayScore) +
                    AwayGames.Sum(fixture => fixture.HomeScore);
                var GoalDifference = GoalsFor - GoalsAgainst;
                var Points = (Win * PointsForWin) + (Draw * PointsForDraw) + (Lost * PointsForLoss);
                var club = (Club)team;
                var tournamentTable = new TournamentTable
                {
                    TeamName = team.Name,
                    Team = team,
                    Played = Games,
                    Won = Win,
                    Draw = Draw,
                    Lost = Lost,
                    GoalsFor = GoalsFor,
                    GoalsAgainst = GoalsAgainst,
                    GoalDifference = GoalDifference,
                    Points = Points,
                    Flag = team.Flag,
                    Country = club.Country
                };
                table.Add(tournamentTable);

            }
            return table;
        }
    }
}

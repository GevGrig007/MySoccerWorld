using Microsoft.EntityFrameworkCore.Migrations;

namespace MySoccerWorld.Migrations
{
    public partial class AWARDS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentAwards_CoachTeams_BestCoachId",
                table: "TournamentAwards");

            migrationBuilder.DropIndex(
                name: "IX_TournamentAwards_BestCoachId",
                table: "TournamentAwards");

            migrationBuilder.DropColumn(
                name: "BestCoachId",
                table: "TournamentAwards");

            migrationBuilder.AddColumn<int>(
                name: "CoachTeamId",
                table: "TournamentAwards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TournamentAwards_CoachTeamId",
                table: "TournamentAwards",
                column: "CoachTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentAwards_CoachTeams_CoachTeamId",
                table: "TournamentAwards",
                column: "CoachTeamId",
                principalTable: "CoachTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentAwards_CoachTeams_CoachTeamId",
                table: "TournamentAwards");

            migrationBuilder.DropIndex(
                name: "IX_TournamentAwards_CoachTeamId",
                table: "TournamentAwards");

            migrationBuilder.DropColumn(
                name: "CoachTeamId",
                table: "TournamentAwards");

            migrationBuilder.AddColumn<int>(
                name: "BestCoachId",
                table: "TournamentAwards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TournamentAwards_BestCoachId",
                table: "TournamentAwards",
                column: "BestCoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentAwards_CoachTeams_BestCoachId",
                table: "TournamentAwards",
                column: "BestCoachId",
                principalTable: "CoachTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

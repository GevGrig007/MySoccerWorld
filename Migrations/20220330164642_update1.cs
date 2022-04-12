using Microsoft.EntityFrameworkCore.Migrations;

namespace MySoccerWorld.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TournamentAwards_TournamentId",
                table: "TournamentAwards");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentAwards_TournamentId",
                table: "TournamentAwards",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TournamentAwards_TournamentId",
                table: "TournamentAwards");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentAwards_TournamentId",
                table: "TournamentAwards",
                column: "TournamentId",
                unique: true);
        }
    }
}

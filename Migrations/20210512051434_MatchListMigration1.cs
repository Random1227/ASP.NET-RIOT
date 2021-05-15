using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class MatchListMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<string>(type: "varchar(512)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchList", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchList");
        }
    }
}

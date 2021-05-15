using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class MatchDataAttempt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVersion = table.Column<string>(type: "varchar(512)", nullable: true),
                    MatchId = table.Column<string>(type: "varchar(512)", nullable: true),
                    GameCreation = table.Column<string>(type: "varchar(512)", nullable: false),
                    GameDuration = table.Column<string>(type: "varchar(512)", nullable: false),
                    GameId = table.Column<string>(type: "varchar(512)", nullable: false),
                    GameMode = table.Column<string>(type: "varchar(512)", nullable: true),
                    GameName = table.Column<string>(type: "varchar(512)", nullable: true),
                    GameStartTimeStamp = table.Column<string>(type: "varchar(512)", nullable: false),
                    GameType = table.Column<string>(type: "varchar(512)", nullable: true),
                    GameVersion = table.Column<string>(type: "varchar(512)", nullable: true),
                    MapId = table.Column<string>(type: "varchar(512)", nullable: false),
                    PlatformId = table.Column<string>(type: "varchar(512)", nullable: true),
                    QueueId = table.Column<string>(type: "varchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchInfo");
        }
    }
}

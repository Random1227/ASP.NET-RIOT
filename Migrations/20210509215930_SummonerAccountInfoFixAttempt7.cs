using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class SummonerAccountInfoFixAttempt7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summoner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Summoner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "varchar(512)", nullable: true),
                    FreshBlood = table.Column<string>(type: "varchar(512)", nullable: false),
                    HotStreak = table.Column<string>(type: "varchar(512)", nullable: false),
                    Inactive = table.Column<string>(type: "varchar(512)", nullable: false),
                    LeagueId = table.Column<string>(type: "varchar(512)", nullable: true),
                    LeaguePoints = table.Column<string>(type: "varchar(512)", nullable: false),
                    Losses = table.Column<string>(type: "varchar(512)", nullable: false),
                    ProfileIconId = table.Column<string>(type: "varchar(512)", nullable: false),
                    PuuId = table.Column<string>(type: "varchar(512)", nullable: true),
                    QueueType = table.Column<string>(type: "varchar(512)", nullable: true),
                    Rank = table.Column<string>(type: "varchar(512)", nullable: true),
                    RevisionDate = table.Column<string>(type: "varchar(512)", nullable: false),
                    SummonerId = table.Column<string>(type: "varchar(512)", nullable: true),
                    SummonerLevel = table.Column<string>(type: "varchar(512)", nullable: false),
                    SummonerName = table.Column<string>(type: "varchar(512)", nullable: true),
                    Tier = table.Column<string>(type: "varchar(512)", nullable: true),
                    Veteran = table.Column<string>(type: "varchar(512)", nullable: false),
                    Wins = table.Column<string>(type: "varchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoner", x => x.ID);
                });
        }
    }
}

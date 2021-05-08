using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Summoner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SummonerId = table.Column<string>(type: "varchar(64)", nullable: true),
                    AccountId = table.Column<string>(type: "varchar(64)", nullable: true),
                    PuuId = table.Column<string>(type: "varchar(64)", nullable: true),
                    SummonerName = table.Column<string>(type: "varchar(64)", nullable: true),
                    RevisionDate = table.Column<string>(type: "varchar(64)", nullable: false),
                    SummonerLevel = table.Column<string>(type: "varchar(64)", nullable: false),
                    LeagueId = table.Column<string>(type: "varchar(64)", nullable: true),
                    QueueType = table.Column<string>(type: "varchar(64)", nullable: true),
                    Tier = table.Column<string>(type: "varchar(64)", nullable: true),
                    Rank = table.Column<string>(type: "varchar(64)", nullable: true),
                    ProfileIconId = table.Column<string>(type: "varchar(64)", nullable: false),
                    LeaguePoints = table.Column<string>(type: "varchar(64)", nullable: false),
                    Wins = table.Column<string>(type: "varchar(64)", nullable: false),
                    Losses = table.Column<string>(type: "varchar(64)", nullable: false),
                    Veteran = table.Column<string>(type: "varchar(64)", nullable: false),
                    Inactive = table.Column<string>(type: "varchar(64)", nullable: false),
                    FreshBlood = table.Column<string>(type: "varchar(64)", nullable: false),
                    HotStreak = table.Column<string>(type: "varchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoner", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summoner");
        }
    }
}

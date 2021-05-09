using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class SummonerAccountInfoFixAttempt6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RankedInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SummonerAccountInfoID = table.Column<int>(type: "int", nullable: true),
                    LeagueId = table.Column<string>(type: "varchar(512)", nullable: true),
                    QueueType = table.Column<string>(type: "varchar(512)", nullable: true),
                    Tier = table.Column<string>(type: "varchar(512)", nullable: true),
                    Rank = table.Column<string>(type: "varchar(512)", nullable: true),
                    SummonerId = table.Column<string>(type: "varchar(512)", nullable: true),
                    SummonerName = table.Column<string>(type: "varchar(512)", nullable: true),
                    LeaguePoints = table.Column<string>(type: "varchar(512)", nullable: false),
                    Wins = table.Column<string>(type: "varchar(512)", nullable: false),
                    Losses = table.Column<string>(type: "varchar(512)", nullable: false),
                    Veteran = table.Column<string>(type: "varchar(512)", nullable: false),
                    Inactive = table.Column<string>(type: "varchar(512)", nullable: false),
                    FreshBlood = table.Column<string>(type: "varchar(512)", nullable: false),
                    HotStreak = table.Column<string>(type: "varchar(512)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankedInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RankedInfo_SummonerAccountInfo_SummonerAccountInfoID",
                        column: x => x.SummonerAccountInfoID,
                        principalTable: "SummonerAccountInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RankedInfo_SummonerAccountInfoID",
                table: "RankedInfo",
                column: "SummonerAccountInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RankedInfo");
        }
    }
}

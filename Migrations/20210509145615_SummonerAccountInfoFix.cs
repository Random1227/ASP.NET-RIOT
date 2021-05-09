using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class SummonerAccountInfoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SummonerAccountInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SummonerId = table.Column<string>(type: "varchar(512)", nullable: true),
                    AccountId = table.Column<string>(type: "varchar(512)", nullable: true),
                    PuuId = table.Column<string>(type: "varchar(512)", nullable: true),
                    SummonerName = table.Column<string>(type: "varchar(512)", nullable: true),
                    RevisionDate = table.Column<string>(type: "varchar(512)", nullable: false),
                    SummonerLevel = table.Column<string>(type: "varchar(512)", nullable: false),
                    ProfileIconId = table.Column<string>(type: "varchar(512)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonerAccountInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SummonerAccountInfo");
        }
    }
}

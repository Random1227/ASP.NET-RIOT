using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueMatchHistory.Migrations
{
    public partial class MatchInfoAttempt01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParticipantInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<string>(type: "varchar(512)", nullable: true),
                    teamId = table.Column<string>(type: "varchar(512)", nullable: false),
                    assists = table.Column<string>(type: "varchar(512)", nullable: false),
                    baronKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    bountyLevel = table.Column<string>(type: "varchar(512)", nullable: false),
                    champExperience = table.Column<string>(type: "varchar(512)", nullable: false),
                    champLevel = table.Column<string>(type: "varchar(512)", nullable: false),
                    championId = table.Column<string>(type: "varchar(512)", nullable: false),
                    championName = table.Column<string>(type: "varchar(512)", nullable: true),
                    championTransform = table.Column<string>(type: "varchar(512)", nullable: false),
                    consumablesPurchased = table.Column<string>(type: "varchar(512)", nullable: false),
                    damageDealtToBuildings = table.Column<string>(type: "varchar(512)", nullable: false),
                    damageDealtToObjectives = table.Column<string>(type: "varchar(512)", nullable: false),
                    damageDealtToTurrets = table.Column<string>(type: "varchar(512)", nullable: false),
                    damageSelfMitigated = table.Column<string>(type: "varchar(512)", nullable: false),
                    deaths = table.Column<string>(type: "varchar(512)", nullable: false),
                    detectorWardsPlaced = table.Column<string>(type: "varchar(512)", nullable: false),
                    doubleKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    dragonKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    firstBloodAssist = table.Column<string>(type: "varchar(512)", nullable: false),
                    firstBloodKill = table.Column<string>(type: "varchar(512)", nullable: false),
                    firstTowerAssist = table.Column<string>(type: "varchar(512)", nullable: false),
                    firstTowerKill = table.Column<string>(type: "varchar(512)", nullable: false),
                    gameEndedInEarlySurrender = table.Column<string>(type: "varchar(512)", nullable: false),
                    gameEndedInSurrender = table.Column<string>(type: "varchar(512)", nullable: false),
                    goldEarned = table.Column<string>(type: "varchar(512)", nullable: false),
                    goldSpent = table.Column<string>(type: "varchar(512)", nullable: false),
                    individualPosition = table.Column<string>(type: "varchar(512)", nullable: true),
                    inhibitorKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    inhibitorsLost = table.Column<string>(type: "varchar(512)", nullable: false),
                    item0 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item4 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item5 = table.Column<string>(type: "varchar(512)", nullable: false),
                    item6 = table.Column<string>(type: "varchar(512)", nullable: false),
                    itemsPurchased = table.Column<string>(type: "varchar(512)", nullable: false),
                    killingSprees = table.Column<string>(type: "varchar(512)", nullable: false),
                    kills = table.Column<string>(type: "varchar(512)", nullable: false),
                    lane = table.Column<string>(type: "varchar(512)", nullable: true),
                    largestCriticalStrike = table.Column<string>(type: "varchar(512)", nullable: false),
                    largestKillingSpree = table.Column<string>(type: "varchar(512)", nullable: false),
                    largestMultiKill = table.Column<string>(type: "varchar(512)", nullable: false),
                    longestTimeSpentLiving = table.Column<string>(type: "varchar(512)", nullable: false),
                    magicDamageDealt = table.Column<string>(type: "varchar(512)", nullable: false),
                    magicDamageDealtToChampions = table.Column<string>(type: "varchar(512)", nullable: false),
                    magicDamageTaken = table.Column<string>(type: "varchar(512)", nullable: false),
                    neutralMinionsKilled = table.Column<string>(type: "varchar(512)", nullable: false),
                    nexusKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    nexusLost = table.Column<string>(type: "varchar(512)", nullable: false),
                    objectivesStolen = table.Column<string>(type: "varchar(512)", nullable: false),
                    objectivesStolenAssists = table.Column<string>(type: "varchar(512)", nullable: false),
                    participantId = table.Column<string>(type: "varchar(512)", nullable: false),
                    pentaKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    StatPerks1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    StatPerks2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    StatPerks3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimaryStyle = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary0 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary0Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary0Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary0Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary1Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary1Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary1Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary2Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary2Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary2Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary3Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary3Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkPrimary3Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSecondayStyle = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday0 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday0Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday0Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday0Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday1Var1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday1Var2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    PerkSeconday1Var3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    physicalDamageDealt = table.Column<string>(type: "varchar(512)", nullable: false),
                    physicalDamageDealtToChampions = table.Column<string>(type: "varchar(512)", nullable: false),
                    physicalDamageTaken = table.Column<string>(type: "varchar(512)", nullable: false),
                    profileIcon = table.Column<string>(type: "varchar(512)", nullable: false),
                    puuid = table.Column<string>(type: "varchar(512)", nullable: true),
                    quadraKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    riotIdName = table.Column<string>(type: "varchar(512)", nullable: true),
                    riotIdTagline = table.Column<string>(type: "varchar(512)", nullable: true),
                    role = table.Column<string>(type: "varchar(512)", nullable: true),
                    sightwardsBoughtInGame = table.Column<string>(type: "varchar(512)", nullable: false),
                    spell1Casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    spell2Casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    spell3Casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    spell4casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    summoner1Casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    summoner1Id = table.Column<string>(type: "varchar(512)", nullable: false),
                    summoner2Casts = table.Column<string>(type: "varchar(512)", nullable: false),
                    summoner2Id = table.Column<string>(type: "varchar(512)", nullable: false),
                    summonerId = table.Column<string>(type: "varchar(512)", nullable: true),
                    summonerLevel = table.Column<string>(type: "varchar(512)", nullable: false),
                    summonerName = table.Column<string>(type: "varchar(512)", nullable: true),
                    teamEarlySurrendered = table.Column<string>(type: "varchar(512)", nullable: false),
                    teamPosition = table.Column<string>(type: "varchar(512)", nullable: true),
                    timeCCingOthers = table.Column<string>(type: "varchar(512)", nullable: false),
                    timePlayed = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalDamageDealt = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalDamageDealtToChampions = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalDamageShieldedOnTeammates = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalDamageTaken = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalHeal = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalHealsOnTeammates = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalMinionsKilled = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalTimeCCDealt = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalTimeSpentDead = table.Column<string>(type: "varchar(512)", nullable: false),
                    totalUnitsHealed = table.Column<string>(type: "varchar(512)", nullable: false),
                    tripleKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    trueDamageDealt = table.Column<string>(type: "varchar(512)", nullable: false),
                    trueDamageDealtToChampions = table.Column<string>(type: "varchar(512)", nullable: false),
                    trueDamageTaken = table.Column<string>(type: "varchar(512)", nullable: false),
                    turretKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    turretsLost = table.Column<string>(type: "varchar(512)", nullable: false),
                    unrealKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    visionScore = table.Column<string>(type: "varchar(512)", nullable: false),
                    visionWardsBoughtInGame = table.Column<string>(type: "varchar(512)", nullable: false),
                    wardsKilled = table.Column<string>(type: "varchar(512)", nullable: false),
                    wardsPlaced = table.Column<string>(type: "varchar(512)", nullable: false),
                    win = table.Column<string>(type: "varchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeamsInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<string>(type: "varchar(512)", nullable: true),
                    Ban0 = table.Column<string>(type: "varchar(512)", nullable: false),
                    Ban1 = table.Column<string>(type: "varchar(512)", nullable: false),
                    Ban2 = table.Column<string>(type: "varchar(512)", nullable: false),
                    Ban3 = table.Column<string>(type: "varchar(512)", nullable: false),
                    Ban4 = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstBaron = table.Column<string>(type: "varchar(512)", nullable: false),
                    BaronKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstBlood = table.Column<string>(type: "varchar(512)", nullable: false),
                    ChampionKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstDragon = table.Column<string>(type: "varchar(512)", nullable: false),
                    DragonKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstInhibitor = table.Column<string>(type: "varchar(512)", nullable: false),
                    InhibitorKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstRitHerald = table.Column<string>(type: "varchar(512)", nullable: false),
                    RiftHeraldKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    FirstTower = table.Column<string>(type: "varchar(512)", nullable: false),
                    TowerKills = table.Column<string>(type: "varchar(512)", nullable: false),
                    TeamId = table.Column<string>(type: "varchar(512)", nullable: false),
                    Win = table.Column<string>(type: "varchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipantInfo");

            migrationBuilder.DropTable(
                name: "TeamsInfo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class ParticipantInfo
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("MatchId")]
        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int teamId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int assists { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int baronKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int bountyLevel { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int champExperience { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int champLevel { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int championId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string championName { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int championTransform { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int consumablesPurchased { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int damageDealtToBuildings { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int damageDealtToObjectives { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int damageDealtToTurrets { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int damageSelfMitigated { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int deaths { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int detectorWardsPlaced { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int doubleKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int dragonKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool firstBloodAssist { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool firstBloodKill { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool firstTowerAssist { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool firstTowerKill { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool gameEndedInEarlySurrender { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool gameEndedInSurrender { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int goldEarned { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int goldSpent { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string individualPosition { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int inhibitorKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int inhibitorsLost { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item0 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item4 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item5 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int item6 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int itemsPurchased { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int killingSprees { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int kills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string lane { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int largestCriticalStrike { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int largestKillingSpree { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int largestMultiKill { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int longestTimeSpentLiving { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicDamageDealt { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicDamageDealtToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int neutralMinionsKilled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int nexusKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int nexusLost { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int objectivesStolen { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int objectivesStolenAssists { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int participantId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int pentaKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int StatPerks1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int StatPerks2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int StatPerks3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimaryStyle { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary0 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary0Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary0Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary0Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary1Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary1Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary1Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary2Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary2Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary2Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary3Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary3Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkPrimary3Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSecondayStyle { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday0 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday0Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday0Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday0Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday1Var1 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday1Var2 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int PerkSeconday1Var3 { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageDealt { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageDealtToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int profileIcon { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string puuid { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int quadraKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string riotIdName { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string riotIdTagline { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string role { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int sightwardsBoughtInGame { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int spell1Casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int spell2Casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int spell3Casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int spell4casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int summoner1Casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int summoner1Id { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int summoner2Casts { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int summoner2Id { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string summonerId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int summonerLevel { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string summonerName { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool teamEarlySurrendered { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string teamPosition { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int timeCCingOthers { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int timePlayed { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageDealt { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageDealtToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageShieldedOnTeammates { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalHeal { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalHealsOnTeammates { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalMinionsKilled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalTimeCCDealt { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalTimeSpentDead { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalUnitsHealed { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int tripleKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageDealt { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageDealtToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int turretKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int turretsLost { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int unrealKills { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int visionScore { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int visionWardsBoughtInGame { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int wardsKilled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int wardsPlaced { get; set; }
        [Column(TypeName = "varchar(512)")]
        public bool win { get; set; }
    }
}

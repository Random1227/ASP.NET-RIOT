using LeagueMatchHistory.JsonClasses;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO;
using LeagueMatchHistory.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Methods
{
    public class apiCalls
    {
        public string apikey { get; set; }

        public string MatchURL { get; set; }
        public string TimelineURL { get; set; }
        public string MatchListURL { get; set; }
        public string SummonerInfoURL { get; set; }
        public string RankedInfoURL { get; set; }
        public string ChampionMasteryAllURL { get; set; }
        public string ChampionMasterySingleURL { get; set; }
        public string ChampionMasteryTotalURL { get; set; }
        public string CurrentGameURL { get; set; }
        public string FeaturedGameURL { get; set; }
        public string Extra1 { get; set;}
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }


        public WebClient wc { get; set; }

        //var RankInfoJson = JsonConvert.DeserializeObject<List<JsonClasses.LeagueEntryDTO>>("si");


        public apiCalls()
        {
            apikey = "RGAPI-6fed8787-37ea-4f3b-8ba2-9f94199b8bb3";

            //Match API Base URLs
            MatchURL = "https://americas.api.riotgames.com/lol/match/v5/matches/";
            TimelineURL = "https://americas.api.riotgames.com/lol/match/v5/matches/";
            MatchListURL = "https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/";

            //Summoner Base URLs
            SummonerInfoURL = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/";
            RankedInfoURL = "https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/";

            //Spectate Base URLs
            CurrentGameURL = "https://na1.api.riotgames.com/lol/spectator/v4/active-games/by-summoner/";
            FeaturedGameURL = "https://na1.api.riotgames.com/lol/spectator/v4/featured-games?api_key=";

            //Mastery Base URLs
            ChampionMasteryAllURL = "https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/";
            ChampionMasterySingleURL = "https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/";
            ChampionMasteryTotalURL = "https://na1.api.riotgames.com/lol/champion-mastery/v4/scores/by-summoner/";

            //Extra Parts
            Extra1 = "?api_key=";
            Extra2 = "/by-champion/";
            Extra3 = "/ids?start=";
            Extra4 = "/timeline?api_key=";
            Extra5 = "&count=";

            wc = new WebClient();

        }

        public SummonerDTO GetSummonerDTO(string SummonerName)
        {
            string url = SummonerInfoURL + SummonerName + Extra1 + apikey;

            string SummonerInfo = wc.DownloadString(url);

            var SummonerInfoJson = JsonConvert.DeserializeObject<JsonClasses.SummonerDTO>(SummonerInfo);

            return SummonerInfoJson;

        }

        public List<LeagueEntryDTO> GetListOfLeagueEntryDTO(string PUUId)
        {
            string url = RankedInfoURL + PUUId + Extra1 + apikey;

            string RankedInfo = wc.DownloadString(url);

            var RankedInfoJson = JsonConvert.DeserializeObject<List<JsonClasses.LeagueEntryDTO>>(RankedInfo);

            return RankedInfoJson;
        }

        public MatchDTO GetMatchDTO(string MatchId)
        {
            string url = MatchURL + MatchId + Extra1 + apikey;

            string MatchInfo = wc.DownloadString(url);

            var MatchInfoJson = JsonConvert.DeserializeObject<JsonClasses.JsonClassesMatchDTO.MatchDTO>(MatchInfo);

            return MatchInfoJson;
        }

        public MatchTimelineDTO GetMatchTimelineDTO(string MatchId)
        {
            string url = TimelineURL + MatchId + Extra4 + apikey;

            string TimelineInfo = wc.DownloadString(url);

            var TimelineInfoJson = JsonConvert.DeserializeObject<JsonClasses.JsonClassesMatchTimelineDTO.MatchTimelineDTO>(TimelineInfo);

            return TimelineInfoJson;
        }

        public List<string> GetMatchListDTO(string PUUId)
        {
            int start = 0;
            int stop = 100;

            string url = MatchListURL + PUUId + Extra3 + start + Extra5 + stop + Extra1 + "RGAPI-fd3e0dcb-dbd0-4fcc-8e6e-889d7d5a0114";

            string MatchListInfo = wc.DownloadString(url);

            var MatchListInfoJson = JsonConvert.DeserializeObject<List<string>>(MatchListInfo);

            return MatchListInfoJson;
        }

        //methods to fill out the various DB objects
        //these will be what is called in the cshtml.cs pages, then the API calls and adding it to the DB will be done in here? maybe? or I just return the objects,

        public Models.SummonerAccountInfo GetSummoner(Models.SummonerAccountInfo SumInfo)
        {
            //will always at least send in an object with a summonername
            var SumAccInfo = GetSummonerDTO(SumInfo.SummonerName);
            //fill this bad boy out
            SumInfo.AccountId = SumAccInfo.accountId;
            SumInfo.LastUpdated = DateTime.Now;
            SumInfo.ProfileIconId = SumAccInfo.profileIconId;
            SumInfo.PuuId = SumAccInfo.puuid;
            SumInfo.RevisionDate = SumAccInfo.revisionDate;
            SumInfo.SummonerId = SumAccInfo.id;
            SumInfo.SummonerLevel = SumAccInfo.summonerLevel;
            if(SumInfo.RecordCreated == DateTime.MinValue)
            {
                SumInfo.RecordCreated = DateTime.Now;
            }
            
            return SumInfo;
        }



        public List<Models.RankedInfo> GetRankedInformation(string puuid)
        {
            var RankedInfo = GetListOfLeagueEntryDTO(puuid);

            var RankedList = new List<Models.RankedInfo>();

            foreach(var entry in RankedInfo)
            {
                var rankedInfo = new RankedInfo();
                rankedInfo.FreshBlood = entry.freshBlood;
                rankedInfo.HotStreak = entry.hotStreak;
                rankedInfo.Inactive = entry.inactive;
                rankedInfo.LastUpdated = DateTime.Now;
                rankedInfo.LeagueId = entry.leagueId;
                rankedInfo.LeaguePoints = entry.leaguePoints;
                rankedInfo.Losses = entry.losses;
                rankedInfo.QueueType = entry.queueType;
                rankedInfo.Rank = entry.rank;
                rankedInfo.SummonerId = entry.summonerId;
                rankedInfo.SummonerName = entry.summonerName;
                rankedInfo.Tier = entry.tier;
                rankedInfo.Veteran = entry.veteran;
                rankedInfo.Wins = entry.wins;

                RankedList.Add(rankedInfo);
            }

            return RankedList;
        }

        public OtherClasses.CombinationMatchInfo GetMatchInformation(string MatchId)//from matchId, get teams + participants
        {
            var MatchEntryJson = GetMatchDTO(MatchId);
            var matchInfo = new Models.MatchInfo();
            var CombinedBoy = new OtherClasses.CombinationMatchInfo();

            matchInfo.DataVersion = MatchEntryJson.metadata.dataVersion;
            matchInfo.GameCreation = MatchEntryJson.info.gameCreation;
            matchInfo.GameDuration = MatchEntryJson.info.gameDuration;
            matchInfo.GameId = MatchEntryJson.info.gameId;
            matchInfo.GameMode = MatchEntryJson.info.gameMode;
            matchInfo.GameName = MatchEntryJson.info.gameName;
            matchInfo.GameStartTimeStamp = MatchEntryJson.info.gameStartTimeStamp;
            matchInfo.GameType = MatchEntryJson.info.gameType;
            matchInfo.GameVersion = MatchEntryJson.info.gameVersion;
            matchInfo.MapId = MatchEntryJson.info.mapId;
            matchInfo.MatchId = MatchEntryJson.metadata.matchId;
            matchInfo.PlatformId = MatchEntryJson.info.platformId;
            matchInfo.QueueId = MatchEntryJson.info.queueId;

            var TeamInfo = GetMatchTeams(MatchEntryJson);
            var ParticipantInfo = GetMatchParticipants(MatchEntryJson);

            CombinedBoy.MatchInfo = matchInfo;
            CombinedBoy.ParticipantInfo = ParticipantInfo;
            CombinedBoy.TeamsInfo = TeamInfo;

            return CombinedBoy;
            
        }

        public List<Models.TeamsInfo> GetMatchTeams(JsonClasses.JsonClassesMatchDTO.MatchDTO MatchInfo)
        {

            List<Models.TeamsInfo> TeamList = new List<Models.TeamsInfo>();


            foreach (var team in MatchInfo.info.teams)
            {
                var TeamInfo = new Models.TeamsInfo();
                TeamInfo.Ban0 = team.bans[0].championId;
                TeamInfo.Ban1 = team.bans[1].championId;
                TeamInfo.Ban2 = team.bans[2].championId;
                TeamInfo.Ban3 = team.bans[3].championId;
                TeamInfo.Ban4 = team.bans[4].championId;
                TeamInfo.BaronKills = team.objectives.baron.kills;
                TeamInfo.ChampionKills = team.objectives.champion.kills;
                TeamInfo.DragonKills = team.objectives.dragon.kills;
                TeamInfo.FirstBaron = team.objectives.baron.first;
                TeamInfo.FirstBlood = team.objectives.champion.first;
                TeamInfo.FirstDragon = team.objectives.dragon.first;
                TeamInfo.FirstInhibitor = team.objectives.inhibitor.first;
                TeamInfo.FirstRitHerald = team.objectives.riftHerald.first;
                TeamInfo.FirstTower = team.objectives.tower.first;
                TeamInfo.InhibitorKills = team.objectives.inhibitor.kills;
                TeamInfo.MatchId = MatchInfo.metadata.matchId;
                TeamInfo.RiftHeraldKills = team.objectives.riftHerald.kills;
                TeamInfo.TeamId = team.teamId;
                TeamInfo.TowerKills = team.objectives.tower.kills;
                TeamInfo.Win = team.win;

                TeamList.Add(TeamInfo);
            }

            return TeamList;
        }

        public List<Models.ParticipantInfo> GetMatchParticipants(JsonClasses.JsonClassesMatchDTO.MatchDTO MatchInfo)
        {
            List<Models.ParticipantInfo> ParticipantList = new List<Models.ParticipantInfo>();

            foreach(var item in MatchInfo.info.participants)
            {
                ParticipantInfo participantInfo = new ParticipantInfo();
                participantInfo.assists = item.assists;
                participantInfo.baronKills = item.baronKills;
                participantInfo.bountyLevel = item.bountyLevel;
                participantInfo.champExperience = item.champExperience;
                participantInfo.championId = item.championId;
                participantInfo.championName = item.championName;
                participantInfo.championTransform = item.championTransform;
                participantInfo.champLevel = item.champLevel;
                participantInfo.consumablesPurchased = item.consumablesPurchased;
                participantInfo.damageDealtToBuildings = item.damageDealtToBuildings;
                participantInfo.damageDealtToObjectives = item.damageDealtToObjectives;
                participantInfo.damageDealtToTurrets = item.damageDealtToTurrets;
                participantInfo.damageSelfMitigated = item.damageSelfMitigated;
                participantInfo.deaths = item.deaths;
                participantInfo.detectorWardsPlaced = item.detectorWardsPlaced;
                participantInfo.doubleKills = item.doubleKills;
                participantInfo.dragonKills = item.dragonKills;
                participantInfo.firstBloodAssist = item.firstBloodAssist;
                participantInfo.firstBloodKill = item.firstBloodKill;
                participantInfo.firstTowerAssist = item.firstTowerAssist;
                participantInfo.firstTowerKill = item.firstTowerKill;
                participantInfo.gameEndedInEarlySurrender = item.gameEndedInEarlySurrender;
                participantInfo.gameEndedInSurrender = item.gameEndedInSurrender;
                participantInfo.goldEarned = item.goldEarned;
                participantInfo.goldSpent = item.goldSpent;
                participantInfo.individualPosition = item.individualPosition;
                participantInfo.inhibitorKills = item.inhibitorKills;
                participantInfo.inhibitorsLost = item.inhibitorsLost;
                participantInfo.item0 = item.item0;
                participantInfo.item1 = item.item1;
                participantInfo.item2 = item.item2;
                participantInfo.item3 = item.item3;
                participantInfo.item4 = item.item4;
                participantInfo.item5 = item.item5;
                participantInfo.item6 = item.item6;
                participantInfo.itemsPurchased = item.itemsPurchased;
                participantInfo.killingSprees = item.killingSprees;
                participantInfo.kills = item.kills;
                participantInfo.lane = item.lane;
                participantInfo.largestCriticalStrike = item.largestCriticalStrike;
                participantInfo.largestKillingSpree = item.largestKillingSpree;
                participantInfo.largestMultiKill = item.largestMultiKill;
                participantInfo.longestTimeSpentLiving = item.longestTimeSpentLiving;
                participantInfo.magicDamageDealt = item.magicDamageDealt;
                participantInfo.magicDamageDealtToChampions = item.magicDamageDealtToChampions;
                participantInfo.magicDamageTaken = item.magicDamageTaken;
                participantInfo.MatchId = MatchInfo.metadata.matchId;
                participantInfo.neutralMinionsKilled = item.neutralMinionsKilled;
                participantInfo.nexusKills = item.nexusKills;
                participantInfo.nexusLost = item.nexusLost;
                participantInfo.objectivesStolen = item.objectivesStolen;
                participantInfo.objectivesStolenAssists = item.objectivesStolenAssists;
                participantInfo.participantId = item.participantId;
                participantInfo.pentaKills = item.pentaKills;
                //primary perk tree block
                participantInfo.PerkPrimary0 = item.perks.styles[0].selections[0].perk;
                participantInfo.PerkPrimary0Var1 = item.perks.styles[0].selections[0].var1;
                participantInfo.PerkPrimary0Var2 = item.perks.styles[0].selections[0].var2;
                participantInfo.PerkPrimary0Var3 = item.perks.styles[0].selections[0].var3;
                participantInfo.PerkPrimary1 = item.perks.styles[0].selections[1].perk;
                participantInfo.PerkPrimary1Var1 = item.perks.styles[0].selections[1].var1;
                participantInfo.PerkPrimary1Var2 = item.perks.styles[0].selections[1].var2;
                participantInfo.PerkPrimary1Var3 = item.perks.styles[0].selections[1].var3;
                participantInfo.PerkPrimary2 = item.perks.styles[0].selections[2].perk;
                participantInfo.PerkPrimary2Var1 = item.perks.styles[0].selections[2].var1;
                participantInfo.PerkPrimary2Var2 = item.perks.styles[0].selections[2].var2;
                participantInfo.PerkPrimary2Var3 = item.perks.styles[0].selections[2].var3;
                participantInfo.PerkPrimary3 = item.perks.styles[0].selections[3].perk;
                participantInfo.PerkPrimary3Var1 = item.perks.styles[0].selections[3].var1;
                participantInfo.PerkPrimary3Var2 = item.perks.styles[0].selections[3].var2;
                participantInfo.PerkPrimary3Var3 = item.perks.styles[0].selections[3].var3;
                participantInfo.PerkPrimaryStyle = item.perks.styles[0].style;
                //seconday perk tree block
                participantInfo.PerkSeconday0 = item.perks.styles[1].selections[0].perk;
                participantInfo.PerkSeconday0Var1 = item.perks.styles[1].selections[0].var1;
                participantInfo.PerkSeconday0Var2 = item.perks.styles[1].selections[0].var2;
                participantInfo.PerkSeconday0Var3 = item.perks.styles[1].selections[0].var3;
                participantInfo.PerkSeconday1 = item.perks.styles[1].selections[1].perk;
                participantInfo.PerkSeconday1Var1 = item.perks.styles[1].selections[1].var1;
                participantInfo.PerkSeconday1Var2 = item.perks.styles[1].selections[1].var2;
                participantInfo.PerkSeconday1Var3 = item.perks.styles[1].selections[1].var3;
                participantInfo.PerkSecondayStyle = item.perks.styles[1].style;

                participantInfo.physicalDamageDealt = item.physicalDamageDealt;
                participantInfo.physicalDamageDealtToChampions = item.physicalDamageDealtToChampions;
                participantInfo.physicalDamageTaken = item.physicalDamageTaken;
                participantInfo.profileIcon = item.profileIcon;
                participantInfo.puuid = item.puuid;
                participantInfo.quadraKills = item.quadraKills;
                participantInfo.riotIdName = item.riotIdName;
                participantInfo.riotIdTagline = item.riotIdTagline;
                participantInfo.role = item.role;
                participantInfo.sightwardsBoughtInGame = item.sightwardsBoughtInGame;
                participantInfo.spell1Casts = item.spell1Casts;
                participantInfo.spell2Casts = item.spell2Casts;
                participantInfo.spell3Casts = item.spell3Casts;
                participantInfo.spell4casts = item.spell4casts;
                participantInfo.StatPerks1 = item.perks.statPerks.defense;
                participantInfo.StatPerks2 = item.perks.statPerks.flex;
                participantInfo.StatPerks3 = item.perks.statPerks.offence;
                participantInfo.summoner1Casts = item.summoner1Casts;
                participantInfo.summoner1Id = item.summoner1Id;
                participantInfo.summoner2Casts = item.summoner2Casts;
                participantInfo.summoner2Id = item.summoner2Id;
                participantInfo.summonerId = item.summonerId;
                participantInfo.summonerLevel = item.summonerLevel;
                participantInfo.summonerName = item.summonerName;
                participantInfo.teamEarlySurrendered = item.teamEarlySurrendered;
                participantInfo.teamId = item.teamId;
                participantInfo.teamPosition = item.teamPosition;
                participantInfo.timeCCingOthers = item.timeCCingOthers;
                participantInfo.timePlayed = item.timePlayed;
                participantInfo.totalDamageDealt = item.totalDamageDealt;
                participantInfo.totalDamageDealtToChampions = item.totalDamageDealtToChampions;
                participantInfo.totalDamageShieldedOnTeammates = item.totalDamageShieldedOnTeammates;
                participantInfo.totalDamageTaken = item.totalDamageTaken;
                participantInfo.totalHeal = item.totalHeal;
                participantInfo.totalHealsOnTeammates = item.totalHealsOnTeammates;
                participantInfo.totalMinionsKilled = item.totalMinionsKilled;
                participantInfo.totalTimeCCDealt = item.totalTimeCCDealt;
                participantInfo.totalTimeSpentDead = item.totalTimeSpentDead;
                participantInfo.totalUnitsHealed = item.totalUnitsHealed;
                participantInfo.tripleKills = item.tripleKills;
                participantInfo.trueDamageDealt = item.trueDamageDealt;
                participantInfo.trueDamageDealtToChampions = item.trueDamageDealtToChampions;
                participantInfo.trueDamageTaken = item.trueDamageTaken;
                participantInfo.turretKills = item.turretKills;
                participantInfo.turretsLost = item.turretsLost;
                participantInfo.unrealKills = item.unrealKills;
                participantInfo.visionScore = item.visionScore;
                participantInfo.visionWardsBoughtInGame = item.visionWardsBoughtInGame;
                participantInfo.wardsKilled = item.wardsKilled;
                participantInfo.wardsPlaced = item.wardsPlaced;
                participantInfo.win = item.win;

                ParticipantList.Add(participantInfo);

            }

            return ParticipantList;
        }
    }
}

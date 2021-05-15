using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;
using System.Net;
using Newtonsoft.Json;

namespace LeagueMatchHistory.Pages.Matches
{
    public class CreateMatchModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public CreateMatchModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MatchInfo MatchInfo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //i am not ready for this
            //this will call to the API - get the match
            //break it down into MatchInfo, TeamsInfo, and ParticipantInfo

            string api_key = "RGAPI-0a5b3618-d02c-48b9-b341-f109f0cf4680";

            string match_id = "NA1_3896687948";

            string MATCHV5MATCHBYMATCHID = "https://americas.api.riotgames.com/lol/match/v5/matches/" + match_id + "?api_key=" + api_key;

            WebClient webContent = new WebClient();

            //gets the person's ranked info (as a string)
            var MatchEntry = webContent.DownloadString(MATCHV5MATCHBYMATCHID);

            //this is a temporary workaround
            //the RankedInfo returns a list of ranked info from the different queues (I think just flex 5v5 and solo/duo)
            //for now i literally just rip off the brackets and act like only solo/duo exists
            //RankedInfoString = RankedInfoString.Trim('[', ']');


            //I need to create a new class that matches the Json from Riot, and replace Summoner

            //turns their rankedinfo in JSON
            var MatchEntryJson = JsonConvert.DeserializeObject<JsonClasses.JsonClassesMatchDTO.MatchDTO>(MatchEntry);

            //Filling up the matchInfo database table with information from MatchEntryJson
            MatchInfo matchInfo = new MatchInfo();
            //holy shit this will be painful
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

            _context.MatchInfo.Add(matchInfo);

            //Filling up teams tables - this will create two database rows per game - one per team per match - connected with matchId


            foreach(var item in MatchEntryJson.info.teams)//list of the two teams
            {
                TeamsInfo teamsInfo = new TeamsInfo();
                teamsInfo.Ban0 = item.bans[0].championId;
                teamsInfo.Ban1 = item.bans[1].championId;
                teamsInfo.Ban2 = item.bans[2].championId;
                teamsInfo.Ban3 = item.bans[3].championId;
                teamsInfo.Ban4 = item.bans[4].championId;

                teamsInfo.FirstBaron = item.objectives.baron.first;
                teamsInfo.BaronKills = item.objectives.baron.kills;

                teamsInfo.FirstBlood = item.objectives.champion.first;
                teamsInfo.ChampionKills = item.objectives.champion.kills;

                teamsInfo.FirstDragon = item.objectives.dragon.first;
                teamsInfo.DragonKills = item.objectives.dragon.kills;

                teamsInfo.FirstInhibitor = item.objectives.inhibitor.first;
                teamsInfo.InhibitorKills = item.objectives.inhibitor.kills;

                teamsInfo.FirstRitHerald = item.objectives.riftHerald.first;
                teamsInfo.RiftHeraldKills = item.objectives.riftHerald.kills;

                teamsInfo.FirstTower = item.objectives.tower.first;
                teamsInfo.TowerKills = item.objectives.tower.kills;


                teamsInfo.MatchId = MatchEntryJson.metadata.matchId;

                teamsInfo.TeamId = item.teamId;

                teamsInfo.Win = item.win;

                _context.TeamsInfo.Add(teamsInfo);

                
                
            }

            //Filling up Participants table
            //Each game will have 10 participants entries in the database - will be connected with the matchId
            foreach(var item in MatchEntryJson.info.participants)
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
                participantInfo.MatchId = MatchEntryJson.metadata.matchId;
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

                _context.ParticipantInfo.Add(participantInfo);

            }








            if (!ModelState.IsValid)
            {
                return Page();
            }


            await _context.SaveChangesAsync();

            return RedirectToPage("/ParticipantInfos/Index");
        }
    }
}

using LeagueMatchHistory.JsonClasses;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO;

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

        public WebClient wc { get; set; }

        //var RankInfoJson = JsonConvert.DeserializeObject<List<JsonClasses.LeagueEntryDTO>>("si");


        public apiCalls()
        {
            apikey = "?api_key=RGAPI-fd3e0dcb-dbd0-4fcc-8e6e-889d7d5a0114";
            MatchURL = "https://americas.api.riotgames.com/lol/match/v5/matches/";
            TimelineURL = "https://americas.api.riotgames.com/lol/match/v5/matches/";
            MatchListURL = "https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/";
            SummonerInfoURL = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/";
            RankedInfoURL = "https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/";

            wc = new WebClient();



        }

        public SummonerDTO GetSummonerDTO(string SummonerName)
        {
            string url = SummonerInfoURL + SummonerName + apikey;

            string SummonerInfo = wc.DownloadString(url);

            var SummonerInfoJson = JsonConvert.DeserializeObject<JsonClasses.SummonerDTO>(SummonerInfo);

            return SummonerInfoJson;

        }

        public ListOfLeagueEntry GetListOfLeagueEntryDTO(string PUUId)
        {
            string url = RankedInfoURL + PUUId + apikey;

            string RankedInfo = wc.DownloadString(url);

            var RankedInfoJson = JsonConvert.DeserializeObject<JsonClasses.ListOfLeagueEntry>(RankedInfo);

            return RankedInfoJson;
        }

        public MatchDTO GetMatchDTO(string MatchId)
        {
            string url = MatchURL + MatchId + apikey;

            string MatchInfo = wc.DownloadString(url);

            var MatchInfoJson = JsonConvert.DeserializeObject<JsonClasses.JsonClassesMatchDTO.MatchDTO>(MatchInfo);

            return MatchInfoJson;
        }

        public MatchTimelineDTO GetMatchTimelineDTO(string MatchId)
        {
            string url = TimelineURL + MatchId + "/timeline" + apikey;

            string TimelineInfo = wc.DownloadString(url);

            var TimelineInfoJson = JsonConvert.DeserializeObject<JsonClasses.JsonClassesMatchTimelineDTO.MatchTimelineDTO>(TimelineInfo);

            return TimelineInfoJson;
        }

        public List<string> GetMatchListDTO(string PUUId)
        {
            int start = 0;
            int stop = 100;

            string url = MatchListURL + PUUId + "/ids?start=" + start + "&count=" + stop + "&api_key=RGAPI-fd3e0dcb-dbd0-4fcc-8e6e-889d7d5a0114";

            string MatchListInfo = wc.DownloadString(url);

            var MatchListInfoJson = JsonConvert.DeserializeObject<List<string>>(MatchListInfo);

            return MatchListInfoJson;
        }
    }
}

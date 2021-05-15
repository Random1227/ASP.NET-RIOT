using LeagueMatchHistory.JsonClasses;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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


        var RankInfoJson = JsonConvert.DeserializeObject<List<JsonClasses.LeagueEntryDTO>>("si");


        public apiCalls()
        {
            apikey = "";
        }
    }

    public SummonerDTO GetSummonerDTO(string SummonerName)
    {



    }

    public ListOfLeagueEntry GetListOfLeagueEntryDTO()
    {

    }

    public MatchDTO GetMatchDTO(string MatchId)
    {

    }

    public MatchTimelineDTO GetMatchTimelineDTO(string MatchId)
    {

    }

    public List<string> GetMatchListDTO(string PUUId)
    {

    }

}

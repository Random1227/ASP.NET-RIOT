using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO
{
    public class info
    {
        public long gameCreation { get; set; }
        public int gameDuration { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long gameStartTimeStamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public List<participants> participants { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public List<teams> teams { get; set; }
    }
}

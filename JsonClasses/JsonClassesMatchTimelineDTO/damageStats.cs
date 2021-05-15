using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class damageStats
    {
        public int magicDamageDone { get; set; }
        public int magicDamageDoneToChampions { get; set; }
        public int magicDamageTaken { get; set; }
        public int physicalDamageDone { get; set; }
        public int physicalDamageDoneToChampions { get; set; }
        public int physicalDamageTaken { get; set; }
        public int totalDamageDone { get; set; }
        public int totalDamageDoneToChampions { get; set; }
        public int totalDamageTaken { get; set; }
        public int trueDamageDone { get; set; }
        public int trueDamageDoneToChampions { get; set; }
        public int trueDamageTaken { get; set; }
    }
}

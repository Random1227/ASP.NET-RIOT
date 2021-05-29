using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class participantFrames
    {
        public championStats championStats { get; set; }
        public int currentGold { get; set; }
        public damageStats damageStats { get; set; }
        public int goldPerSecond { get; set; }
        public int jungleMinionsKilled { get; set; }
        public int level { get; set; }
        public int minionsKilled { get; set; }
        public int participantId { get; set; }
        public position position { get; set; }
        public int timeEnemySpentControlled { get; set; }
        public int totalGold { get; set; }
        public int xp { get; set; }
    }
}

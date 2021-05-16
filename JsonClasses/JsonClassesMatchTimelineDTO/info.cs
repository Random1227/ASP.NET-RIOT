using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class info
    {
        public int frameInterval { get; set; }
        public List<frames> frames { get; set; }
        public int gameId { get; set; }
        public List<participants> participants { get; set; }

    }
}

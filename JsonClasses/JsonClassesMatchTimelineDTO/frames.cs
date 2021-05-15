using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class frames
    {
        public List<events> events { get; set; }
        public List<participantFrames> participantFrames { get; set; }
        public int timestamp { get; set; }
    }
}

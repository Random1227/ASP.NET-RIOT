using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.OtherClasses
{
    public class CombinationMatchInfo
    {
        public Models.MatchInfo MatchInfo { get; set; }
        public List<Models.ParticipantInfo> ParticipantInfo { get; set; }
        public List<Models.TeamsInfo> TeamsInfo { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO
{
    public class MatchDTO
    {
        public metadata metadata { get; set; }
        public info info { get; set; }
    }
}

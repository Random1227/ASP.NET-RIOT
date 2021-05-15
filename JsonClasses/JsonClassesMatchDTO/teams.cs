using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO
{
    public class teams
    {
        
        public List<bans> bans { get; set; }

        public objectives objectives { get; set; }

        public int teamId { get; set; }

        public bool win { get; set; }
}
}

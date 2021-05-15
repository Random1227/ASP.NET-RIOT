using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO
{
    public class styles
    {
        public string description { get; set; }
        public List<selections> selections { get; set; }
        public int style { get; set; }
    }
}

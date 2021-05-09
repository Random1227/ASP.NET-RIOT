using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses
{
    public class ListOfLeagueEntry
    {
        public IList<LeagueEntryDTO> ListOfLeagueEntryDTOs { get; set; }
    }
}

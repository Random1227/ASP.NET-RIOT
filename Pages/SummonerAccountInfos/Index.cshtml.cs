using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.SummonerAccountInfos
{
    public class IndexModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public IndexModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public IList<SummonerAccountInfo> SummonerAccountInfo { get;set; }

        public IList<RankedInfo> RankedInfo { get; set; }
        public async Task OnGetAsync()
        {
            SummonerAccountInfo = await _context.SummonerAccountInfo.ToListAsync();

            RankedInfo = await _context.RankedInfo.ToListAsync();
        }
    }
}

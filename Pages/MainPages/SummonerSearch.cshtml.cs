using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;
using System.Net;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace LeagueMatchHistory.Pages.MainPages
{
    public class SummonerSearchModel : PageModel
    {

        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public SummonerSearchModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<SummonerAccountInfo> AllSummonerInfo { get; set; }

        [BindProperty]
        public IList<RankedInfo> AllRankedInfo { get; set; }

        [BindProperty]
        public SummonerAccountInfo SummonerInfo { get; set; }

        [BindProperty]
        public IList<RankedInfo> RankedInfo { get; set; }

        public string SummonerName { get; set; }


        public async Task OnGetAsync()
        {
            AllSummonerInfo = await _context.SummonerAccountInfo.ToListAsync();

            AllRankedInfo = await _context.RankedInfo.ToListAsync();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            
            SummonerInfo = await _context.SummonerAccountInfo.FirstOrDefaultAsync(m => m.SummonerName == SummonerName);
            if(SummonerName == null)
            {
                return RedirectToPage();
            }
            foreach(var item in AllRankedInfo)
            {
                if(item.SummonerName == SummonerName)
                {
                    RankedInfo.Add(item);
                }
            }





            return RedirectToPage();
        }

    }
}

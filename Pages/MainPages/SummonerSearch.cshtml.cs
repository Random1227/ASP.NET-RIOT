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
        public SummonerAccountInfo SummonerAccountInfo { get; set; }

        [BindProperty]
        public IList<RankedInfo> RankedInfo { get; set; }
        [BindProperty]
        public string SummonerName { get; set; }


        public async Task OnGetAsync()
        {
            AllSummonerInfo = await _context.SummonerAccountInfo.ToListAsync();

            AllRankedInfo = await _context.RankedInfo.ToListAsync();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            bool SummonerExists = false;
            if(SummonerName == null)
            {
                return RedirectToPage();
            }

            AllSummonerInfo = await _context.SummonerAccountInfo.ToListAsync();

            AllRankedInfo = await _context.RankedInfo.ToListAsync();

            foreach (var sum in AllSummonerInfo)
            {
                if(sum.SummonerName == SummonerName)
                {
                    SummonerExists = true;
                    SummonerAccountInfo = await _context.SummonerAccountInfo.FirstOrDefaultAsync(m => m.SummonerName == SummonerName);
                    _context.Attach(SummonerAccountInfo).State = EntityState.Modified;
                }
                else
                {
                    SummonerExists = false;
                }
            }

            Methods.apiCalls api = new Methods.apiCalls();

            var SumInfo = api.GetSummoner(SummonerAccountInfo);
            var RankInfo = api.GetRankedInformation(SumInfo.SummonerId);


            foreach(var item in RankInfo)
            {
                if(_context.RankedInfo.Any(e =>e.SummonerId == item.SummonerId && _context.RankedInfo.Any(e => e.QueueType == item.QueueType)))
                {
                    _context.Attach(item).State = EntityState.Modified;
                }
                else
                {
                    _context.RankedInfo.Add(item);
                }
            }




            if (!SummonerExists)
            {
                SumInfo.RecordCreated = DateTime.Now;
                _context.SummonerAccountInfo.Add(SumInfo);
            }
            else
            {
                _context.Attach(SumInfo).State = EntityState.Modified;
            }
            
            await _context.SaveChangesAsync();
            return Redirect("/SummonerAccountInfos/Index");
        }

    }
}

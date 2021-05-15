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
    public class DeleteModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public DeleteModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SummonerAccountInfo SummonerAccountInfo { get; set; }

        public IList<RankedInfo> RankedInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SummonerAccountInfo = await _context.SummonerAccountInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (SummonerAccountInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SummonerAccountInfo = await _context.SummonerAccountInfo.FindAsync(id);

            RankedInfo = await _context.RankedInfo.ToListAsync();



            foreach(var item in RankedInfo)
            {
                if(item.SummonerId == SummonerAccountInfo.SummonerId)
                {
                    _context.RankedInfo.Remove(item);
                }
            }


            if (SummonerAccountInfo != null)
            {
                _context.SummonerAccountInfo.Remove(SummonerAccountInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

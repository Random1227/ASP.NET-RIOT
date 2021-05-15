using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.MatchLists
{
    public class DeleteModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public DeleteModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MatchList MatchList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MatchList = await _context.MatchList.FirstOrDefaultAsync(m => m.ID == id);

            if (MatchList == null)
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

            MatchList = await _context.MatchList.FindAsync(id);

            if (MatchList != null)
            {
                _context.MatchList.Remove(MatchList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

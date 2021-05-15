using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.SummonerAccountInfos
{
    public class EditModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public EditModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SummonerAccountInfo SummonerAccountInfo { get; set; }

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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SummonerAccountInfo).State = EntityState.Modified;

            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SummonerAccountInfoExists(SummonerAccountInfo.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SummonerAccountInfoExists(int id)
        {
            return _context.SummonerAccountInfo.Any(e => e.ID == id);
        }
    }
}

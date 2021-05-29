using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.ParticipantFramess
{
    public class DeleteModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public DeleteModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ParticipantFrames ParticipantFrames { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParticipantFrames = await _context.ParticipantFrames.FirstOrDefaultAsync(m => m.ID == id);

            if (ParticipantFrames == null)
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

            ParticipantFrames = await _context.ParticipantFrames.FindAsync(id);

            if (ParticipantFrames != null)
            {
                _context.ParticipantFrames.Remove(ParticipantFrames);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

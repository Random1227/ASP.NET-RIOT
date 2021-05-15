using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.ParticipantInfos
{
    public class DetailsModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public DetailsModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public ParticipantInfo ParticipantInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParticipantInfo = await _context.ParticipantInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (ParticipantInfo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

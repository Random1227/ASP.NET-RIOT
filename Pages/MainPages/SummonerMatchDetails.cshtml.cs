using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.MainPages
{
    public class SummonerMatchDetailsModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public SummonerMatchDetailsModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public MatchInfo MatchInfo { get; set; }
        public IList<ParticipantFrames> ParticipantFrames { get; set; }
        public IList<MatchEvent> MatchEvents { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MatchInfo = await _context.MatchInfo.FirstOrDefaultAsync(m => m.ID == id);
            ParticipantFrames = await _context.ParticipantFrames.Include(MatchInfo.MatchId).ToListAsync();

            if (MatchInfo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

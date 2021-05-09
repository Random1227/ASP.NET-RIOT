using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.Summoners
{
    public class DetailsModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public DetailsModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public Summoner Summoner { get; set; }

        public DateTimeOffset RevisionDate {get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Summoner = await _context.Summoner.FirstOrDefaultAsync(m => m.ID == id);


            RevisionDate = DateTimeOffset.FromUnixTimeMilliseconds(Summoner.RevisionDate);

            if (Summoner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

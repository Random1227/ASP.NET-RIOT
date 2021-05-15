using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Data;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Pages.Matches
{
    public class IndexModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public IndexModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public IList<MatchInfo> MatchInfo { get;set; }

        public IList<TeamsInfo> TeamsInfos { get; set; }

        public IList<ParticipantInfo> ParticipantInfos { get; set; }

        public DateTime Time(long time)
        {
            var ConvertToTime = DateTimeOffset.FromUnixTimeMilliseconds(time).DateTime.ToLocalTime();
            return ConvertToTime;
        }


        public async Task OnGetAsync()
        {
            MatchInfo = await _context.MatchInfo.ToListAsync();
            TeamsInfos = await _context.TeamsInfo.ToListAsync();
            ParticipantInfos = await _context.ParticipantInfo.ToListAsync();
        }
    }
}

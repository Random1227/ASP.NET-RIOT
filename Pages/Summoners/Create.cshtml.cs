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
using System.IO;

namespace LeagueMatchHistory.Pages.Summoners
{
    public class CreateModel : PageModel
    {
        private readonly LeagueMatchHistory.Data.LeagueMatchHistoryContext _context;

        public CreateModel(LeagueMatchHistory.Data.LeagueMatchHistoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Summoner Summoner { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            WebClient webContent = new WebClient();

            string api_key = "RGAPI-e1193aab-8e9f-433d-9aa0-bac46d1ef109";

            string UrlSummoner = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + Summoner.SummonerName + "?api_key=" + api_key;

            var SummonerInfo = webContent.DownloadString(UrlSummoner);

            var SumInfo = JsonConvert.DeserializeObject<JsonClasses.SummonerDTO>(SummonerInfo);



            string UrlRanked = "https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/" + SumInfo.id + "?api_key=" + api_key;

            var RankedInfo = webContent.DownloadString(UrlRanked);



            //I need to create a new class that matches the Json from Riot, and replace Summoner 
            var RankInfo = JsonConvert.DeserializeObject<JsonClasses.LeagueEntryDTO>(RankedInfo);

            

            

            



            



            //_context.Summoner.Add(Summoner);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

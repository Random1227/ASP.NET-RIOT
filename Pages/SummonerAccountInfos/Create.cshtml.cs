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

namespace LeagueMatchHistory.Pages.SummonerAccountInfos
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
        public SummonerAccountInfo SummonerAccountInfo { get; set; }

        [BindProperty]
        public RankedInfo RankedInfo { get; set; }

        [BindProperty]
        public IList<SummonerAccountInfo> SummonerAccountInfos { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            /*Some basics of how this works
             * 
             * You start with Models (in the /Models/ folder) which are the templates for the objects and the database tables
             * Using those Models you can scaffold (create from the template) Create, Delete, Details, Edit, and Index pages
             * Create - Lets you make a new item in the database table
             * Delete - Removes that item from the database table
             * Details - Shows all information about a chosen item in the table
             * Edit - Change the item in the table
             * Index - Lists all items in the database
             * 
             * Any of these pages can be changed to do whatever you want, you don't have to stick with what the template is
             * 
             * Each page has the .cshtml file with a cshtml.cs nested in it
             * The .cshtml is the basic HTML, CSS, and Javascript of the webpage
             * It can also include C# code, started with the use of an @ sign at the beginning of a code block
             * 
             * The .cshtml.cs is the C# class for that webpage, and this class will hold all of the C# data that the page will need (info from the tabl for example)
             * Each .cshtml.cs file can hold whatever properties you may need to fill out the webpage
             * It will also have an OnGet() method and an OnPost() method
             * 
             * OnGet() - what is run when the page is initially loaded
             * OnPost() - what is run when the form is submitted
             * These methods can be Async, which I don't fully understand but it has something to do with letting the program continue on while it is waiting for the response from the Async method
             * 
             */

            

            SummonerAccountInfos = await _context.SummonerAccountInfo.ToListAsync();//fills the IList<Summoners> property with all of the Summoners in the Summoners table
            foreach (var summoner in SummonerAccountInfos)//goes through each
            {
                if (summoner.SummonerName == SummonerAccountInfo.SummonerName)//if it already exists, then just go back to the page
                {
                    //update the summoner if they exist

                }
            }
            //VERY IMPORTANT
            //MATCH-V5 endpoints only works with data taken from a temporary development key for now

            WebClient webContent = new WebClient();

            string api_key = "RGAPI-e1193aab-8e9f-433d-9aa0-bac46d1ef109";//this is a production key, will not working with MATCH-V5 (you can't even get a match history from it with a PUUID from the production key)
            //for now i'll just overwrite the api_key to get useful stuff to work with MATCH-V5

            //PUT YOUR DEV KEY HERE
            api_key = "RGAPI-b041a7e4-80f6-496a-894c-1c3c9107552a";

            //builds the string to summoner info
            string UrlSummoner = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + SummonerAccountInfo.SummonerName + "?api_key=" + api_key;
            //gets the stuff from the site (as a string)
            var SummonerInfo = webContent.DownloadString(UrlSummoner);

            //turns that string into a JSON
            //JsonConvert.DeserializeObject<template>(info);
            //template is from a class that is a template of what the Json will look like (located in /JsonClasses/ folder)
            //info is the string to turn into a Json

            var SumInfo = JsonConvert.DeserializeObject<JsonClasses.SummonerDTO>(SummonerInfo);




            //builds the string to get ranked info
            string UrlRanked = "https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/" + SumInfo.id + "?api_key=" + api_key;
            //use this to handle if people aren't ranked
            bool HasRankedInfo = true;
            //gets the person's ranked info (as a string)
            var RankedInfoString = webContent.DownloadString(UrlRanked);

            //this is a temporary workaround
            //the RankedInfo returns a list of ranked info from the different queues (I think just flex 5v5 and solo/duo)
            //for now i literally just rip off the brackets and act like only solo/duo exists
            //RankedInfoString = RankedInfoString.Trim('[', ']');

            if (RankedInfoString == "")
            {
                HasRankedInfo = false;
            }

            //I need to create a new class that matches the Json from Riot, and replace Summoner

            //turns their rankedinfo in JSON
            var RankInfoJson = JsonConvert.DeserializeObject<List<JsonClasses.LeagueEntryDTO>>(RankedInfoString);


            //Summoner is the object that this Create page is making, and is based on the Summoner Model
            //This block is just filling out the Summoner with all of the information from the stuff retrieved from the API
            SummonerAccountInfo.AccountId = SumInfo.accountId;
            SummonerAccountInfo.ProfileIconId = SumInfo.profileIconId;
            SummonerAccountInfo.PuuId = SumInfo.puuid;
            SummonerAccountInfo.RevisionDate = SumInfo.revisionDate;
            SummonerAccountInfo.SummonerId = SumInfo.id;
            SummonerAccountInfo.SummonerLevel = SumInfo.summonerLevel;
            SummonerAccountInfo.RecordCreated = DateTime.Now;
            SummonerAccountInfo.LastUpdated = DateTime.Now;



            if (RankInfoJson != null)
            {
                foreach (var RankInfoForQueueType in RankInfoJson)
                {
                    RankedInfo ranked = new RankedInfo();
                    ranked.FreshBlood = RankInfoForQueueType.freshBlood;
                    ranked.HotStreak = RankInfoForQueueType.hotStreak;
                    ranked.Inactive = RankInfoForQueueType.inactive;
                    ranked.LastUpdated = DateTime.Now;
                    ranked.LeagueId = RankInfoForQueueType.leagueId;
                    ranked.LeaguePoints = RankInfoForQueueType.leaguePoints;
                    ranked.Losses = RankInfoForQueueType.losses;
                    ranked.QueueType = RankInfoForQueueType.queueType;
                    ranked.Rank = RankInfoForQueueType.rank;
                    ranked.SummonerAccountInfo = SummonerAccountInfo;
                    ranked.SummonerId = RankInfoForQueueType.summonerId;
                    ranked.SummonerName = RankInfoForQueueType.summonerName;
                    ranked.Tier = RankInfoForQueueType.tier;
                    ranked.Veteran = RankInfoForQueueType.veteran;
                    ranked.Wins = RankInfoForQueueType.wins;

                    _context.RankedInfo.Add(ranked);

                }
            }








            _context.SummonerAccountInfo.Add(SummonerAccountInfo);//adds the object to the _context database
            await _context.SaveChangesAsync();//saves it to the database

            return RedirectToPage("./Index");//returns you back to the list page
        }
    }
}

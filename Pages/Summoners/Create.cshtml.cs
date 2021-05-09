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
using Microsoft.EntityFrameworkCore;

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

        [BindProperty]
        public IList<Summoner> Summoners { get; set; }

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



            Summoners = await _context.Summoner.ToListAsync();//fills the IList<Summoners> property with all of the Summoners in the Summoners table
            foreach (var summoner in Summoners)//goes through each
            {
                if(summoner.SummonerName == Summoner.SummonerName)//if it already exists, then just go back to the page
                {
                    return RedirectToPage("./Index");
                }
            }
            //VERY IMPORTANT
            //MATCH-V5 endpoints only works with data taken from a temporary development key for now

            WebClient webContent = new WebClient();

            string api_key = "RGAPI-e1193aab-8e9f-433d-9aa0-bac46d1ef109";//this is a production key, will not working with MATCH-V5 (you can't even get a match history from it with a PUUID from the production key)
            //for now i'll just overwrite the api_key to get useful stuff to work with MATCH-V5

            //PUT YOUR DEV KEY HERE
            api_key = "RGAPI-f9d17f08-e4e8-4ca4-82af-f3bb6bb14e81";

            //builds the string to summoner info
            string UrlSummoner = "https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + Summoner.SummonerName + "?api_key=" + api_key;
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
            var RankedInfo = webContent.DownloadString(UrlRanked);

            //this is a temporary workaround
            //the RankedInfo returns a list of ranked info from the different queues (I think just flex 5v5 and solo/duo)
            //for now i literally just rip off the brackets and act like only solo/duo exists
            RankedInfo = RankedInfo.Trim('[',']');

            if(RankedInfo == "")
            {
                HasRankedInfo = false;
            }

            //I need to create a new class that matches the Json from Riot, and replace Summoner

            //turns their rankedinfo in JSON
            var RankInfo = JsonConvert.DeserializeObject<JsonClasses.LeagueEntryDTO>(RankedInfo);
            
            //Summoner is the object that this Create page is making, and is based on the Summoner Model
            //This block is just filling out the Summoner with all of the information from the stuff retrieved from the API
            Summoner.AccountId = SumInfo.accountId;
            Summoner.ProfileIconId = SumInfo.profileIconId;
            Summoner.PuuId = SumInfo.puuid;
            Summoner.RevisionDate = SumInfo.revisionDate;
            Summoner.SummonerId = SumInfo.id;
            Summoner.SummonerLevel = SumInfo.summonerLevel;

            if(HasRankedInfo == true)
            {
                Summoner.FreshBlood = RankInfo.freshBlood;
                Summoner.HotStreak = RankInfo.hotStreak;
                Summoner.Inactive = RankInfo.inactive;
                Summoner.LeagueId = RankInfo.leagueId;
                Summoner.LeaguePoints = RankInfo.leaguePoints;
                Summoner.Losses = RankInfo.losses;
                Summoner.Wins = RankInfo.wins;
                Summoner.QueueType = RankInfo.queueType;
                Summoner.Rank = RankInfo.rank;
                Summoner.Tier = RankInfo.tier;
                Summoner.Veteran = RankInfo.veteran;
            }







            _context.Summoner.Add(Summoner);//adds the object to the _context database
            await _context.SaveChangesAsync();//saves it to the database

            return RedirectToPage("./Index");//returns you back to the list page
        }
    }
}

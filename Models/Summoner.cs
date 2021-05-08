﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class Summoner
    {
        [Key]
        public int ID { get; set; }

        //Summoner Info that everyone will have
        [Column(TypeName = "varchar(64)")]
        public string SummonerId { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string AccountId { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string PuuId { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string SummonerName { get; set; }

        [Column(TypeName = "varchar(64)")]
        public int RevisionDate { get; set; }

        [Column(TypeName = "varchar(64)")]
        public int SummonerLevel { get; set; }

        //Ranked Info that will default to empty string
        [Column(TypeName = "varchar(64)")]
        public string LeagueId { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string QueueType { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Tier { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Rank { get; set; }

        //Things people may not have
#nullable enable
        //Summoner Info
        [Column(TypeName = "varchar(64)")]
        public int ProfileIconId { get; set; }


        //Ranked Info
        [Column(TypeName = "varchar(64)")]
        public int LeaguePoints { get; set; }

        [Column(TypeName = "varchar(64)")]
        public int Wins { get; set; }

        [Column(TypeName = "varchar(64)")]
        public int Losses { get; set; }

        [Column(TypeName = "varchar(64)")]
        public bool Veteran { get; set; }

        [Column(TypeName = "varchar(64)")]
        public bool Inactive { get; set; }

        [Column(TypeName = "varchar(64)")]
        public bool FreshBlood { get; set; }

        [Column(TypeName = "varchar(64)")]
        public bool HotStreak { get; set; }
#nullable disable


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class RankedInfo
    {
                
        [Key]
        public int ID { get; set; }


        public virtual SummonerAccountInfo SummonerAccountInfo { get; set; }

        //Ranked Info
        [Column(TypeName = "varchar(512)")]
        public string LeagueId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string QueueType { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string Tier { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string Rank { get; set; }

        [ForeignKey("SummonerId")]
        [Column(TypeName = "varchar(512)")]
        public string SummonerId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string SummonerName { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int LeaguePoints { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Wins { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Losses { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool Veteran { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool Inactive { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FreshBlood { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool HotStreak { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }



    }
}

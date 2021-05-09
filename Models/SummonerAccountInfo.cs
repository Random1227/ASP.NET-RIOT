using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class SummonerAccountInfo
    {
        [Key]
        public int ID { get; set; }

        //Summoner Info that everyone will have, everything below is taken directly from the API
        
        [Column(TypeName = "varchar(512)")]
        public string SummonerId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string AccountId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string PuuId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string SummonerName { get; set; }

        [Column(TypeName = "varchar(512)")]
        public long RevisionDate { get; set; }

        [Column(TypeName = "varchar(512)")]
        public long SummonerLevel { get; set; }

#nullable enable
        //This can be null, so might as well deal with this now
        [Column(TypeName = "varchar(512)")]
        public int ProfileIconId { get; set; }


        //Extra records, these two will be created (or updated) with DateTime.Now()
        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }
#nullable disable


        [DataType(DataType.Date)]
        public DateTime RecordCreated { get; set; }







    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class MatchList
    {
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }
    }
}

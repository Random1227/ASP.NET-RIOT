using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class TeamsInfo
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("MatchId")]
        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }


        [Column(TypeName = "varchar(512)")]
        public int Ban0 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Ban1 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Ban2 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Ban3 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int Ban4 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstBaron { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int BaronKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstBlood { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int ChampionKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstDragon { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int DragonKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstInhibitor { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int InhibitorKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstRitHerald { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int RiftHeraldKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool FirstTower { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int TowerKills { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int TeamId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public bool Win { get; set; }


    }
}

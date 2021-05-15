using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.Models
{
    public class MatchInfo
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string DataVersion { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public long GameCreation { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int GameDuration { get; set; }

        [Column(TypeName = "varchar(512)")]
        public long GameId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string GameMode { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string GameName { get; set; }

        [Column(TypeName = "varchar(512)")]
        public long GameStartTimeStamp { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string GameType { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string GameVersion { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int MapId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string PlatformId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int QueueId { get; set; }
    }
}

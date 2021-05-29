using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LeagueMatchHistory.JsonClasses;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchDTO;
using LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO;


namespace LeagueMatchHistory.Models
{
    public class MatchEvent
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("MatchId")]
        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string EventType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int afterId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int beforeId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int bounty { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string buildingType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int gameId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int goldGain { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int itemId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int killStreakLength { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string killType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int killerId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int killerTeamId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string laneType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int level { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string levelUpType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string monsterSubType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string monsterType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string name { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int participantId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int x { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int y { get; set; }
        [Column(TypeName = "varchar(512)")]
        public long realTimeStamp { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int skillSlot { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int teamId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public long timestamp { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string towerType { get; set; }
        [Column(TypeName = "varchar(512)")]
        public string type { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int winningTeam { get; set; }

        //Assisting Participants
        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant0 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant1 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant2 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant3 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant4 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant5 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant6 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant7 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant8 { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int assistingParticipant9 { get; set; }

    }
}

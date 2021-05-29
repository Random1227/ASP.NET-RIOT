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
    public class ParticipantFrames
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("MatchId")]
        [Column(TypeName = "varchar(512)")]
        public string MatchId { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int currentGold { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int goldPerSecond { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int jungleMinionsKilled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int level { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int minionsKilled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int participantId { get; set; }

        [Column(TypeName = "varchar(512)")]
        public int timeEnemySpentControlled { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalGold { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int xp { get; set; }

        //position
        [Column(TypeName = "varchar(512)")]
        public int x { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int y { get; set; }

        //damageStats
        [Column(TypeName = "varchar(512)")]
        public int magicDamageDone { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicDamageDoneToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageDone { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageDoneToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int physicalDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageDone { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageDoneToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int totalDamageTaken { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageDone { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageDoneToChampions { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int trueDamageTaken { get; set; }

        //champStats
        [Column(TypeName = "varchar(512)")]
        public int abilityPower { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int armor { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int armorPen { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int armorPenPercent { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int attackDamage { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int attackSpeed { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int bonusArmorPenPercent { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int bonusMagicPenPercent { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int ccReduction { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int cooldownReduction { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int health { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int healthMax { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int healthRegen { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int lifesteal { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicPen { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicPenPercent { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int magicResist { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int movementSpeed { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int power { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int powerMax { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int powerRegen { get; set; }
        [Column(TypeName = "varchar(512)")]
        public int spellVamp { get; set; }


    }
}

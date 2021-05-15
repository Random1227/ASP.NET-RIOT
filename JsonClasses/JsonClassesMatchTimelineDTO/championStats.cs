using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class championStats
    {
        public int abilityPower { get; set; }
        public int armor { get; set; }
        public int armorPen { get; set; }
        public int armorPenPercent { get; set; }
        public int attackDamage { get; set; }
        public int attackSpeed { get; set; }
        public int bonusArmorPenPercent { get; set; }
        public int bonusMagicPenPercent { get; set; }
        public int ccReduction { get; set; }
        public int cooldownReduction { get; set; }
        public int health { get; set; }
        public int healthMax { get; set; }
        public int healthRegen { get; set; }
        public int lifesteal { get; set; }
        public int magicPen { get; set; }
        public int magicPenPercent { get; set; }
        public int magicResist { get; set; }
        public int movementSpeed { get; set; }
        public int power { get; set; }
        public int powerMax { get; set; }
        public int powerRegen { get; set; }
        public int spellVamp { get; set; }
    }
}

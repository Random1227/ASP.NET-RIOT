using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMatchHistory.JsonClasses.JsonClassesMatchTimelineDTO
{
    public class events
    {
        public int afterId { get; set; }
        public List<int> assistingParticipants { get; set; }
        public int beforeId { get; set; }
        public int bounty { get; set; }
        public string buildingType { get; set; }
        public int gameId { get; set; }
        public int goldGain { get; set; }
        public int itemId { get; set; }
        public int killStreakLength { get; set; }
        public string killType { get; set; }
        public int killerId { get; set; }
        public int killerTeamId { get; set; }
        public string laneType { get; set; }
        public int level { get; set; }
        public string levelUpType { get; set; }
        public string monsterSubType { get; set; }
        public string monsterType { get; set; }
        public string name { get; set; }
        public int participantId { get; set; }
        public position position { get; set; }
        public long realTimeStamp { get; set; }
        public int skillSlot { get; set; }
        public int teamId { get; set; }
        public long timestamp { get; set; }
        public string towerType { get; set; }
        public string type { get; set; }
        public int winningTeam { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeagueMatchHistory.Models;

namespace LeagueMatchHistory.Data
{
    public class LeagueMatchHistoryContext : DbContext
    {
        public LeagueMatchHistoryContext (DbContextOptions<LeagueMatchHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<LeagueMatchHistory.Models.SummonerAccountInfo> SummonerAccountInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.RankedInfo> RankedInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.MatchInfo> MatchInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.TeamsInfo> TeamsInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.ParticipantInfo> ParticipantInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.MatchList> MatchList { get; set; }

        public DbSet<LeagueMatchHistory.Models.MatchEvent> MatchEvent { get; set; }

        public DbSet<LeagueMatchHistory.Models.ParticipantFrames> ParticipantFrames { get; set; }
    }
}

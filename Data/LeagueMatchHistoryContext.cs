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

        public DbSet<LeagueMatchHistory.Models.Summoner> Summoner { get; set; }

        public DbSet<LeagueMatchHistory.Models.SummonerAccountInfo> SummonerAccountInfo { get; set; }

        public DbSet<LeagueMatchHistory.Models.RankedInfo> RankedInfo { get; set; }
    }
}

﻿// <auto-generated />
using LeagueMatchHistory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueMatchHistory.Migrations
{
    [DbContext(typeof(LeagueMatchHistoryContext))]
    partial class LeagueMatchHistoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueMatchHistory.Models.Summoner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("FreshBlood")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("HotStreak")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Inactive")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("LeagueId")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("LeaguePoints")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Losses")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProfileIconId")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("PuuId")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("QueueType")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Rank")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("RevisionDate")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("SummonerId")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("SummonerLevel")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Tier")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Veteran")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Wins")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.HasKey("ID");

                    b.ToTable("Summoner");
                });
#pragma warning restore 612, 618
        }
    }
}

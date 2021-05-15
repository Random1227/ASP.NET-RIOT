﻿// <auto-generated />
using System;
using LeagueMatchHistory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueMatchHistory.Migrations
{
    [DbContext(typeof(LeagueMatchHistoryContext))]
    [Migration("20210511163717_MatchDataAttempt2")]
    partial class MatchDataAttempt2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueMatchHistory.Models.MatchInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataVersion")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameCreation")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameDuration")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameMode")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameName")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameStartTimeStamp")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameType")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("GameVersion")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("MapId")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("MatchId")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("PlatformId")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("QueueId")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.HasKey("ID");

                    b.ToTable("MatchInfo");
                });

            modelBuilder.Entity("LeagueMatchHistory.Models.RankedInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FreshBlood")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("HotStreak")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Inactive")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeagueId")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("LeaguePoints")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Losses")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("QueueType")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Rank")
                        .HasColumnType("varchar(512)");

                    b.Property<int?>("SummonerAccountInfoID")
                        .HasColumnType("int");

                    b.Property<string>("SummonerId")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Tier")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Veteran")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Wins")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.HasKey("ID");

                    b.HasIndex("SummonerAccountInfoID");

                    b.ToTable("RankedInfo");
                });

            modelBuilder.Entity("LeagueMatchHistory.Models.SummonerAccountInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileIconId")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("PuuId")
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime>("RecordCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevisionDate")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("SummonerId")
                        .HasColumnType("varchar(512)");

                    b.Property<string>("SummonerLevel")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("varchar(512)");

                    b.HasKey("ID");

                    b.ToTable("SummonerAccountInfo");
                });

            modelBuilder.Entity("LeagueMatchHistory.Models.RankedInfo", b =>
                {
                    b.HasOne("LeagueMatchHistory.Models.SummonerAccountInfo", "SummonerAccountInfo")
                        .WithMany()
                        .HasForeignKey("SummonerAccountInfoID");

                    b.Navigation("SummonerAccountInfo");
                });
#pragma warning restore 612, 618
        }
    }
}

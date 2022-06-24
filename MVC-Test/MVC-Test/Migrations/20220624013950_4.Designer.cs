﻿// <auto-generated />
using System;
using MVC_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Test.Migrations
{
    [DbContext(typeof(BasketballContext))]
    [Migration("20220624013950_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_Test.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FavoriteFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FavoriteFood = "Pizza",
                            Losses = 38,
                            Name = "JB Bickerstaff",
                            StartYear = new DateTime(2022, 6, 23, 21, 39, 50, 621, DateTimeKind.Local).AddTicks(3974),
                            Wins = 44
                        });
                });

            modelBuilder.Entity("MVC_Test.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsRetired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PPG")
                        .HasColumnType("float");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsRetired = false,
                            Name = "Kevin Love",
                            PPG = 10.4,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsRetired = false,
                            Name = "Colin Sexton",
                            PPG = 19.300000000000001,
                            TeamId = 1
                        });
                });

            modelBuilder.Entity("MVC_Test.Models.PlayerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PositionId");

                    b.ToTable("PlayerPosition");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlayerId = 1,
                            PositionId = 4
                        },
                        new
                        {
                            Id = 2,
                            PlayerId = 1,
                            PositionId = 5
                        },
                        new
                        {
                            Id = 3,
                            PlayerId = 2,
                            PositionId = 1
                        },
                        new
                        {
                            Id = 4,
                            PlayerId = 2,
                            PositionId = 2
                        });
                });

            modelBuilder.Entity("MVC_Test.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Point Guard"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shooting Guard"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Small Forward"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Power Forward"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Center"
                        });
                });

            modelBuilder.Entity("MVC_Test.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Mascot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoachId")
                        .IsUnique();

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Cleveland",
                            CoachId = 0,
                            Mascot = "Moondog",
                            Name = "Cavs"
                        });
                });

            modelBuilder.Entity("MVC_Test.Models.Player", b =>
                {
                    b.HasOne("MVC_Test.Models.Team", "Team")
                        .WithMany("Player")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MVC_Test.Models.PlayerPosition", b =>
                {
                    b.HasOne("MVC_Test.Models.Player", "Player")
                        .WithMany("Positions")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Test.Models.Position", "Positions")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("MVC_Test.Models.Team", b =>
                {
                    b.HasOne("MVC_Test.Models.Coach", "Coach")
                        .WithOne("Team")
                        .HasForeignKey("MVC_Test.Models.Team", "CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("MVC_Test.Models.Coach", b =>
                {
                    b.Navigation("Team")
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Test.Models.Player", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("MVC_Test.Models.Position", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("MVC_Test.Models.Team", b =>
                {
                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}

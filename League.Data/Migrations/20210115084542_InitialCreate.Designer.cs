﻿// <auto-generated />
using League.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace League.Data.Migrations
{
    [DbContext(typeof(LeagueDbContext))]
    [Migration("20210115084542_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("League.Models.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Blurb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("InfoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartTypeId")
                        .HasColumnType("int");

                    b.Property<int>("StatsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("InfoId");

                    b.HasIndex("PartTypeId");

                    b.HasIndex("StatsId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("League.Models.ChampionData.PartType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PartType");
                });

            modelBuilder.Entity("League.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("League.Models.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("Magic")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChampionInfo");
                });

            modelBuilder.Entity("League.Models.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<int>("ArmorPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("AttackDamage")
                        .HasColumnType("int");

                    b.Property<int>("AttackDamagePerLevel")
                        .HasColumnType("int");

                    b.Property<int>("AttackSpeed")
                        .HasColumnType("int");

                    b.Property<int>("AttackSpeedPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<int>("HpPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("HpRegen")
                        .HasColumnType("int");

                    b.Property<int>("HpRegenPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("MoveSpeed")
                        .HasColumnType("int");

                    b.Property<int>("Mp")
                        .HasColumnType("int");

                    b.Property<int>("MpPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("MpRegen")
                        .HasColumnType("int");

                    b.Property<int>("MpRegenPerLevel")
                        .HasColumnType("int");

                    b.Property<int>("SpellBlock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("League.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("League.Models.TagsChampions", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ChampionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagsChampions");
                });

            modelBuilder.Entity("League.Models.Champion", b =>
                {
                    b.HasOne("League.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.Info", "Info")
                        .WithMany()
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.ChampionData.PartType", "PartType")
                        .WithMany("Champions")
                        .HasForeignKey("PartTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Info");

                    b.Navigation("PartType");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("League.Models.TagsChampions", b =>
                {
                    b.HasOne("League.Models.Champion", "Champion")
                        .WithMany("Tags")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.Tag", "Tag")
                        .WithMany("Champions")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champion");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("League.Models.Champion", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("League.Models.ChampionData.PartType", b =>
                {
                    b.Navigation("Champions");
                });

            modelBuilder.Entity("League.Models.Tag", b =>
                {
                    b.Navigation("Champions");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using League.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace League.Data.Migrations
{
    [DbContext(typeof(LeagueDbContext))]
    [Migration("20210116085517_FixMapsItem")]
    partial class FixMapsItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("League.Models.ChampionData.Champion", b =>
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
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PartType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("InfoId");

                    b.HasIndex("StatsId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("League.Models.ChampionData.Info", b =>
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

            modelBuilder.Entity("League.Models.ChampionData.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<double>("ArmorPerLevel")
                        .HasColumnType("float");

                    b.Property<double>("AttackDamage")
                        .HasColumnType("float");

                    b.Property<double>("AttackDamagePerLevel")
                        .HasColumnType("float");

                    b.Property<int>("AttackRange")
                        .HasColumnType("int");

                    b.Property<double>("AttackSpeed")
                        .HasColumnType("float");

                    b.Property<double>("AttackSpeedPerLevel")
                        .HasColumnType("float");

                    b.Property<double>("Hp")
                        .HasColumnType("float");

                    b.Property<int>("HpPerLevel")
                        .HasColumnType("int");

                    b.Property<double>("HpRegen")
                        .HasColumnType("float");

                    b.Property<double>("HpRegenPerLevel")
                        .HasColumnType("float");

                    b.Property<int>("MoveSpeed")
                        .HasColumnType("int");

                    b.Property<double>("Mp")
                        .HasColumnType("float");

                    b.Property<double>("MpPerLevel")
                        .HasColumnType("float");

                    b.Property<double>("MpRegen")
                        .HasColumnType("float");

                    b.Property<double>("MpRegenPerLevel")
                        .HasColumnType("float");

                    b.Property<double>("SpellBlock")
                        .HasColumnType("float");

                    b.Property<double>("SpellBlockPerLevel")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("League.Models.ChampionData.TagsChampions", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ChampionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagsChampions");
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

            modelBuilder.Entity("League.Models.ItemData.Gold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BaseGold")
                        .HasColumnType("int");

                    b.Property<bool>("Purchasable")
                        .HasColumnType("bit");

                    b.Property<int>("Sell")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gold");
                });

            modelBuilder.Entity("League.Models.ItemData.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoldId")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("MapsItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlainText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GoldId");

                    b.HasIndex("ImageId");

                    b.HasIndex("MapsItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("League.Models.ItemData.MapsItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("HowlingAbyss")
                        .HasColumnType("bit");

                    b.Property<bool>("NexusBlitz")
                        .HasColumnType("bit");

                    b.Property<bool>("SummonersRift")
                        .HasColumnType("bit");

                    b.Property<bool>("TFT")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MapsItem");
                });

            modelBuilder.Entity("League.Models.ItemData.TagsItems", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagsItems");
                });

            modelBuilder.Entity("League.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Map");
                });

            modelBuilder.Entity("League.Models.RuneData.Rune", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SlotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SlotId");

                    b.ToTable("Rune");
                });

            modelBuilder.Entity("League.Models.RuneData.RunePath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("SlotsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SlotsId");

                    b.ToTable("RunePaths");
                });

            modelBuilder.Entity("League.Models.RuneData.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("League.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("League.Models.ChampionData.Champion", b =>
                {
                    b.HasOne("League.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.ChampionData.Info", "Info")
                        .WithMany()
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.ChampionData.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Info");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("League.Models.ChampionData.TagsChampions", b =>
                {
                    b.HasOne("League.Models.ChampionData.Champion", "Champion")
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

            modelBuilder.Entity("League.Models.ItemData.Item", b =>
                {
                    b.HasOne("League.Models.ItemData.Gold", "Gold")
                        .WithMany()
                        .HasForeignKey("GoldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.ItemData.MapsItem", "Maps")
                        .WithMany()
                        .HasForeignKey("MapsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gold");

                    b.Navigation("Image");

                    b.Navigation("Maps");
                });

            modelBuilder.Entity("League.Models.ItemData.TagsItems", b =>
                {
                    b.HasOne("League.Models.ItemData.Item", "Item")
                        .WithMany("Tags")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.Tag", "Tag")
                        .WithMany("Items")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("League.Models.Map", b =>
                {
                    b.HasOne("League.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("League.Models.RuneData.Rune", b =>
                {
                    b.HasOne("League.Models.RuneData.Slot", null)
                        .WithMany("Runes")
                        .HasForeignKey("SlotId");
                });

            modelBuilder.Entity("League.Models.RuneData.RunePath", b =>
                {
                    b.HasOne("League.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("League.Models.RuneData.Slot", "Slots")
                        .WithMany()
                        .HasForeignKey("SlotsId");

                    b.Navigation("Image");

                    b.Navigation("Slots");
                });

            modelBuilder.Entity("League.Models.ChampionData.Champion", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("League.Models.ItemData.Item", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("League.Models.RuneData.Slot", b =>
                {
                    b.Navigation("Runes");
                });

            modelBuilder.Entity("League.Models.Tag", b =>
                {
                    b.Navigation("Champions");

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

namespace League.ConsoleApp
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using AutoMapper;
    using Data;
    using DTOs;
    using DTOs.Champions;
    using DTOs.Items;
    using DTOs.Runes;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.ChampionData;
    using Models.ItemData;
    using Models.RuneData;
    using Pomelo.EntityFrameworkCore.MySql.Internal;

    public class LeagueProfile : Profile
    {
        private static LeagueDbContext context = new LeagueDbContext();
        public LeagueProfile()
        {
            //CHAMPIONS

            this.CreateMap<ChampionDto, Champion>()
                .ForMember(x => x.Info,
                    opt => opt.MapFrom(x => new Info
                    {
                        Attack = x.Info.Attack,
                        Defense = x.Info.Defense,
                        Magic = x.Info.Magic,
                        Difficulty = x.Info.Difficulty
                    }))
                .ForMember(x => x.Image,
                    opt => opt.MapFrom(x => new Image
                    {
                        Path = x.Image.Path
                    }))
                .ForMember(x => x.Stats,
                    opt => opt.MapFrom(x => new Stats()
                    {
                        Hp = x.Stats.Hp,
                        HpPerLevel = x.Stats.HpPerLevel,
                        HpRegen = x.Stats.HpRegen,
                        HpRegenPerLevel = x.Stats.HpPerLevel,
                        Mp = x.Stats.Mp,
                        MpPerLevel = x.Stats.MpPerLevel,
                        MpRegen = x.Stats.MpRegen,
                        MpRegenPerLevel = x.Stats.MpRegenPerLevel,
                        AttackDamage = x.Stats.AttackDamage,
                        AttackDamagePerLevel = x.Stats.AttackDamagePerLevel,
                        Armor = x.Stats.Armor,
                        ArmorPerLevel = x.Stats.ArmorPerLevel,
                        MoveSpeed = x.Stats.MoveSpeed,
                        AttackRange = x.Stats.AttackRange,
                        AttackSpeed = x.Stats.AttackSpeed,
                        AttackSpeedPerLevel = x.Stats.AttackSpeedPerLevel,
                        SpellBlock = x.Stats.SpellBlock,
                        SpellBlockPerLevel = x.Stats.SpellBlockPerLevel
                    }))
                .ForMember(x => x.Tags,
                    opt => opt.MapFrom(x => x.Таgs.Select(t => new TagsChampions()
                    {
                        TagId = context.Tags.FirstOrDefault(p => p.Name == t).Id
                    })))
                .ForMember(x => x.Skins,
                    opt => opt.MapFrom(x => x.Skins.Select(s => new Skin
                    {
                        Name = s.Name,
                        HasChromas = s.HasChromas,
                        Images = new List<Image>()
                        {
                            new Image
                            {
                                Path = $@"\skins\splash\{x.Name}_{s.Num}.jpg"
                            },
                            new Image
                            {
                                Path = $@"\skins\loading\{x.Name}_{s.Num}.jpg"
                            },
                            new Image()
                            {
                                Path = $@"\skins\tiles\{x.Name}_{s.Num}.jpg"
                            }
                        }
                    })))
                .ForMember(x => x.AllyTips,
                    opt => opt.MapFrom(x => x.AllyTips.Select(a => new AllyTip()
                    {
                        TipText = a,
                    })))
                .ForMember(x => x.EnemyTips,
                    opt => opt.MapFrom(x => x.EnemyTips.Select(a => new EnemyTip()
                    {
                        TipText = a,
                    })))
                .ForMember(x => x.Passive,
                    opt => opt.MapFrom(x => new Passive
                    {
                        Name = x.Passive.Name,
                        Description = x.Passive.Description,
                        Image = new Image
                        {
                            Path = x.Passive.Image.Path
                        }
                    }))
                .ForMember(x => x.Recommendations,
                    opt => opt.MapFrom(x => x.Recommended.Select(r => new Recommended
                    {
                        Title = r.Title,
                        MapName = r.MapName,
                        Mode = r.Mode,
                        Blocks = r.Blocks.Select(b => new Block
                        {
                            Type = b.Type,
                            MinSummonerLevel = b.MinSummonerLevel,
                            MaxSummonerLevel = b.MaxSummonerLevel,
                            ShowIfSummonerSpell = b.ShowIfSummonerSpell,
                            HideIfSummonerSpell = b.HideIfSummonerSpell,
                           //Items = b.Items.Select(i => i.ItemId).Select(it => new BlockItem()
                           //{
                           //    ItemId = context.Items.FirstOrDefault(k => k.RiotId.ToString() == it).Id
                           //}).ToList()

                            //ItemId = int.Parse(k.ItemId),
                            //Item = context.Items.Where(i => i.RiotId == int.Parse(k.ItemId)),
                            //// ItemId = context.Items.FirstOrDefault(i => i.RiotId == int.Parse(k.ItemId)).Id

                            //context.Items.Where(it => b.Items.Select(p => p.ItemId).Contains(it.RiotId.ToString())).ToList()
                            //FirstOrDefault(it => b.Items.FirstOrDefault(bi => bi.ItemId == it.RiotId.ToString())).Id
                            //Items = context.Items.Where(i => b.Items.Select(k => k.ItemId).Contains(i.RiotId.ToString())).AsNoTracking().ToList()
                        }).ToList()
                    })));

            this.CreateMap<BlockItemDto, BlockItemDto>()
                .ForMember(x => x.ItemId,
                    opt => opt.MapFrom(x => x.ItemId));


            //MAPS

            this.CreateMap<MapDto, Map>()
                .ForMember(x => x.Image,
                    opt => opt.MapFrom(x => new Image
                    {
                        Path = x.Image.Path
                    }));

            //RUNES

            this.CreateMap<RunePathDto, RunePath>()
                .ForMember(x => x.Image,
                    opt => opt.MapFrom(x => new Image
                    {
                        Path = x.IconPath
                    }))
                .ForMember(x => x.Slots,
                    opt => opt.MapFrom(x => new Slot
                    {
                        Runes = x.Slots.SelectMany(s => s.Runes.Select(r => new Rune
                        {
                            Name = r.Name,
                            ShortDescription = r.ShortDescription,
                            LongDescription = r.LongDescription,
                            Image = new Image
                            {
                                Path = r.IconPath
                            },
                            RiotId = r.RiotId
                        })).ToList()
                    }));

            //ITEMS

            this.CreateMap<ItemDto, Item>()
                .ForMember(x => x.Gold,
                    opt => opt.MapFrom(x => new Gold
                    {
                        BaseGold = x.Gold.Base,
                        Purchasable = x.Gold.Purchasable,
                        Total = x.Gold.Total,
                        Sell = x.Gold.Sell
                    }))
                .ForMember(x => x.Image,
                    opt => opt.MapFrom(x => new Image
                    {
                        Path = x.Image.Path
                    }))
                .ForMember(x => x.Maps,
                    opt => opt.MapFrom(x => new MapsItem
                    {
                        SummonersRift = x.Maps.SummonersRift,
                        HowlingAbyss = x.Maps.HowlingAbyss,
                        NexusBlitz = x.Maps.NexusBlitz,
                        TFT = x.Maps.TFT,
                    }))
                .ForMember(x => x.Tags,
                    opt => opt.MapFrom(x => x.Tags.Select(t => new TagsItems()
                    {
                        TagId = context.Tags.FirstOrDefault(p => p.Name == t).Id
                    })))
                .ForMember(x => x.RiotId,
                    opt => opt.MapFrom(x => RegexId(x.Image.Path)))
                .ForMember(x => x.ItemStats,
                    opt => opt.MapFrom(x => new ItemStats
                    {
                        FlatMovementSpeedMod = x.ItemStats.FlatMovementSpeedMod,
                        FlatHPPoolMod = x.ItemStats.FlatHPPoolMod,
                        FlatCritChanceMod = x.ItemStats.FlatCritChanceMod,
                        FlatMagicDamageMod = x.ItemStats.FlatMagicDamageMod,
                        FlatMPPoolMod = x.ItemStats.FlatMPPoolMod,
                        FlatArmorMod = x.ItemStats.FlatArmorMod,
                        FlatSpellBlockMod = x.ItemStats.FlatSpellBlockMod,
                        FlatPhysicalDamageMod = x.ItemStats.FlatPhysicalDamageMod,
                        PercentAttackSpeedMod = x.ItemStats.PercentAttackSpeedMod,
                        PercentLifeStealMod = x.ItemStats.PercentLifeStealMod,
                        FlatHPRegenMod = x.ItemStats.FlatHPRegenMod,
                        PercentMovementSpeedMod = x.ItemStats.PercentMovementSpeedMod,
                        Stacks = x.Stacks,
                        InStore = x.InStore,
                        Consumable = x.Consumable,
                        ConsumedOnFull = x.ConsumedOnFull,
                        HideFromAll = x.HideFromAll,
                        SpecialRecipe = x.SpecialRecipe,
                        RequiredChampion = x.RequiredChampion
                    }))
                .ForMember(x => x.ItemStatsId,
                    opt => opt.MapFrom(x => x.ItemStats.Id))
                .ForMember(x => x.ItemsTo,
                    opt => opt.MapFrom(x => string.Join(" ", x.ItemsTo)))
                .ForMember(x => x.ItemsFrom,
                    opt => opt.MapFrom(x => string.Join(" ", x.ItemsFrom)));


            //.ForMember(x => x.ItemsFrom,
            //    opt => opt.MapFrom(x => x.ItemsFrom.Select(i => new ItemItemsFrom
            //    {
            //        ItemFromId = int.Parse(i),
            //    }).ToList()))
            //.ForMember(x => x.ItemsTo,
            //opt => opt.MapFrom(x => x.ItemsTo.Select(i => new ItemItemsTo()
            //{
            //    ItemToId = int.Parse(i),
            //}).ToList()));

            //.ForMember(x => x.ItemsTo,
            //    opt => opt.MapFrom(x => x.ItemsTo.Select(i => new ItemTo()
            //    {
            //        Id = int.Parse(i),
            //        Item = context.Items.FirstOrDefault(k => k.RiotId == int.Parse(i)),
            //        ItemId = RegexId(x.Image.Path)
            //    })))
            //.ForMember(x => x.ItemsFrom,
            //    opt => opt.MapFrom(x => x.ItemsFrom.Select(i => new ItemFrom()
            //    {
            //        Id = int.Parse(i),
            //        Item = context.Items.FirstOrDefault(k => k.RiotId == int.Parse(i)),
            //        ItemId = context.Items.FirstOrDefault(k => k.RiotId == int.Parse(i)).Id
            //    })));
            //ForMember(x => x.ItemsFrom,
            //   opt => opt.MapFrom(x => x.ItemsFrom.Distinct().Select(i => new ItemItemsFrom()
            //   {
            //       //ItemId = RegexId(x.Image.Path),
            //       ItemFromId = int.Parse(i)
            //   })));~

            //TAGS

            this.CreateMap<string, Tag>()
                .ForMember(x => x.Name,
                    opt => opt.MapFrom(x => x));
        }

        private int RegexId(string imagePath)
        {
            var match = Regex.Match(imagePath, "[0-9]+");
            return int.Parse(match.Value);
        }
    }
}

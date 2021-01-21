namespace League.ConsoleApp
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Data;
    using DTOs;
    using DTOs.Champions;
    using DTOs.Items;
    using DTOs.Runes;
    using Models;
    using Models.ChampionData;
    using Models.ItemData;
    using Models.RuneData;

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
                    }))
                );

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
                        }))
                    );

            //TAGS

            this.CreateMap<string, Tag>()
                .ForMember(x => x.Name,
                    opt => opt.MapFrom(x => x));
        }
    }
}

namespace League.ConsoleApp
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;
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

    //this class imports data from League of Legends official json files (14/01/2020)
    internal class DataImporter
    {
        private static IMapper mapper;
        private static string FilePath = "../../../JsonData/";
        public DataImporter(IConfigurationProvider config)
        {
            mapper = new Mapper(config);
        }

        public void ImportChampions(LeagueDbContext context)
        {
            string path = FilePath + "champion.json";
            var jsonChamps = JsonSerializer.Deserialize<ChampionDto[]>(File.ReadAllText(path));
            ImportTags(jsonChamps.SelectMany(x => x.Таgs).ToList(), context);
            var champs = mapper.Map<Champion[]>(jsonChamps);
            context.Champions.AddRange(champs);
            context.SaveChanges();
        }

        public void ImportMap(LeagueDbContext context)
        {
            string path = FilePath + "map.json";
            var jsonMaps = JsonSerializer.Deserialize<MapDto[]>(File.ReadAllText(path));
            var maps = mapper.Map<Map[]>(jsonMaps);
            context.Map.AddRange(maps);
            context.SaveChanges();
        }

        public void ImportRunes(LeagueDbContext context)
        {
            string path = FilePath + "runesReforged.json";
            var jsonRunes = JsonSerializer.Deserialize<RunePathDto[]>(File.ReadAllText(path));
            var runes = mapper.Map<RunePath[]>(jsonRunes);
            context.RunePaths.AddRange(runes);
            context.SaveChanges();
        }

        public void ImportItems(LeagueDbContext context)
        {
            string path = FilePath + "item.json";
            var jsonItems = JsonSerializer.Deserialize<ItemDto[]>(File.ReadAllText(path));
            ImportTags(jsonItems.SelectMany(x => x.Tags).ToList(), context);
            var items = mapper.Map<Item[]>(jsonItems);
            context.Items.AddRange(items);
            context.SaveChanges();
        }

        private static void ImportTags(ICollection<string> tags, LeagueDbContext context)
        {
            var dbTags = mapper.Map<Tag[]>(tags.Distinct());
            context.Tags.AddRange(dbTags);
            context.SaveChanges();
        }
    }
}

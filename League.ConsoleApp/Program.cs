namespace League.ConsoleApp
{
    using AutoMapper;
    using Data;
    using Microsoft.EntityFrameworkCore;

    class Program
    {
        static void Main()
        {
            using var context = new LeagueDbContext();
            //https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/Doublelift?api_key=RGAPI-e6c19fab-9840-4a8d-8b21-dbb9e6e4bec3

            //uncomment the method you would like to use
            //uncomment the optionsBuilder settings in the OnConfiguring method in the LeagueDbContext class
            //configure connectionString in Configuration if needed

            var config = new MapperConfiguration(x =>
            {
                x.AddProfile(new LeagueProfile());
            });
            
            var importer = new DataImporter(config);
            //CreateMySqlDb(context, importer);
            CreateSqlServerDb(context, importer);
        }

        private static void CreateMySqlDb(LeagueDbContext context, DataImporter importer)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            ImportData(importer, context);
        }

        private static void CreateSqlServerDb(LeagueDbContext context, DataImporter importer)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            ImportData(importer, context);
        }

        private static void ImportData(DataImporter importer, LeagueDbContext context)
        {
            importer.ImportItems(context);
            importer.ImportChampions(context);
            //importer.ImportMap(context);
            //importer.ImportRunes(context);
            //importer.RemoveTagsFromItemDescriptions(context);
        }
    }
}

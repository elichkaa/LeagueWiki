namespace League.ConsoleApp
{
    using System;
    using AutoMapper;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

    class Program
    {
        static void Main()
        {
            using var context = new LeagueDbContext();

            //uncomment the method you would like to use
            //uncomment the optionsBuilder settings in the OnConfiguring method in the LeagueDbContext class
            //configure connectionString in Configuration if needed

            //CreateMySqlDb(context);
            CreateSqlServerDb(context);

            var config = new MapperConfiguration(x =>
            {
                x.AddProfile(new LeagueProfile());
            });

            var importer = new DataImporter(config);
            //ImportData(importer, context);
        }

        private static void CreateMySqlDb(LeagueDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        private static void CreateSqlServerDb(LeagueDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }

        private static void ImportData(DataImporter importer, LeagueDbContext context)
        {
            importer.ImportChampions(context);
            importer.ImportMap(context);
            importer.ImportRunes(context);
            importer.ImportItems(context);
            importer.RemoveTagsFromItemDescriptions(context);
        }
    }
}

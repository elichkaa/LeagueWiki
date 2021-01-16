namespace League.ConsoleApp
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Data;
    using Microsoft.EntityFrameworkCore;

    class Program
    {
        static void Main()
        {
            var context = new LeagueDbContext();
            context.Database.EnsureDeleted();
            context.Database.Migrate();

            var config = new MapperConfiguration(x =>
            {
                x.AddProfile(new LeagueProfile());
            });

            var importer = new DataImporter(config);
            
            //importer.ImportChampions(context);
            //importer.ImportMap(context);
            //importer.ImportRunes(context);
            //importer.ImportItems(context);
        }
    }
}

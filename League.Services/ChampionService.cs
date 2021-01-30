namespace League.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Data;
    using League.Models.ChampionData;
    using Models;

    public class ChampionService : IChampionService
    {
        private readonly LeagueDbContext context;

        public ChampionService(LeagueDbContext db)
        {
            this.context = db;
        }

        public IEnumerable<ChampionViewModel> GetAllChampions()
        {
            return this.context
                .Champions
                .Select(MapToChampionViewModel())
                .OrderBy(x => x.Name)
                .ToList();
        }

        public IEnumerable<ChampionViewModel> GetChampionsByTag(string tagName)
        {
            return this.context
                .Champions
                .Where(x => x.Tags.Any(t => t.Tag.Name.ToLower() == tagName.ToLower()))
                .Select(MapToChampionViewModel()).
                ToList();
        }

        public ChampionViewModel GetChampionByName(string championName)
        {
            return this.context
                .Champions
                .Where(x => x.Name.ToLower() == championName.ToLower())
                .Select(MapToChampionViewModel())
                .FirstOrDefault();
        }

        public IEnumerable<ChampionViewModel> GetChampionsByPartType(string partType)
        {
            return this.context
                .Champions
                .Where(x => x.PartType.ToLower() == partType.ToLower())
                .Select(MapToChampionViewModel()).
                ToList();
        }

        public IEnumerable<ChampionViewModel> GetChampionsByDifficulty(int min, int max)
        {
            return this.context
                .Champions
                .Where(x => x.Info.Difficulty >= min && x.Info.Difficulty <= max)
                .Select(MapToChampionViewModel()).
                ToList();
        }

        private static Expression<Func<Champion, ChampionViewModel>> MapToChampionViewModel()
        {
            return x => new ChampionViewModel
            {
                Name = x.Name,
                Title = x.Title,
                Blurb = x.Blurb,
                ImagePath = x.Image.Path,
                Attack = x.Info.Attack,
                Defense = x.Info.Defense,
                Magic = x.Info.Magic,
                Difficulty = x.Info.Difficulty,
                Tags = x.Tags.Select(t => t.Tag.Name.ToString()).ToArray()
            };
        }
    }
}

namespace League.Services
{
    using System.Collections.Generic;
    using Models;

    public interface IChampionService
    {
        IEnumerable<ChampionViewModel> GetAllChampions();
        IEnumerable<ChampionViewModel> GetChampionsByTag(string tagName);
        IEnumerable<ChampionViewModel> GetChampionsByName(string championName);
        IEnumerable<ChampionViewModel> GetChampionsByPartType(string partType);
        IEnumerable<ChampionViewModel> GetChampionsByDifficulty(int min, int max);
    }
}

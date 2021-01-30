namespace League.Services
{
    using System.Collections.Generic;
    using Models;

    public interface IChampionService
    {
        IEnumerable<ChampionViewModel> GetAllChampions();
        IEnumerable<ChampionViewModel> GetChampionsByTag(string tagName);
        ChampionViewModel GetChampionByName(string championName);
        IEnumerable<ChampionViewModel> GetChampionsByPartType(string partType);
        IEnumerable<ChampionViewModel> GetChampionsByDifficulty(int min, int max);
    }
}

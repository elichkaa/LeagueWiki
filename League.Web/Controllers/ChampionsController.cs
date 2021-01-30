namespace League.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;

    public class ChampionsController : Controller
    {
        private readonly IChampionService championsService;

        public ChampionsController(IChampionService championService)
        {
            this.championsService = championService;
        }

        public IActionResult Index()
        {
            var champions = this.championsService.GetAllChampions();
            return this.View(champions);
        }

        public IActionResult Detailed(string championName)
        {
            var champion = this.championsService.GetChampionByName(championName);
            return this.View(champion);
        }
    }
}

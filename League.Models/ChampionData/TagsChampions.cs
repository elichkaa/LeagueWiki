
namespace League.Models.ChampionData
{
    public class TagsChampions
    {
        public int ChampionId { get; set; }
        public Champion Champion { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}

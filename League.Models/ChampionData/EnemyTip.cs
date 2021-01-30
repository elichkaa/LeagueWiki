namespace League.Models.ChampionData
{
    public class EnemyTip
    {
        public int Id { get; set; }
        public string TipText { get; set; }
        public int ChampionId { get; set; }
        public Champion Champion { get; set; }
    }
}

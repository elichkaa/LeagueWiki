namespace League.Models.ChampionData
{
    using ItemData;

    public class BlockItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int BlockId { get; set; }
        public Block Block { get; set; }
    }
}

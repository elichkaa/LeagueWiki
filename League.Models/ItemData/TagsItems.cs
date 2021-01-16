namespace League.Models.ItemData
{
    public class TagsItems
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}

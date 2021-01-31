namespace League.Models.ItemData
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using ChampionData;

    public class Item
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public string PlainText { get; set; }
        public string Description { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int GoldId { get; set; }
        public Gold Gold { get; set; }

        public int MapsItemId { get; set; }
        public MapsItem Maps { get; set; }

        public int ItemStatsId { get; set; }
        public ItemStats ItemStats { get; set; }

        //get from img path
        public int RiotId { get; set; }

        public ICollection<TagsItems> Tags { get; set; }
        public ICollection<BlockItem> BlockItems { get; set; }

        public string ItemsTo { get; set; }
        public string ItemsFrom { get; set; }

    }
}


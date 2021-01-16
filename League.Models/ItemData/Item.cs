namespace League.Models.ItemData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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

        public ICollection<TagsItems> Tags { get; set; }
    }
}

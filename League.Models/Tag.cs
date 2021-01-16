
namespace League.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ChampionData;
    using ItemData;

    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<TagsChampions> Champions { get; set; }
        public ICollection<TagsItems> Items { get; set; }
    }
}

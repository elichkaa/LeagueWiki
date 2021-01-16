namespace League.Models.ChampionData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Champion
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        public string Blurb { get; set; }

        public int InfoId { get; set; }
        public Info Info { get; set; }
        
        public int ImageId { get; set; }
        public Image Image { get; set; }

        public ICollection<TagsChampions> Tags { get; set; }

        public string PartType { get; set; }

        public int StatsId { get; set; }
        public Stats Stats { get; set; }
    }
}
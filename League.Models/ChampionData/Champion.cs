namespace League.Models.ChampionData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
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
        public ICollection<Skin> Skins { get; set; }
        public ICollection<AllyTip> AllyTips { get; set; }
        public ICollection<EnemyTip> EnemyTips { get; set; }
        public ICollection<Recommended> Recommendations { get; set; }

        public string PartType { get; set; }

        public int StatsId { get; set; }
        public Stats Stats { get; set; }
        
        public int PassiveId { get; set; }
        public Passive Passive { get; set; }
    }
}
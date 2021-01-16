
namespace League.Models.ChampionData
{
    using System.ComponentModel.DataAnnotations;

    public class Info
    {
        [Key]
        public int Id { get; set; } 
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
    }
}

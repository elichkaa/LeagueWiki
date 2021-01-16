namespace League.Models.RuneData
{
    using System.ComponentModel.DataAnnotations;

    public class Rune
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}

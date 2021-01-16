
namespace League.Models.RuneData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Slot
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Rune> Runes { get; set; }
    }
}

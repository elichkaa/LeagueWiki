namespace League.Models.RuneData
{
    using System.ComponentModel.DataAnnotations;

    public class RunePath
    {
        [Key]
        public int Id { get; set; }

        public int RiotId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }

        public Slot Slots { get; set; }
    }
}

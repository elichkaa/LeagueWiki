
namespace League.Models.ItemData
{
    using System.ComponentModel.DataAnnotations;

    public class MapsItem
    {
        [Key]
        public int Id { get; set; }

        public bool SummonersRift { get; set; }

        public bool HowlingAbyss { get; set; }

        public bool NexusBlitz { get; set; }

        public bool TFT { get; set; }
    }
}

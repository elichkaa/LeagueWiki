
namespace League.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Map
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}

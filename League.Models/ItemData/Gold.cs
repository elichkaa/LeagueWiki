
namespace League.Models.ItemData
{
    using System.ComponentModel.DataAnnotations;

    public class Gold
    {
        [Key]
        public int Id { get; set; }
        public int BaseGold { get; set; }
        public bool Purchasable { get; set; }
        public int Total { get; set; }
        public int Sell { get; set; }

    }
}

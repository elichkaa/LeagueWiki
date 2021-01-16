
namespace League.ConsoleApp.DTOs.Items
{
    using System.Text.Json.Serialization;

    public class GoldDto
    {
        [JsonPropertyName("base")]
        public int Base { get; set; }

        [JsonPropertyName("purchasable")]
        public bool Purchasable { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("sell")]
        public int Sell { get; set; }
    }
}
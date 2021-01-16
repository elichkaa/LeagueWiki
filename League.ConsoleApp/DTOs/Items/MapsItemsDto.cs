
namespace League.ConsoleApp.DTOs.Items
{
    using System.Text.Json.Serialization;

    public class MapsItemsDto
    {
        [JsonPropertyName("11")]
        public bool SummonersRift { get; set; }

        [JsonPropertyName("12")]
        public bool HowlingAbyss { get; set; }

        [JsonPropertyName("21")]
        public bool NexusBlitz { get; set; }

        [JsonPropertyName("22")]
        public bool TFT { get; set; }
    }
}

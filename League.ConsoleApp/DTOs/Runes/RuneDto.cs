
namespace League.ConsoleApp.DTOs.Runes
{
    using System.Text.Json.Serialization;

    public class RuneDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int RiotId { get; set; }

        [JsonPropertyName("icon")]
        public string IconPath { get; set; }

        [JsonPropertyName("shortDesc")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("longDesc")]
        public string LongDescription { get; set; }
    }
}

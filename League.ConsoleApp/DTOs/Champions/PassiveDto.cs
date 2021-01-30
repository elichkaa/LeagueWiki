
namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;
    using Models;

    public class PassiveDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }
    }
}

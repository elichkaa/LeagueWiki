
namespace League.ConsoleApp.DTOs
{
    using System.Text.Json.Serialization;
    using Champions;

    public class MapDto
    {
        [JsonPropertyName("MapName")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }
    }
}

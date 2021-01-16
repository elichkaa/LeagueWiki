namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;

    public class ImageDto
    {
        [JsonPropertyName("full")]
        public string Path { get; set; }
    }
}

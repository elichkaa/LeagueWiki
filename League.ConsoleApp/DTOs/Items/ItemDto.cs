
namespace League.ConsoleApp.DTOs.Items
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Champions;

    public class ItemDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("plaintext")]
        public string PlainText { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }

        [JsonPropertyName("gold")]
        public GoldDto Gold { get; set; }

        [JsonPropertyName("tags")]
        public ICollection<string> Tags { get; set; }

        [JsonPropertyName("maps")]
        public MapsItemsDto Maps { get; set; }
    }
}

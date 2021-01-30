namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;

    public class BlockItemDto
    {
        [JsonPropertyName("id")]
        public string ItemId { get; set; }
    }
}

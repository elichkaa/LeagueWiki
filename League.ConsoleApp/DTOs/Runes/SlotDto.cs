
namespace League.ConsoleApp.DTOs.Runes
{
    using System.Text.Json.Serialization;

    public class SlotDto
    {
        [JsonPropertyName("runes")]
        public RuneDto[] Runes { get; set; }
    }
}

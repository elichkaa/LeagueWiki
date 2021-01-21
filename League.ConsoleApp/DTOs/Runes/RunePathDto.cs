
namespace League.ConsoleApp.DTOs.Runes
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RunePathDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int RiotId { get; set; }

        [JsonPropertyName("icon")]
        public string IconPath { get; set; }

        [JsonPropertyName("slots")]
        public ICollection<SlotDto> Slots { get; set; }
    }
}

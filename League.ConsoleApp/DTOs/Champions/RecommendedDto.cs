
namespace League.ConsoleApp.DTOs.Champions
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RecommendedDto
    {
        [JsonPropertyName("champion")]
        public string ChampionName { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("map")]
        public string MapName { get; set; }

        //caps
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("blocks")]
        public ICollection<BlockDto> Blocks { get; set; }
    }
}

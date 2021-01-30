namespace League.ConsoleApp.DTOs.Champions
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class BlockDto
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("minSummonerLevel")]
        public int MinSummonerLevel { get; set; }

        [JsonPropertyName("maxSummonerLevel")]
        public int MaxSummonerLevel { get; set; }

        [JsonPropertyName("showIfSummonerSpell")]
        public string ShowIfSummonerSpell { get; set; }

        [JsonPropertyName("hideIfSummonerSpell")]
        public string HideIfSummonerSpell { get; set; }

        [JsonPropertyName("items")]
        public ICollection<BlockItemDto> Items { get; set; } 
    }
}

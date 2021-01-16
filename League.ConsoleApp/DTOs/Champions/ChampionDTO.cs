namespace League.ConsoleApp.DTOs.Champions
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ChampionDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("blurb")]
        public string Blurb { get; set; }

        [JsonPropertyName("info")]
        public InfoDto Info { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }

        [JsonPropertyName("stats")]
        public StatsDto Stats { get; set; }

        [JsonPropertyName("tags")]
        public ICollection<string> Таgs { get; set; }

        [JsonPropertyName("partype")]
        public string PartType { get; set; }
    }
}

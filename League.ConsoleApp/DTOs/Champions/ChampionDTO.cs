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

        [JsonPropertyName("skins")]
        public ICollection<SkinDto> Skins { get; set; }

        [JsonPropertyName("lore")]
        public string Lore { get; set; }

        [JsonPropertyName("allytips")]
        public ICollection<string> AllyTips { get; set; }

        [JsonPropertyName("enemytips")]
        public ICollection<string> EnemyTips { get; set; }

        [JsonPropertyName("spells")]
        public SpellDto[] Spells { get; set; }

        [JsonPropertyName("passive")]
        public PassiveDto Passive { get; set; }

        [JsonPropertyName("recommended")]
        public RecommendedDto[] Recommended { get; set; }
    }
}


namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;

    public class SpellDto
    {
        //add letter Q,W,E,R
        [JsonPropertyName("id")]
        public string RiotId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("maxrank")]
        public int MaxRank { get; set; }

        [JsonPropertyName("cooldown")]
        public double[] Cooldowns { get; set; }

        [JsonPropertyName("cost")]
        public int[] CostPerLevel { get; set; }

        [JsonPropertyName("range")]
        public int[] Ranges { get; set; }

        [JsonPropertyName("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonPropertyName("rangeburn")]
        public string RangeBurn { get; set; }

        [JsonPropertyName("costburn")]
        public string CostBurn { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }

        [JsonPropertyName("maxammo")]
        public string MaxAmmo { get; set; }

        [JsonPropertyName("effectBurn")]
        public string[] Effects { get; set; }

        [JsonPropertyName("resource")]
        public string ResourceCost { get; set; }

        [JsonPropertyName("vars")]
        public VarsDto[] Vars { get; set; }
    }
}

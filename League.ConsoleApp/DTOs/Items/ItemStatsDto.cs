
namespace League.ConsoleApp.DTOs.Items
{
    using System.Text.Json.Serialization;
    
    public class ItemStatsDto
    {
        [JsonPropertyName("FlatMovementSpeedMod")]
        public int? FlatMovementSpeedMod { get; set; }

        [JsonPropertyName("FlatHPPoolMod")]
        public int? FlatHPPoolMod { get; set; }

        [JsonPropertyName("FlatCritChanceMod")]
        public double? FlatCritChanceMod { get; set; }

        [JsonPropertyName("FlatMagicDamageMod")]
        public int? FlatMagicDamageMod { get; set; }

        [JsonPropertyName("FlatMPPoolMod")]
        public int? FlatMPPoolMod { get; set; }

        [JsonPropertyName("FlatArmorMod")]
        public int? FlatArmorMod { get; set; }

        [JsonPropertyName("FlatSpellBlockMod")]
        public int? FlatSpellBlockMod { get; set; }

        [JsonPropertyName("FlatPhysicalDamageMod")]
        public int? FlatPhysicalDamageMod { get; set; }

        [JsonPropertyName("PercentAttackSpeedMod")]
        public double? PercentAttackSpeedMod { get; set; }

        [JsonPropertyName("PercentLifeStealMod")]
        public double? PercentLifeStealMod { get; set; }

        [JsonPropertyName("FlatHPRegenMod")]
        public double? FlatHPRegenMod { get; set; }

        [JsonPropertyName("PercentMovementSpeedMod")]
        public double? PercentMovementSpeedMod { get; set; }
    }
}

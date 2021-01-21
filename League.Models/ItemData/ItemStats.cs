
namespace League.Models.ItemData
{
    using System.ComponentModel;

    public class ItemStats
    {
        public int Id { get; set; }
        public int? FlatMovementSpeedMod { get; set; }
        public int? FlatHPPoolMod { get; set; }
        public double? FlatCritChanceMod { get; set; }
        public int? FlatMagicDamageMod { get; set; }
        public int? FlatMPPoolMod { get; set; }
        public int? FlatArmorMod { get; set; }
        public int? FlatSpellBlockMod { get; set; }
        public int? FlatPhysicalDamageMod { get; set; }
        public double? PercentAttackSpeedMod { get; set; }
        public double? PercentLifeStealMod { get; set; }
        public double? FlatHPRegenMod { get; set; }
        public double? PercentMovementSpeedMod { get; set; }

        public int? Stacks { get; set; }

        [DefaultValue(true)]
        public bool? InStore { get; set; }

        [DefaultValue(false)]
        public bool? Consumable { get; set; }

        //consume on full inventory
        [DefaultValue(false)]
        public bool? ConsumedOnFull { get; set; }

        [DefaultValue(false)]
        public bool? HideFromAll { get; set; }

        //an item transforms into another item
        public int? SpecialRecipe { get; set; }

        public string RequiredChampion { get; set; }

    }
}


namespace League.Models.ChampionData
{
    using System.ComponentModel.DataAnnotations;

    public class Stats
    {
        [Key]
        public int Id { get; set; }

        //Health
        public double Hp { get; set; }
        public int HpPerLevel { get; set; }
        public double HpRegen { get; set; }
        public double HpRegenPerLevel { get; set; }

        //Mana
        public double Mp { get; set; }
        public double MpPerLevel { get; set; }
        public double MpRegen { get; set; }
        public double MpRegenPerLevel { get; set; }

        //Damage
        public double AttackDamage { get; set; }
        public double AttackDamagePerLevel { get; set; }

        //Armor
        public int Armor { get; set; }
        public double ArmorPerLevel { get; set; }

        //Speed
        public int MoveSpeed { get; set; }
        public int AttackRange { get; set; }
        public double AttackSpeed { get; set; }
        public double AttackSpeedPerLevel { get; set; }

        //MagicResist
        public double SpellBlock { get; set; }
        public double SpellBlockPerLevel { get; set; }
        
        
    }
}

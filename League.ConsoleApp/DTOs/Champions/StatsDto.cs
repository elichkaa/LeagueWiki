namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;

    public class StatsDto
    {
        //Health
        [JsonPropertyName("hp")]
        public double Hp { get; set; }

        [JsonPropertyName("hpperlevel")]
        public int HpPerLevel { get; set; }

        [JsonPropertyName("hpregen")]
        public double HpRegen { get; set; }
        
        [JsonPropertyName("hpregenperlevel")]
        public double HpRegenPerLevel { get; set; }


        //Mana
        [JsonPropertyName("mp")]
        public double Mp { get; set; }

        [JsonPropertyName("mpperlevel")]
        public double MpPerLevel { get; set; }

        [JsonPropertyName("mpregen")]
        public double MpRegen { get; set; }

        [JsonPropertyName("mpregenperlevel")]
        public double MpRegenPerLevel { get; set; }


        //Armor
        [JsonPropertyName("armor")]
        public int Armor { get; set; }

        [JsonPropertyName("armorperlevel")]
        public double ArmorPerLevel { get; set; }

        //SpellBlock
        [JsonPropertyName("spellblock")]
        public double SpellBlock { get; set; }

        [JsonPropertyName("spellblockperlevel")]
        public double SpellBlockPerLevel { get; set; }

        //RangeAndSpeed
        [JsonPropertyName("attackrange")]
        public int AttackRange { get; set; }

        [JsonPropertyName("movespeed")]
        public int MoveSpeed { get; set; }

        //AttackDamage
        [JsonPropertyName("attackdamage")]
        public double AttackDamage { get; set; }

        [JsonPropertyName("attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        //AttackSpeed
        [JsonPropertyName("attackspeed")]
        public double AttackSpeed { get; set; }

        [JsonPropertyName("attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }
        
    }
}

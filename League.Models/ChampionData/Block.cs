namespace League.Models.ChampionData
{
    using System.Collections.Generic;
    using ItemData;

    public class Block
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public int MinSummonerLevel { get; set; }

        public int MaxSummonerLevel { get; set; }
        
        public string ShowIfSummonerSpell { get; set; }
        
        public string HideIfSummonerSpell { get; set; }
        
        public ICollection<Item> Items { get; set; }
    }
}

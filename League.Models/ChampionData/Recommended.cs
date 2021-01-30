namespace League.Models.ChampionData
{
    using System.Collections.Generic;

    public class Recommended
    {
        public int Id { get; set; }

        public int ChampionId { get; set; }
        public Champion Champion { get; set; }
        
        public string Title { get; set; }
        public string MapName { get; set; }

        //todo: remove caps
        public string Mode { get; set; }
        
        public ICollection<Block> Blocks { get; set; }
    }
}

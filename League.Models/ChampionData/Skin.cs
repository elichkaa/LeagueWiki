namespace League.Models.ChampionData
{
    using System.Collections.Generic;

    public class Skin
    {
        public int Id { get; set; }
        public int ChampionId { get; set; }
        public Champion Champion { get; set; }
        public string Name { get; set; }
        public bool HasChromas { get; set; }
        public List<Image> Images { get; set; }
    }
}

namespace League.Services.Models
{
    public class ChampionViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string ImagePath { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
        public string[] Tags { get; set; }
    }
}

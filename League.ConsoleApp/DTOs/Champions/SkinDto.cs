
namespace League.ConsoleApp.DTOs.Champions
{
    using System.Text.Json.Serialization;

    public class SkinDto
    {
        [JsonPropertyName("id")]
        public string RiotId { get; set; }

        [JsonPropertyName("chromas")]
        public bool HasChromas { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Splash = \league\img\champion\splash\{championName}_Num.jpg
        //Loading = \league\img\champion\loading\{championName}_Num.jpg
        //Tiles = \league\img\champion\tiles\{championName}_Num.jpg

        [JsonPropertyName("num")]
        public int Num { get; set; }
    }
}

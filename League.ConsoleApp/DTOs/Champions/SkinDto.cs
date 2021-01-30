
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

        [JsonPropertyName("num")]
        public int Num { get; set; }
    }
}

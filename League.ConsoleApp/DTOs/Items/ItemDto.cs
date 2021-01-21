
namespace League.ConsoleApp.DTOs.Items
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Champions;
    using Models.ItemData;

    public class ItemDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("plaintext")]
        public string PlainText { get; set; }

        [JsonPropertyName("image")]
        public ImageDto Image { get; set; }

        [JsonPropertyName("gold")]
        public GoldDto Gold { get; set; }

        [JsonPropertyName("consumed")]
        public bool? Consumable { get; set; }

        [JsonPropertyName("consumeOnFull")]
        public bool? ConsumedOnFull { get; set; }

        [JsonPropertyName("tags")]
        public ICollection<string> Tags { get; set; }

        [JsonPropertyName("stats")]
        public ItemStats ItemStats { get; set; }

        [JsonPropertyName("maps")]
        public MapsItemsDto Maps { get; set; }

        [JsonPropertyName("stacks")]
        public int? Stacks { get; set; }

        [JsonPropertyName("inStore")]
        public bool? InStore { get; set; }

        [JsonPropertyName("hideFromAll")]
        public bool? HideFromAll { get; set; }

        [JsonPropertyName("specialRecipe")]
        public int? SpecialRecipe { get; set; }

        [JsonPropertyName("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonPropertyName("from")]
        public ICollection<string> ItemsFrom { get; set; }
        
        [JsonPropertyName("into")]
        public ICollection<string> ItemsTo { get; set; }

        [JsonIgnore]
        public int RiotId { get; set; }
    }
}

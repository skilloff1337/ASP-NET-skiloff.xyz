using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponMetadata
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("imageUrl")] public string ImageUrl { get; set; }
        [JsonProperty("category")] public string Category { get; set; }
    }
}
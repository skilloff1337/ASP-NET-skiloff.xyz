using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.MapsStats
{
    public class MapsMetadata
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("imageUrl")] public string ImageUrl { get; set; }
    }
}
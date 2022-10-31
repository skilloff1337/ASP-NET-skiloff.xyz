using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.MapsStats
{
    public class MapsStatInfo
    {
        [JsonProperty("rank")] public object Rank { get; set; }
        [JsonProperty("percentile")] public object Percentile { get; set; }
        [JsonProperty("displayName")] public string DisplayName { get; set; }
        [JsonProperty("displayCategory")] public string DisplayCategory { get; set; }
        [JsonProperty("category")] public string Category { get; set; }

        [JsonProperty("metadata")]
        public MapsMetadata MapsMetadata { get; set; } = new();
        [JsonProperty("value")] public int Value { get; set; }
        [JsonProperty("displayValue")] public string DisplayValue { get; set; }
        [JsonProperty("displayType")] public string DisplayType { get; set; }
    }
}
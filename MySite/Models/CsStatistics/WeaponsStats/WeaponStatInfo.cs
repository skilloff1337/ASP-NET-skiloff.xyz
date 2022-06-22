using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponStatInfo
    {
        [JsonProperty("rank")] public object Rank { get; set; }
        [JsonProperty("percentile")] public double? Percentile { get; set; }
        [JsonProperty("displayName")] public string DisplayName { get; set; }
        [JsonProperty("displayCategory")] public string DisplayCategory { get; set; }
        [JsonProperty("category")] public string Category { get; set; }
        [JsonProperty("metadata")] public WeaponMetadata WeaponMetadata { get; set; }
        [JsonProperty("value")] public double Value { get; set; }
        [JsonProperty("displayValue")] public string DisplayValue { get; set; }
        [JsonProperty("displayType")] public string DisplayType { get; set; }
    }
}
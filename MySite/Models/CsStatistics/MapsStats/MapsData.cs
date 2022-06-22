using System;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.MapsStats
{
    public class MapsData
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("attributes")] public MapsAttributes MapsAttributes { get; set; }
        [JsonProperty("metadata")] public MapsMetadata MapsMetadata { get; set; }
        [JsonProperty("expiryDate")] public DateTime ExpiryDate { get; set; }
        [JsonProperty("stats")] public MapsStats MapsStats { get; set; }
    }
}
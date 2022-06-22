using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.MapsStats
{
    public class Maps
    {
        [JsonProperty("data")] public List<MapsData> Data { get; set; }
    }
}
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.MapsStats
{
    public class MapsStats
    {
        [JsonProperty("rounds")] public MapsStatInfo Rounds { get; set; }
        [JsonProperty("wins")] public MapsStatInfo Wins { get; set; }
    }
}
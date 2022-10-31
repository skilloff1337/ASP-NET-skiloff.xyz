using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponAttributes
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("categoryKey")]
        public string CategoryKey { get; set; }
    }
}
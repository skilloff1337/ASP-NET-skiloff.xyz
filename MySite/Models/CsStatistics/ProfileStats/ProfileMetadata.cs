using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileMetadata
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}
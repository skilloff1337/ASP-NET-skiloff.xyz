using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class Profile
    {
        [JsonProperty("data")]
        public ProfileData ProfileData { get; set; } = new();
    }
}
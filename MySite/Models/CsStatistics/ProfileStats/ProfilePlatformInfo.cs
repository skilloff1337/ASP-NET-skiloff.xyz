using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfilePlatformInfo
    {
        [JsonProperty("platformSlug")] public string PlatformSlug { get; set; }
        [JsonProperty("platformUserId")] public string PlatformUserId { get; set; }
        [JsonProperty("platformUserHandle")] public string PlatformUserHandle { get; set; }
        [JsonProperty("platformUserIdentifier")] public string PlatformUserIdentifier { get; set; }
        [JsonProperty("avatarUrl")] public string AvatarUrl { get; set; }
        [JsonProperty("additionalParameters")] public object AdditionalParameters { get; set; }
    }
}
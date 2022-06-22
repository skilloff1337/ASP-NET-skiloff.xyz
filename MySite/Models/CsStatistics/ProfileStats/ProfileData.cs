using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileData
    {
        [JsonProperty("platformInfo")] public ProfilePlatformInfo ProfilePlatformInfo { get; set; }
        [JsonProperty("userInfo")] public ProfileUserInfo ProfileUserInfo { get; set; }
        [JsonProperty("metadata")] public ProfileMetadata ProfileMetadata { get; set; }
        [JsonProperty("segments")] public List<ProfileSegment> Segments { get; set; }
        [JsonProperty("availableSegments")] public List<object> AvailableSegments { get; set; }
        [JsonProperty("expiryDate")] public DateTime ExpiryDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileData
    {
        [JsonProperty("platformInfo")]
        public ProfilePlatformInfo ProfilePlatformInfo { get; set; } = new();

        [JsonProperty("userInfo")]
        public ProfileUserInfo ProfileUserInfo { get; set; } = new();

        [JsonProperty("metadata")]
        public ProfileMetadata ProfileMetadata { get; set; } = new();

        [JsonProperty("segments")]
        public List<ProfileSegment> Segments { get; set; } = new();

        [JsonProperty("availableSegments")]
        public List<object> AvailableSegments { get; set; } = new();

        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }
    }
}
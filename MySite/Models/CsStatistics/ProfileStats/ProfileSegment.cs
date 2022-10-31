using System;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileSegment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public ProfileAttributes ProfileAttributes { get; set; } = new();

        [JsonProperty("metadata")]
        public ProfileMetadata ProfileMetadata { get; set; } = new();

        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        [JsonProperty("stats")]
        public ProfileStats ProfileStats { get; set; } = new();
    }
}
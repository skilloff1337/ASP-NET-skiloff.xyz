using System;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public WeaponAttributes WeaponAttributes { get; set; } = new();

        [JsonProperty("metadata")]
        public WeaponMetadata WeaponMetadata { get; set; } = new();

        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        [JsonProperty("stats")]
        public WeaponStats WeaponStats { get; set; } = new();
    }
}
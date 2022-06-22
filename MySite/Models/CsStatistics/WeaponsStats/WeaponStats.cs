using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponStats
    {
        [JsonProperty("kills")] public WeaponStatInfo Kills { get; set; }
        [JsonProperty("shotsFired")] public WeaponStatInfo ShotsFired { get; set; }
        [JsonProperty("shotsHit")] public WeaponStatInfo ShotsHit { get; set; }
        [JsonProperty("shotsAccuracy")] public WeaponStatInfo ShotsAccuracy { get; set; }
    }
}
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class WeaponStats
    {
        [JsonProperty("kills")] public WeaponStatInfo Kills { get; set; } = new();
        [JsonProperty("shotsFired")] public WeaponStatInfo ShotsFired { get; set; } = new();
        [JsonProperty("shotsHit")] public WeaponStatInfo ShotsHit { get; set; } = new();
        [JsonProperty("shotsAccuracy")] public WeaponStatInfo ShotsAccuracy { get; set; } = new();
    }
}
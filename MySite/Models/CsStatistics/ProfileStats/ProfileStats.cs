using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileStats
    {
        [JsonProperty("timePlayed")] public ProfileStatInfo TimePlayed { get; set; }
        [JsonProperty("score")] public ProfileStatInfo Score { get; set; }
        [JsonProperty("kills")] public ProfileStatInfo Kills { get; set; }
        [JsonProperty("deaths")] public ProfileStatInfo Deaths { get; set; }
        [JsonProperty("kd")] public ProfileStatInfo Kd { get; set; }
        [JsonProperty("damage")] public ProfileStatInfo Damage { get; set; }
        [JsonProperty("headshots")] public ProfileStatInfo Headshots { get; set; }
        [JsonProperty("dominations")] public ProfileStatInfo Dominations { get; set; }
        [JsonProperty("shotsFired")] public ProfileStatInfo ShotsFired { get; set; }
        [JsonProperty("shotsHit")] public ProfileStatInfo ShotsHit { get; set; }
        [JsonProperty("shotsAccuracy")] public ProfileStatInfo ShotsAccuracy { get; set; }
        [JsonProperty("snipersKilled")] public ProfileStatInfo SnipersKilled { get; set; }
        [JsonProperty("dominationOverkills")] public ProfileStatInfo DominationOverkills { get; set; }
        [JsonProperty("dominationRevenges")] public ProfileStatInfo DominationRevenges { get; set; }
        [JsonProperty("bombsPlanted")] public ProfileStatInfo BombsPlanted { get; set; }
        [JsonProperty("bombsDefused")] public ProfileStatInfo BombsDefused { get; set; }
        [JsonProperty("moneyEarned")] public ProfileStatInfo MoneyEarned { get; set; }
        [JsonProperty("hostagesRescued")] public ProfileStatInfo HostagesRescued { get; set; }
        [JsonProperty("mvp")] public ProfileStatInfo Mvp { get; set; }
        [JsonProperty("wins")] public ProfileStatInfo Wins { get; set; }
        [JsonProperty("ties")] public ProfileStatInfo Ties { get; set; }
        [JsonProperty("matchesPlayed")] public ProfileStatInfo MatchesPlayed { get; set; }
        [JsonProperty("losses")] public ProfileStatInfo Losses { get; set; }
        [JsonProperty("roundsPlayed")] public ProfileStatInfo RoundsPlayed { get; set; }
        [JsonProperty("roundsWon")] public ProfileStatInfo RoundsWon { get; set; }
        [JsonProperty("wlPercentage")] public ProfileStatInfo WlPercentage { get; set; }
        [JsonProperty("headshotPct")] public ProfileStatInfo HeadshotPct { get; set; }
    }
}
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.ProfileStats
{
    public class ProfileStats
    {
        [JsonProperty("timePlayed")]
        public ProfileStatInfo TimePlayed { get; set; } = new();

        [JsonProperty("score")]
        public ProfileStatInfo Score { get; set; } = new();

        [JsonProperty("kills")]
        public ProfileStatInfo Kills { get; set; } = new();

        [JsonProperty("deaths")]
        public ProfileStatInfo Deaths { get; set; } = new();

        [JsonProperty("kd")]
        public ProfileStatInfo Kd { get; set; } = new();

        [JsonProperty("damage")]
        public ProfileStatInfo Damage { get; set; } = new();

        [JsonProperty("headshots")]
        public ProfileStatInfo Headshots { get; set; } = new();

        [JsonProperty("dominations")]
        public ProfileStatInfo Dominations { get; set; } = new();

        [JsonProperty("shotsFired")]
        public ProfileStatInfo ShotsFired { get; set; } = new();

        [JsonProperty("shotsHit")]
        public ProfileStatInfo ShotsHit { get; set; } = new();

        [JsonProperty("shotsAccuracy")]
        public ProfileStatInfo ShotsAccuracy { get; set; } = new();

        [JsonProperty("snipersKilled")]
        public ProfileStatInfo SnipersKilled { get; set; } = new();

        [JsonProperty("dominationOverkills")]
        public ProfileStatInfo DominationOverkills { get; set; } = new();

        [JsonProperty("dominationRevenges")]
        public ProfileStatInfo DominationRevenges { get; set; } = new();

        [JsonProperty("bombsPlanted")]
        public ProfileStatInfo BombsPlanted { get; set; } = new();

        [JsonProperty("bombsDefused")]
        public ProfileStatInfo BombsDefused { get; set; } = new();

        [JsonProperty("moneyEarned")]
        public ProfileStatInfo MoneyEarned { get; set; } = new();

        [JsonProperty("hostagesRescued")]
        public ProfileStatInfo HostagesRescued { get; set; } = new();

        [JsonProperty("mvp")]
        public ProfileStatInfo Mvp { get; set; } = new();

        [JsonProperty("wins")]
        public ProfileStatInfo Wins { get; set; } = new();

        [JsonProperty("ties")]
        public ProfileStatInfo Ties { get; set; } = new();

        [JsonProperty("matchesPlayed")]
        public ProfileStatInfo MatchesPlayed { get; set; } = new();

        [JsonProperty("losses")]
        public ProfileStatInfo Losses { get; set; } = new();

        [JsonProperty("roundsPlayed")]
        public ProfileStatInfo RoundsPlayed { get; set; } = new();

        [JsonProperty("roundsWon")]
        public ProfileStatInfo RoundsWon { get; set; } = new();

        [JsonProperty("wlPercentage")]
        public ProfileStatInfo WlPercentage { get; set; } = new();

        [JsonProperty("headshotPct")]
        public ProfileStatInfo HeadshotPct { get; set; } = new();
    }
}
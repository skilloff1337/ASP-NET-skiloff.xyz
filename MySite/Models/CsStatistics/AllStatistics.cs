using MySite.Models.CsStatistics.MapsStats;
using MySite.Models.CsStatistics.ProfileStats;
using MySite.Models.CsStatistics.WeaponsStats;

namespace MySite.Models.CsStatistics
{
    public class AllStatistics
    {
        public Maps Map { get; set; }
        public Profile Profile { get; set; }
        public Weapon Weapon { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySite.Models.CsStatistics.WeaponsStats
{
    public class Weapon
    {
        [JsonProperty("data")] public List<WeaponData> Data { get; set; }
    }
}
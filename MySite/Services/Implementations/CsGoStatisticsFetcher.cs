using System;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySite.Models.CsStatistics;
using MySite.Models.CsStatistics.MapsStats;
using MySite.Models.CsStatistics.ProfileStats;
using MySite.Models.CsStatistics.WeaponsStats;
using Newtonsoft.Json;

namespace MySite.Services.Implementations
{
    internal class CsGoStatisticsFetcher : ICsGoStatisticsFetcher
    {
        private readonly ILogger<CsGoStatisticsFetcher> _logger;
        private readonly string _csgoUrl;
        private readonly string _csgoMapUrl;
        private readonly string _csgoWeaponUrl;
        private readonly string _csgoApiKey;

        public CsGoStatisticsFetcher(ILogger<CsGoStatisticsFetcher> logger, IConfiguration conf)
        {
            _logger = logger;
            _csgoUrl = conf["URL_CSGO"];
            _csgoMapUrl = conf["URL_CSGO_MAP"];
            _csgoWeaponUrl = conf["URL_CSGO_WEAPON"];
            _csgoApiKey = conf["API_KEY"];
        }

        public async Task<AllStatistics> GetAllStatistics()
        {
            try
            {
                var result = new AllStatistics()
                {
                    Map = await GetMapsStats(),
                    Profile = await GetProfileStats(),
                    Weapon = await GetWeaponsStats()
                };
                var data = JsonConvert.SerializeObject(result,Formatting.Indented);
                await File.WriteAllTextAsync(AppContext.BaseDirectory + "Stats.json",data);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _logger.LogError(1, e, "Error while getting data!");
                
                var text = await File.ReadAllTextAsync(AppContext.BaseDirectory + "Stats.json");
                return JsonConvert.DeserializeObject<AllStatistics>(text);
            }
        }

        private async Task<Weapon> GetWeaponsStats()
        {
            var request = (HttpWebRequest) WebRequest.Create(_csgoWeaponUrl);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key", _csgoApiKey);

            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);

            return JsonConvert.DeserializeObject<Weapon>(await reader.ReadToEndAsync());
        }

        private async Task<Profile> GetProfileStats()
        {
            var request = (HttpWebRequest) WebRequest.Create(_csgoUrl);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key", _csgoApiKey);

            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);

            return JsonConvert.DeserializeObject<Profile>(await reader.ReadToEndAsync());
        }

        private async Task<Maps> GetMapsStats()
        {
            var request = (HttpWebRequest) WebRequest.Create(_csgoMapUrl);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key", _csgoApiKey);

            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);

            return JsonConvert.DeserializeObject<Maps>(await reader.ReadToEndAsync());
        }

    }
}
using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.Extensions.Logging;
using MySite.Controllers;
using MySite.Models.CsStatistics;
using MySite.Models.CsStatistics.MapsStats;
using MySite.Models.CsStatistics.ProfileStats;
using MySite.Models.CsStatistics.WeaponsStats;
using MySite.Models.Interfaces;
using Newtonsoft.Json;

namespace MySite.Models
{
    public class RequestCsGo : IRequestCsGo
    {
        public DateTime NextRequest { get; set; }
        private AllStatistics CurrentCsGoData { get; set; }

        private const string URL_CSGO = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731";
        private const string URL_CSGO_MAP = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731/segments/map";
        private const string URL_CSGO_WEAPON = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731/segments/weapon";
        private const string API_KEY = "85712843-4298-4e80-9f07-f2c2628f47cf";

        private readonly ILogger<RequestCsGo> _logger;

        public RequestCsGo(ILogger<RequestCsGo> logger)
        {
            _logger = logger;
            NextRequest = DateTime.Now.AddHours(1);
            CurrentCsGoData = GetAllStatistics();
        }

        public AllStatistics GetData()
        {
            TimeForNewRequest();
            return CurrentCsGoData;
        }

        private void TimeForNewRequest()
        {
            if (NextRequest > DateTime.Now) 
                return;
            
            CurrentCsGoData = GetAllStatistics();
            NextRequest = DateTime.Now.AddHours(1);
        }

        private AllStatistics GetAllStatistics()
        {
            try
            {
                var result = new AllStatistics()
                {
                    Map = GetMapsStats(),
                    Profile = GetProfileStats(),
                    Weapon = GetWeaponsStats()
                };
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _logger.LogError(1,e,"Error while getting data!");
                throw;
            }
        }

        private Weapon GetWeaponsStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO_WEAPON);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Weapon>(reader.ReadToEnd());
        }

        private Profile GetProfileStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Profile>(reader.ReadToEnd());
        }

        private Maps GetMapsStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO_MAP);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Maps>(reader.ReadToEnd());
        }
    }
}
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ApexLegendsApp.Model;
using ApexLegendsApp.ViewModels;
using Newtonsoft.Json;

namespace ApexLegendsApp.Services
{
    public class GameDataApiService : IGameDataAPIService
    {
        private const string AssaultRifles = "assault_rifles";
        private const string Consumables = "consumables";

        private HttpClient _httpClient = new HttpClient();

        public async Task<List<Weapon>> GetAssaultRifles()
        {
            var url = GetUrl(AssaultRifles, Keys.ApiKey);
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Weapon>>(response);
        }

        public async Task<List<Consumables>> GetConsumables()
        {
            var url = GetUrl(Consumables, Keys.ApiKey);
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Consumables>>(response);
        }

        private string GetUrl(string type, string apiKey) => Keys.GameDataApi
            .Replace("{DATATYPE}", type)
            .Replace("{YOURAPIKEY}", Keys.ApiKey);        
    }
}
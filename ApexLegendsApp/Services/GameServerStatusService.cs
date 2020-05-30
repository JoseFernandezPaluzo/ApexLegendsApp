using ApexLegendsApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApexLegendsApp.Services
{
    public class GameServerStatusService : IGameServerStatusService
    {
        private HttpClient _httpClient = new HttpClient();
        public async Task<List<Server>> GetServerStatus()
        {
            var json = await _httpClient.GetStringAsync(Keys.ServerStatusApi);
            return JsonConvert.DeserializeObject<List<Server>>(json);
        }
    }
}

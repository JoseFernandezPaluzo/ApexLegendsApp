using ApexLegendsApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApexLegendsApp.Services
{
    public interface IGameServerStatusService
    {
        Task<List<Server>> GetServerStatus();
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using ApexLegendsApp.Model;

namespace ApexLegendsApp.Services
{
    public interface IGameDataAPIService
    {
        Task<List<Weapon>> GetAssaultRifles();
        Task<List<Consumables>> GetConsumables();
    }
}
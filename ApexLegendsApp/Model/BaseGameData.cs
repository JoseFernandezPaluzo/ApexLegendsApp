using Newtonsoft.Json;

namespace ApexLegendsApp.Model
{
    public abstract class BaseGameData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        //CONSUMABLES
        [JsonProperty("cast_time")]
        public int CastTime { get; set; }

        [JsonProperty("stack_size")]
        public int StackSize { get; set; }
    }
}
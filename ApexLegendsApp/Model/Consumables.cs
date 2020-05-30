using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.Model
{
    public class Consumables : BaseGameData
    {
        [JsonProperty("heals")]
        public int Heals { get; set; }
        [JsonProperty("restores")]
        public int Restores { get; set; }
        [JsonProperty("ultimate")]
        public int Ultimate { get; set; }

        public override string ToString()
            => Name;
    }
}

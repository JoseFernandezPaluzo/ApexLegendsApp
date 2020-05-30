using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.Model
{
    public class GeoLocation 
    {
        [JsonProperty("")]
        public object Location { get; set; }
        public ServerStatus ServerS { get; set; }
    }
}

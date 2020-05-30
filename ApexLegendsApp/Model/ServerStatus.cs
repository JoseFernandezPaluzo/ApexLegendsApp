using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.Model
{
    public class ServerStatus 
    {   
        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("HTTPCode")]
        public int HTTPCode { get; set; }

        [JsonProperty("ResponseTime")]
        public int ResponseTime { get; set; }

        [JsonProperty("QueryTimesTamp")]
        public int QueryTimesTamp { get; set; }
               
    }
}

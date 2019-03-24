using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCC.App.Models
{
    public class CurrencyListModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("terms")]
        public Uri Terms { get; set; }

        [JsonProperty("privacy")]
        public Uri Privacy { get; set; }

        [JsonProperty("currencies")]
        public Dictionary<string, string> Currencies { get; set; }
    }
}

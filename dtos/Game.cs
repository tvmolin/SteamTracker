using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamTracker.dtos
{
    class Game
    {
        [JsonProperty("appid")]
        public int appid { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("likelihoodToPlay")]
        public float likelihoodToPlay { get; set; }

        [JsonProperty("notes")]
        public string notes { get; set; }

        [JsonProperty("latestUpdated")]
        public DateTime latestUpdated { get; set; }

        [JsonProperty("storePageLink")]
        public string storePageLink { get; set; }
    }
}

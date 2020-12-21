using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamTracker.dtos
{
    class GamesListResponse
    {
        [JsonProperty("game_count")]
        public int game_count { get; set; }

        [JsonProperty("games")]
        public List<Game> games { get; set; }
    }
}

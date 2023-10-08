using Newtonsoft.Json;

namespace PDex.Domain.Entities
{
    public class PokemonStats
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        [JsonProperty("Sp. Attack")]
        public int SpAttack { get; set; }

        [JsonProperty("Sp. Defense")]
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    }
}

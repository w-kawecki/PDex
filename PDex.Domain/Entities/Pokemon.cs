using Newtonsoft.Json;

namespace PDex.Domain.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }

        [JsonProperty("id")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public PokemonName Name { get; set; } = default!;

        [JsonProperty("base")]
        public PokemonStats Stats { get; set; } = default!;

        [JsonProperty("type")]
        public string[] Type { get; set; } = default!;

        public string EncodedName { get; set; } = default!;

        public void EncodeName() => EncodedName = Name.English.ToLower().Replace(" ", "-");
    }
}

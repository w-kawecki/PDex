namespace PDex.Domain.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public PokemonStats Stats { get; set; } = default!;
        public PokemonType Type { get; set; } = default!;
        public PokemonType Weaknesses { get; set; } = default!;
        public string EncodedName { get; set; } = default!;

        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");
    }
}

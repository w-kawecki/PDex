namespace PDex.Domain.Entities
{
    public class PokemonName
    {
        public string English { get; set; } = default!;
        public string? Japanese { get; set; }
        public string? Chinese { get; set; }
        public string? French { get; set; }
    }
}

namespace PDex.Domain.Entities
{
    public enum Type
    {
        Normal, Fire, Water, Grass, Electric, Ice, Fighting, Poison, Ground,
        Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }

    public class PokemonType
    {
        public Type Type { get; set; }
    }
}

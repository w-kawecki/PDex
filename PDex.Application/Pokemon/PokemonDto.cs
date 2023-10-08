namespace PDex.Application.Pokemon
{
    public class PokemonDto
    {
        public int Number { get; set; }
        public string NameEnglish { get; set; } = default!;
        public string? NameJapanese { get; set; }
        public string? NameChinese { get; set; }
        public string? NameFrench { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set;}
        public int Speed { get; set; }
        public string[] Type { get; set; } = default!;
        public string? EncodedName { get; set; }

    }
}

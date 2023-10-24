using System.ComponentModel.DataAnnotations;

namespace PDex.Application.Pokemon
{
    public class PokemonDto
    {
        public int Number { get; set; }

        [Display(Name = "Name")]
        public string NameEnglish { get; set; } = default!;

        [Display(Name = "Name (Japanese)")]
        public string? NameJapanese { get; set; }

        [Display(Name = "Name (Chinese)")]
        public string? NameChinese { get; set; }

        [Display(Name = "Name (French)")]
        public string? NameFrench { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        [Display(Name = "Sp. Attack")]
        public int SpAttack { get; set; }

        [Display(Name = "Sp. Defense")]
        public int SpDefense { get; set;}
        public int Speed { get; set; }
        public string[] Type { get; set; } = default!;
        public string? EncodedName { get; set; }

    }
}

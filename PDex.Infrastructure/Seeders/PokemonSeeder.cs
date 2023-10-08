using Newtonsoft.Json;
using PDex.Domain.Entities;
using PDex.Infrastructure.Persistence;

namespace PDex.Infrastructure.Seeders
{
    public class PokemonSeeder
    {
        private readonly PokemonDbContext _dbContext;

        public PokemonSeeder(PokemonDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {

            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Pokemons.Any())
                {
                    var pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\JSONs\\pokedex.json"));

                    if (pokemons != null && pokemons.Count > 0)
                    {
                        foreach (var pokemon in pokemons)
                        {
                            pokemon.EncodeName();
                            _dbContext.Pokemons.Add(pokemon);
                        }
                    }
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}

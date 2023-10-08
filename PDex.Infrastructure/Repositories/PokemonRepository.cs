using Microsoft.EntityFrameworkCore;
using PDex.Domain.Entities;
using PDex.Domain.Interfaces;
using PDex.Infrastructure.Persistence;

namespace PDex.Infrastructure.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDbContext _dbContext;

        public PokemonRepository(PokemonDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Pokemon>> GetAll()
            => await _dbContext.Pokemons.ToListAsync();
    }
}

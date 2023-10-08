using MediatR;

namespace PDex.Application.Pokemon.Queries.GetAllPokemons
{
    public class GetAllPokemonsQuery : IRequest<IEnumerable<PokemonDto>> { }
}

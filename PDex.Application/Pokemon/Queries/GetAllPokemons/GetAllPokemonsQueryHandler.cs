using AutoMapper;
using MediatR;
using PDex.Domain.Interfaces;

namespace PDex.Application.Pokemon.Queries.GetAllPokemons
{
    public class GetAllPokemonsQueryHandler : IRequestHandler<GetAllPokemonsQuery, IEnumerable<PokemonDto>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public GetAllPokemonsQueryHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PokemonDto>> Handle(GetAllPokemonsQuery request, CancellationToken cancellationToken)
        {
            var pokemons = await _pokemonRepository.GetAll();
            var pokemonsDtos = _mapper.Map<IEnumerable<PokemonDto>>(pokemons);
            return pokemonsDtos;
        }
    }
}

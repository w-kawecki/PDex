using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDex.Application.Pokemon.Queries.GetAllPokemons;

namespace PDex.MVC.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PokemonController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var pokemons = await _mediator.Send(new GetAllPokemonsQuery());
            return View(pokemons);
        }
    }
}

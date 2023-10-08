using Microsoft.Extensions.DependencyInjection;
using PDex.Application.Mappings;
using PDex.Application.Pokemon.Queries.GetAllPokemons;

namespace PDex.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetAllPokemonsQuery)));
            services.AddAutoMapper(typeof(PokemonMappingProfile));
        }
    }
}

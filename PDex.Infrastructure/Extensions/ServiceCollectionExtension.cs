using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PDex.Domain.Interfaces;
using PDex.Infrastructure.Persistence;
using PDex.Infrastructure.Repositories;
using PDex.Infrastructure.Seeders;

namespace PDex.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PokemonDbContext>(options => options
            .UseSqlServer(configuration.GetConnectionString("PDex")));

            services.AddScoped<PokemonSeeder>();
            services.AddScoped<IPokemonRepository, PokemonRepository>();
        }
    }
}

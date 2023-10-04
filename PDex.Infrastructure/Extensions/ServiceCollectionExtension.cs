using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PDex.Infrastructure.Persistence;

namespace PDex.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PokemonDbContext>(options => options
            .UseSqlServer(configuration.GetConnectionString("PDex")));
        }
    }
}

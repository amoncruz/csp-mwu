using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MWU.Infra.Data;

namespace MWU.CrossCutting
{
    public static class InfraContainer
    {
        public static IServiceCollection AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MWUContext>(options => options.UseSqlServer(configuration.GetConnectionString("DB_MWU_TEST")));
            services.AddDbContext<NWAYContext>(options => options.UseNpgsql(configuration.GetConnectionString("DB_NWAY_TEST")));
            return services;
        }
    }
}

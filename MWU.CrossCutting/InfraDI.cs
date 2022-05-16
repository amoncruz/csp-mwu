using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MWU.Infra.Data;

namespace MWU.CrossCutting.Ioc
{
    public static class InfraContainer
    {
        public static IServiceCollection AddInfra(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MWUContext>(options => options.UseSqlServer(configuration.GetConnectionString("DB_MWU")));
            return services;
        }
    }
}

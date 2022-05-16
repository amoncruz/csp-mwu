using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MWU.Application.DI
{
    public static class MapperContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddAutoMapper(new[]
            {
                Assembly.GetExecutingAssembly()
            });
        }
    }
}

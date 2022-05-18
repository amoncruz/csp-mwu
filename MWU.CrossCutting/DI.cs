using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using MWU.Application.Abstractions;
using MWU.Application.Services;
using MWU.Domain.Abstractions.Repositories;
using MWU.Infra.Repositories;

namespace MWU.CrossCutting
{
    public static class DI
    {
        public static IServiceCollection AddIocAndValidators(IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //Services
            services.AddTransient(typeof(IMWU), typeof(MWUService));
            services.AddTransient(typeof(IRegistroEntradaESaida), typeof(RegistroEntradaESaida));
            services.AddTransient(typeof(IDadosIdentificacaoDeMotoristaEDeVeiculo), typeof(DadosIdentificacaoDeMotoristaEDeVeiculo));
            //REPO
            services.AddTransient(typeof(IDadosIdentificacaoDeMotoristaEDeVeiculoRepository), typeof(DadosIdentificacaoDeMotoristaEDeVeiculoRepository));
            services.AddTransient(typeof(IIntegracaoRepository), typeof(IntegracaoRepository));

            return services;
        }
    }
}

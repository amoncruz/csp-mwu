using AutoMapper;
using MWU.Application.DTO.Integracao;
using MWU.Domain.Entities;

namespace MWU.Application.AutoMapper.Profiles
{
    public class IntegracaoMapper : Profile
    {
        public IntegracaoMapper()
        {
            CreateMap<IntegracaoDTO, Integracao>();
            CreateMap<Integracao, IntegracaoDTO>();
        }
    }
}

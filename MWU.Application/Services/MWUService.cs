using AutoMapper;
using MWU.Application.Abstractions;
using MWU.Application.DTO.Integracao;
using MWU.Domain.Abstractions.Repositories;
using MWU.Domain.Entities;
using System.Collections.Generic;

namespace MWU.Application.Services
{
    public class MWUService : IMWU
    {
        private readonly IIntegracaoRepository _integracaoRepository;
        private readonly IMapper _mapper;

        public MWUService(IIntegracaoRepository integracaoRepository, IMapper mapper)
        {
            _integracaoRepository = integracaoRepository;
            _mapper = mapper;
        }

        public void AdicionarIntegracao(IntegracaoDTO IntegracaoDTO)
        {
            var integracao = _mapper.Map<Integracao>(IntegracaoDTO);
            _integracaoRepository.AdicionarIntegracao(integracao);
        }

        public void AtualizarIntegracao(string Nome, IntegracaoDTO IntegracaoDTO)
        {
            var integracao = _mapper.Map<Integracao>(IntegracaoDTO);
            _integracaoRepository.AtualizarIntegracao(Nome, integracao);
        }

        public bool ExcluirIntegracao(string Nome)
        {
            return _integracaoRepository.ExcluirIntegracao(Nome);
        }

        public bool ExecutarImediatamenteIntegracao(string Nome)
        {
            return _integracaoRepository.ExecutarImediatamenteIntegracao(Nome);
        }

        public List<IntegracaoDTO> ListarIntegracao()
        {
            var integracoes = _integracaoRepository.ListarIntegracao();
            return _mapper.Map<List<Integracao>, List<IntegracaoDTO>>(integracoes);
        }

        public bool PausarIntegracao(string Nome)
        {
            return _integracaoRepository.PausarIntegracao(Nome);
        }

        public IntegracaoDTO RetornarIntegracao(string Nome)
        {
            var integracao = _integracaoRepository.RetornarIntegracao(Nome);
            return _mapper.Map<IntegracaoDTO>(integracao);
        }
    }
}

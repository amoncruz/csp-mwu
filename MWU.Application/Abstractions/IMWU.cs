using MWU.Application.DTO.Integracao;
using System.Collections.Generic;

namespace MWU.Application.Abstractions
{
    public interface IMWU
    {
        public void AdicionarIntegracao(IntegracaoDTO Integracao);
        public void AtualizarIntegracao(string Nome, IntegracaoDTO Integracao);
        public List<IntegracaoDTO> ListarIntegracao();
        public bool ExecutarImediatamenteIntegracao(string Nome);
        public bool PausarIntegracao(string Nome);
        public IntegracaoDTO RetornarIntegracao(string Nome);
        public bool ExcluirIntegracao(string Nome);
    }
}

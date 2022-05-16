using MWU.Domain.Entities;
using System.Collections.Generic;

namespace MWU.Domain.Abstractions.Repositories
{
    public interface IIntegracaoRepository
    {
        public void AdicionarIntegracao(Integracao Integracao);
        public void AtualizarIntegracao(string Nome, Integracao Integracao);
        public List<Integracao> ListarIntegracao();
        public bool ExecutarImediatamenteIntegracao(string Nome);
        public bool PausarIntegracao(string Nome);
        public Integracao RetornarIntegracao(string Nome);
        public bool ExcluirIntegracao(string Nome);
    }
}

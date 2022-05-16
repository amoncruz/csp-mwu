using MWU.Application.Models;

namespace MWU.Application.Abstractions
{
    public interface IRegistroEntradaESaida
    {
        public void IntegrarNWAY2MES(MES2NWAY_RegistroEntraESaidaMotoristaEVeiculo mensagem);
        public MES2NWAY_RegistroEntraESaidaMotoristaEVeiculo FormatarMensagem(string mensagem);
        public string GetNomeDoEndPoint();
    }
}

using MWU.Application.Models;

namespace MWU.Application.Abstractions
{
    public interface IDadosIdentificacaoDeMotoristaEDeVeiculo
    {
        public void IntegrarNWAY2MES(NWAY2MES_IdentificacaoVeiculoEMotorista mensagem);
        public NWAY2MES_IdentificacaoVeiculoEMotorista FormatarMensagem(string mensagem);
        public string GetNomeDoEndPoint();

    }
}

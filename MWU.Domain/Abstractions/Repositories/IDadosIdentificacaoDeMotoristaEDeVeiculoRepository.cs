using MWU.Domain.Entities.Procedures;
using System.Collections.Generic;

namespace MWU.Domain.Abstractions.Repositories
{
    public interface IDadosIdentificacaoDeMotoristaEDeVeiculoRepository
    {
        public List<NWAY2MES_IdentificacaoVeiculoEMotorista> ConsultarNWAY_MotoristaEVeiculo();
        public void IntegrarNWAY2MES(NWAY2MES_IdentificacaoVeiculoEMotorista mensagem);
        public NWAY2MES_IdentificacaoVeiculoEMotorista FormatarMensagem(string mensagem);
        public string GetNomeDoEndPoint();
    }
}

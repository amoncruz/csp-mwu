﻿using MWU.Domain.Entities.Procedures;
using System.Collections.Generic;

namespace MWU.Application.Abstractions
{
    public interface IDadosIdentificacaoDeMotoristaEDeVeiculo
    {
        public List<NWAY2MES_IdentificacaoVeiculoEMotorista> ConsultarNWAY_MotoristaEVeiculo();
        public void IntegrarNWAY2MES(NWAY2MES_IdentificacaoVeiculoEMotorista mensagem);
        public NWAY2MES_IdentificacaoVeiculoEMotorista FormatarMensagem(string mensagem);
        public string GetNomeDoEndPoint();
    }
}

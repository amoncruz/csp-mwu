using Microsoft.EntityFrameworkCore;
using MWU.Domain.Abstractions.Repositories;
using MWU.Domain.Entities.Procedures;
using MWU.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MWU.Infra.Repositories
{
    public class DadosIdentificacaoDeMotoristaEDeVeiculoRepository : IDadosIdentificacaoDeMotoristaEDeVeiculoRepository
    {
        private readonly NWAYContext _context;

        public DadosIdentificacaoDeMotoristaEDeVeiculoRepository(NWAYContext context)
        {
            _context = context;
        }

        public List<NWAY2MES_IdentificacaoVeiculoEMotorista> ConsultarNWAY_MotoristaEVeiculo()
        {
            var dadosMotoristaEVeiculo = _context.NWAY2MES_IdentificacaoVeiculoEMotoristas.FromSqlRaw("EXEC sp_SelecionarMotoristasEVeiculosD_1").ToList();

            return dadosMotoristaEVeiculo ?? new List<NWAY2MES_IdentificacaoVeiculoEMotorista>();
        }

        public NWAY2MES_IdentificacaoVeiculoEMotorista FormatarMensagem(string mensagem)
        {
            throw new NotImplementedException();
        }

        public string GetNomeDoEndPoint()
        {
            throw new NotImplementedException();
        }

        public void IntegrarNWAY2MES(NWAY2MES_IdentificacaoVeiculoEMotorista mensagem)
        {
            throw new NotImplementedException();
        }

    }
}

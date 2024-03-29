﻿using MWU.Application.Abstractions;
using MWU.Domain.Abstractions.Repositories;
using MWU.Domain.Entities.Procedures;
using System;
using System.Collections.Generic;

namespace MWU.Application.Services
{
    public class DadosIdentificacaoDeMotoristaEDeVeiculo : IDadosIdentificacaoDeMotoristaEDeVeiculo
    {
        private readonly IDadosIdentificacaoDeMotoristaEDeVeiculoRepository _repository;

        public DadosIdentificacaoDeMotoristaEDeVeiculo(IDadosIdentificacaoDeMotoristaEDeVeiculoRepository repository)
        {
            _repository = repository;
        }

        public List<NWAY2MES_IdentificacaoVeiculoEMotorista> ConsultarNWAY_MotoristaEVeiculo()
        {
            return _repository.ConsultarNWAY_MotoristaEVeiculo();
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

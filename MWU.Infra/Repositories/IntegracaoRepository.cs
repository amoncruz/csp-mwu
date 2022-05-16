using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MWU.Domain.Abstractions.Repositories;
using MWU.Domain.Entities;
using MWU.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MWU.Infra.Repositories
{
    public class IntegracaoRepository : IIntegracaoRepository
    {
        private readonly MWUContext _context;

        public IntegracaoRepository(MWUContext context)
        {
            _context = context;
        }

        public void AdicionarIntegracao(Integracao Integracao)
        {
            try
            {
                var Nome = new SqlParameter("@Nome", Integracao.Nome);
                var EndPoint = new SqlParameter("@EndPoint", Integracao.EndPoint);
                var Periodicidade = new SqlParameter("@Periodicidade", Integracao.Periodicidade);
                var IntervaloEmMin = new SqlParameter("@IntervaloEmMin", Integracao.IntervaloEmMin);
                var DataInicio = new SqlParameter("@Inicio", Integracao.DataInicio);

                _context.Database.ExecuteSqlRaw("EXEC dbo.AdicionarIntegracao @Nome, @EndPoint, @Periodicidade, @IntervaloEmMin, @Inicio", parameters: new[] {  Nome, EndPoint, Periodicidade, IntervaloEmMin, DataInicio });
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AtualizarIntegracao(string Nome, Integracao Integracao)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirIntegracao(string Nome)
        {
            throw new NotImplementedException();
        }

        public bool ExecutarImediatamenteIntegracao(string Nome)
        {
            throw new NotImplementedException();
        }

        public List<Integracao> ListarIntegracao() => _context.Integracoes.ToList();

        public bool PausarIntegracao(string Nome)
        {
            throw new NotImplementedException();
        }

        public Integracao RetornarIntegracao(string Nome)
        {
            throw new NotImplementedException();
        }
    }
}

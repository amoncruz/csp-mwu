using Microsoft.EntityFrameworkCore;
using MWU.Domain.Entities.Procedures;

namespace MWU.Infra.Data
{
    public class NWAYContext : DbContext
    {

        public DbSet<NWAY2MES_IdentificacaoVeiculoEMotorista> NWAY2MES_IdentificacaoVeiculoEMotoristas { get; set; }

        public NWAYContext(DbContextOptions<NWAYContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NWAYContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

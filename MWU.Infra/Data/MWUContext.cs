using Microsoft.EntityFrameworkCore;
using MWU.Domain.Entities;

namespace MWU.Infra.Data
{
    public class MWUContext : DbContext
    {
        public DbSet<Integracao> Integracoes { get; set; }

        public MWUContext(DbContextOptions<MWUContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MWUContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

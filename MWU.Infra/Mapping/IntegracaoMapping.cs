using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MWU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWU.Infra.Mapping
{
    public class IntegracaoMapping : IEntityTypeConfiguration<Integracao>
    {
        public void Configure(EntityTypeBuilder<Integracao> builder)
        {
            builder.ToTable("Integracao");
        }
    }
}

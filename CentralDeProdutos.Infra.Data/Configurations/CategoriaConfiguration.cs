using CentralDeProdutos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Infra.Data.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Descricao).HasMaxLength(500).IsRequired();
            builder.Property(c => c.DataCriacao).IsRequired();
            builder.Property(c => c.UsuarioCriacao).HasMaxLength(100).IsRequired();
            builder.Property(c => c.DataUltimaAlteracao).IsRequired();
            builder.Property(c => c.UsuarioUltimaAlteracao).HasMaxLength(100).IsRequired();
        }
    }
}

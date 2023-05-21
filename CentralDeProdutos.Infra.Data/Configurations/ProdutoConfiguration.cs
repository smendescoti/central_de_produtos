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
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Preco).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.DataCriacao).IsRequired();
            builder.Property(p => p.UsuarioCriacao).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataUltimaAlteracao).IsRequired();
            builder.Property(p => p.UsuarioUltimaAlteracao).HasMaxLength(100).IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

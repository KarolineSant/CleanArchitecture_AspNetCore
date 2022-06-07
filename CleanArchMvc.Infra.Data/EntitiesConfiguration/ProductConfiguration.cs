using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration
{
    // Classe utilizando o recurso de Fluent API para sobreescrever as convenções do EF Core.
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // definindo o Id como chave primária
            builder.HasKey(t => t.Id);

            //definindo o tamanho máximo das propriedades string e colocando como required, uma vez q a convenção do EF Core define string como nvarchar(max) e nullable = true
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            // definindo a precisão do tipo decimal(10,2), uma vez que a convenção do EF Core define como decimal(18,2)
            builder.Property(p => p.Price).HasPrecision(10, 2);

            // definindo a multiplicidade - Uma categoria pode ter muitos produtos. Definindo a chave estrangeira CategoryId.
            builder.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);
        }
    }
}

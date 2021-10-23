﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using quickBuy.dominio.ObjetoDeValor;

namespace quickBuy.repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome).IsRequired().HasMaxLength(50);
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(100);

        }
    }
}

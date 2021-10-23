using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using quickBuy.dominio.Entidades;

namespace quickBuy.repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        //Arquivo de configuração serve para informar para o EF as regras dos campos
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Chave primária
            builder.HasKey(u => u.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);            

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}

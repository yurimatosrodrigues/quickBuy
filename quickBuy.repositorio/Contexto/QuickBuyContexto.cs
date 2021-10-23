using Microsoft.EntityFrameworkCore;
using quickBuy.dominio.Entidades;
using quickBuy.dominio.ObjetoDeValor;
using quickBuy.repositorio.Config;

namespace quickBuy.repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido{ get; set; }
        public DbSet<FormaPagamento> FormaPagamento{ get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder
                .Entity<FormaPagamento>()
                .HasData(new FormaPagamento() { 
                            Id = 1,
                            Nome = "Boleto",
                            Descricao = "Forma de Pagamento por Boleto",
                         },
                         new FormaPagamento()
                         {
                             Id = 2,
                             Nome = "Cartão de Crédito",
                             Descricao = "Forma de Pagamento por Cartão de Crédito",
                         },
                         new FormaPagamento()
                         {
                             Id = 3,
                             Nome = "Depósito",
                             Descricao = "Forma de Pagamento por Depósito",
                         }
                         );            
            base.OnModelCreating(modelBuilder);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using quickBuy.dominio.Entidades;
using quickBuy.dominio.ObjetoDeValor;

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

    }
}

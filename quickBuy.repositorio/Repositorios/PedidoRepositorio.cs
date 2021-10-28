using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;
using quickBuy.repositorio.Contexto;

namespace quickBuy.repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}

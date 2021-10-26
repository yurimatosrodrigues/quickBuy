using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;
using quickBuy.repositorio.Contexto;

namespace quickBuy.repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}

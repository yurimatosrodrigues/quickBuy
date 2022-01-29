using Microsoft.AspNetCore.Mvc;
using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;

namespace quickBuy.web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            this._pedidoRepositorio = pedidoRepositorio;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                _pedidoRepositorio.Adicionar(pedido);
                return Ok(pedido.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());                
            }
        }
    }
}

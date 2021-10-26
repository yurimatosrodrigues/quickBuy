using Microsoft.AspNetCore.Mvc;
using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;
using System;

namespace quickBuy.web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get() {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
                /*if (!condicao) {
                    return BadRequest("");
                }*/
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());             
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto) {
            try
            {                
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

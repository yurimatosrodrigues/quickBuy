using Microsoft.AspNetCore.Mvc;
using quickBuy.dominio.Entidades;

namespace quickBuy.web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario.Email == "teste@teste.com.br" && usuario.Senha == "12345678")
                    return Ok(usuario);
                return BadRequest("Usuário ou senha inválido");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

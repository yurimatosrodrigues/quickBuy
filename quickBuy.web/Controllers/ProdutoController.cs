using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quickBuy.dominio.Contratos;
using quickBuy.dominio.Entidades;
using System;
using System.IO;
using System.Linq;

namespace quickBuy.web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnviroment;

        public ProdutoController(IProdutoRepositorio produtoRepositorio, 
                                 IHttpContextAccessor httpContextAccessor,
                                 IHostingEnvironment hostingEnviroment)
        {
            _produtoRepositorio = produtoRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnviroment = hostingEnviroment;
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
                produto.Validate();
                if (!produto.EValido) {
                    return BadRequest(produto.ObterMensagensValidacao());
                }

                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("EnviarArquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["arquivoEnviado"];
                var nomeArquivo = formFile.FileName;
                var extensao = nomeArquivo.Split(".").Last();                
                var novoNomeArquivo = GerarNovoNomeArquivo(nomeArquivo, extensao);
                var pastaArquivos = _hostingEnviroment.WebRootPath + "\\arquivos\\";
                var nomeCompleto = pastaArquivos + novoNomeArquivo;

                using (var streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo);
                }
                return Json(novoNomeArquivo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        private static string GerarNovoNomeArquivo(string nomeArquivo, string extensao)
        {
            var nomeReduzido = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray();
            var novoNomeArquivo = new string(nomeReduzido).Replace(" ", "-");
            novoNomeArquivo = $"{novoNomeArquivo}_" +
                $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}" +
                $"{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}" + "." + extensao;

            return novoNomeArquivo;
        }
    }
}

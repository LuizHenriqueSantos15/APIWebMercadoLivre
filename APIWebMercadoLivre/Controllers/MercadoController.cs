using APIWebMercadoLivre.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMercadoLivre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MercadoController : ControllerBase
    {
        [HttpGet("api/produtos")]
        public ActionResult GetProdutos()
        {
            using (var context = new MercadoContext())
            {

                var list = context.Produtos.ToList();
                return Ok(list);
            }
        }

        [HttpGet("api/produtos/{produto}")]

        public ActionResult GetProdutoByPesquisa(string produto)
        {
            using (var context = new MercadoContext())
            {
                List<Produto> produtos = new List<Produto>();
                var produtoSplit = produto.Split(" ");
                foreach (var item in produtoSplit)
                {
                  produtos = context.Produtos.Where(x => x.Resumo.Contains(item)).ToList();
                }
                return Ok(produtos);
            }
        }
    }
}

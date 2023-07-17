using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaProdutos;

namespace WebApplication6.Controllers.ConsultaProdutos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaProdutos : Controller
    {

        private readonly ListaProdutosRequest _listaprodutos;
        public ListaProdutos(ListaProdutosRequest listaprodutos)
        {

            _listaprodutos = listaprodutos;

        }

        [HttpGet("ListaProdutos")]
        public async Task<IActionResult> ListaProdutosRequest()
        {
            {

                var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();

                var resultado = await _listaprodutos.ListaProdutos(cnxFilCodHeader, cnxUsnCodHeader);
                return Ok(resultado);
            }
        }
    }
}

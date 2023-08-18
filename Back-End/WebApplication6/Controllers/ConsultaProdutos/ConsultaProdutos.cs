using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaProdutos;

namespace WebApplication6.Controllers.ConsultaProdutos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaProdutosController : Controller
    {
        private readonly ConsultaProdutosRequest _consultaProdutos;
        public ConsultaProdutosController(ConsultaProdutosRequest apiServices)
        {
            _consultaProdutos = apiServices;
        }
        [HttpGet("ConsultaProdutos")]
        public async Task<IActionResult> ConsultaProdutos()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var prdCod = Request.Headers["prdCod"].ToString();

            var resultado = await _consultaProdutos.ConsultaProdutos(cnxFilCodHeader, cnxUsnCodHeader, prdCod);
            return Ok(resultado);
        }
    }
}

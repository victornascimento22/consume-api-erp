using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static WebApplication6.Services.FinanceiroAPagarRequest;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaFinanceiroaPagarController : Controller
    {

        private readonly ConsultaFinanceiroAPagarRequest _consultaFinanceiroAPagar;

        public ConsultaFinanceiroaPagarController(ConsultaFinanceiroAPagarRequest consultafinanceiroapagar)
        {
            _consultaFinanceiroAPagar = consultafinanceiroapagar;
        }

        [HttpGet("ConsultaFinanceiroaPagar")]
        public async Task<IActionResult> ConsultaFinanceiroAPagar()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var refExt = Request.Headers["refExt"].ToString();
            var resultado = await _consultaFinanceiroAPagar.ConsultaFinanceiroAPagar(cnxFilCodHeader, cnxUsnCodHeader, refExt);

            return Ok(resultado);
        }
    }
}

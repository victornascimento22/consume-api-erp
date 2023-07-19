using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static WebApplication6.Services.FinanceiroAReceberRequest;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaFinanceiroaReceberController : Controller
    {

        private readonly ConsultaFinanceiroAReceberRequest _consultaFinanceiroAPagar;

        public ConsultaFinanceiroaReceberController(ConsultaFinanceiroAReceberRequest consultafinanceiroapagar)
        {
            _consultaFinanceiroAPagar = consultafinanceiroapagar;
        }

        [HttpGet("ConsultaFinanceiroAReceber")]
        public async Task<IActionResult> ConsultaFinanceiroAReceber()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var refExt = Request.Headers["refExt"].ToString();
            var resultado = await _consultaFinanceiroAPagar.ConsultaFinanceiroAReceber(cnxFilCodHeader, cnxUsnCodHeader, refExt);

            return Ok(resultado);
        }
    }
}

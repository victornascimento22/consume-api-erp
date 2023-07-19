using Microsoft.AspNetCore.Mvc;
using static WebApplication6.Services.FinanceiroAPagarRequest;
using System.Threading.Tasks;

using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvisoLancamentoController : Controller
    {

        private readonly ConsultaAvisoLancamentoRequest _consultaAvisoLancamento;

        public AvisoLancamentoController(ConsultaAvisoLancamentoRequest consultaAvisoLancamento)
        {
            _consultaAvisoLancamento = consultaAvisoLancamento;
        }

        [HttpGet("ConsultaAvisoLancamento")]
        public async Task<IActionResult> ConsultaAvisoLancamento()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var refExt = Request.Headers["refExt"].ToString();
            var resultado = await _consultaAvisoLancamento.ConsultaAvisoLancamento(cnxFilCodHeader, cnxUsnCodHeader, refExt);

            return Ok(resultado);
        }
    }
}

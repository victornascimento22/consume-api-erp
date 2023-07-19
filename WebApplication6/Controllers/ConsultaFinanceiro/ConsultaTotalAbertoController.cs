using Microsoft.AspNetCore.Mvc;
using static WebApplication6.Services.FinanceiroAPagarRequest;
using System.Threading.Tasks;

using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaTotalAbertoController : Controller
    {

        private readonly ConsultaTotalAbertoRequest _consultaTotalAbertoRequest;

        public ConsultaTotalAbertoController(ConsultaTotalAbertoRequest consultaTotalAbertoRequest)
        {
            _consultaTotalAbertoRequest = consultaTotalAbertoRequest;
        }

        [HttpGet("ConsultaTotalAberto")]
        public async Task<IActionResult> ConsultaTotalAberto()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var refExt = Request.Headers["refExt"].ToString();
            var resultado = await _consultaTotalAbertoRequest.ConsultaTotalAberto(cnxFilCodHeader, cnxUsnCodHeader, refExt);

            return Ok(resultado);
        }
    }
}

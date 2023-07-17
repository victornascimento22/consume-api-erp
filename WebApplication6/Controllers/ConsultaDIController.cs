using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaDIController : ControllerBase
    {
        private readonly ConsultaDIRequest _consultaDI;

        public ConsultaDIController(ConsultaDIRequest consultaDI)
        {
            _consultaDI = consultaDI;
        }

        [HttpGet("ConsultaDI")]
        public async Task<IActionResult> ConsultaDI()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var refExt = Request.Headers["refExt"].ToString();
            var resultado = await _consultaDI.ConsultaDI(cnxFilCodHeader, cnxUsnCodHeader, refExt);

            return Ok(resultado);
        }
    }
}
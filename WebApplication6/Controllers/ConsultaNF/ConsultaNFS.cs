using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers.ConsultaNF
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaNotaSaidaController : ControllerBase
    {
        private readonly ConsultaNFSRequest _consultaNFS;

        public ConsultaNotaSaidaController(ConsultaNFSRequest consultaNFSRequest)
        {

            _consultaNFS = consultaNFSRequest;

        }
        [HttpGet("ConsultaNotaSaida")]
        public async Task<IActionResult> ConsultaNF()
        {
            var refExtHeader = Request.Headers["refExt"].ToString();
            var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var resultado = await _consultaNFS.ConsultaNF(filCodHeader, usnCodHeader, refExtHeader);
            return Ok(resultado);
        }
    }
}

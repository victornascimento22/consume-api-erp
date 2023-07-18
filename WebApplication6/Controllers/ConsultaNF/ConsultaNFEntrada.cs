using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers.ConsultaNF
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaNFEntradaController : ControllerBase
    {
        private readonly ConsultaNFERequest _consultaNFE;

        public ConsultaNFEntradaController(ConsultaNFERequest consultaNFERequest)
        {

            _consultaNFE = consultaNFERequest;

        }
        [HttpGet("ConsultaNotaEntrada")]
        public async Task<IActionResult> ConsultaNF()
        {
            var refExtHeader = Request.Headers["refExt"].ToString();
            var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var resultado = await _consultaNFE.ConsultaNFE(filCodHeader, usnCodHeader, refExtHeader);
            return Ok(resultado);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaBL;

namespace WebApplication6.Controllers.ConsultaBL
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaBLController : ControllerBase
    {
        private readonly ConsultaBLRequest _consultaBLRequest;

        public ConsultaBLController(ConsultaBLRequest consultaBLRequest)
        {
            _consultaBLRequest = consultaBLRequest;

        }

        [HttpGet("ConsultaBL")]
        public async Task<IActionResult> ConsultaBL([FromQuery] DateTime dtaIni, [FromQuery] DateTime dtaFim)
        {

            try
            {
                var refExtHeader = Request.Headers["refExt"].ToString();
                var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
                var resultado = await _consultaBLRequest.ConsultaBL(filCodHeader, usnCodHeader, refExtHeader);

                return Ok(resultado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}

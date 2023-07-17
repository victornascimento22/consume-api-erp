using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaBL;

namespace WebApplication6.Controllers.ConsultaBL
{

    [Route("api/[controller]")]
    [ApiController]
    public class CargaCEController : ControllerBase
    {
        private readonly ConsultaCERequest _consultaCERequest;

        public CargaCEController(ConsultaCERequest consultaCERequest)
        {
            _consultaCERequest = consultaCERequest;


        }

        [HttpGet("CargaCE")]
        public async Task<IActionResult> CargaCE()
        {

            try
            {
                var refExtHeader = Request.Headers["refExt"].ToString();
                var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
                var resultado = await _consultaCERequest.ConsultaCE(filCodHeader, usnCodHeader, refExtHeader);

                return Ok(resultado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }


        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaBL;

namespace WebApplication6.Controllers.ConsultaBL
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaBLContainers : ControllerBase
    {

        private readonly ConsultaBLContainersRequest _consultaBLContainers;

        public ConsultaBLContainers(ConsultaBLContainersRequest consultaBLContainers)
        {
            _consultaBLContainers = consultaBLContainers;
        }

        [HttpGet("ConsultaBLContainers")]
        public async Task<IActionResult> ConsultaContainers()
        {
            try
            {
                var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
                var cntCodHeader = Request.Headers["cntCod"].ToString();

                var resultado = await _consultaBLContainers.ConsultaBL(filCodHeader, usnCodHeader, cntCodHeader);

                return Ok(resultado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }


        }

    }
}

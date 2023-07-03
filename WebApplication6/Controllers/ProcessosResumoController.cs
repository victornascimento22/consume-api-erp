using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    public class ProcessoResumoController : Controller
    {
        private readonly ProcessosResumoRequest _processosResumoRequest;

        public ProcessoResumoController(ProcessosResumoRequest processosResumoRequest)
        {
            _processosResumoRequest = processosResumoRequest; 


        }

        [HttpGet]
        public async Task<IActionResult> ProcessoResumo()
        {
            try
            {
                var refExtHeader = Request.Headers["refExt"].ToString();
                var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
                var resultado = await _processosResumoRequest.ProcessoResumo(filCodHeader, usnCodHeader, refExtHeader);

                return Ok(resultado);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);


            }
        }
    }
}

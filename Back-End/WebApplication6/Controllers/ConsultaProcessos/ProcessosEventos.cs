using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services.ConsultaProcesso;

namespace WebApplication6.Controllers.ConsultaProcessos
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoEventosController : ControllerBase
    {
        private readonly ProcessoEventosRequest _processoEventosRequest;

        public ProcessoEventosController(ProcessoEventosRequest processoEventosRequest)
        {
            _processoEventosRequest = processoEventosRequest;
        }

        [HttpGet("ProcessoEventos")]
        public async Task<IActionResult> ProcessoEventos(string filCod, string usnCod, string refExt)
        {
            try
            {
                var refExtHeader = Request.Headers["refExt"].ToString();
                var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
                var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
                var result = await _processoEventosRequest.ProcessoEvento(filCodHeader, usnCodHeader, refExtHeader);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Lidar com outros erros e exceções
                return StatusCode(500, "Ocorreu um erro durante a requisição");
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers.ConsultaNF
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaItensNotaSaidaController : Controller
    {
        private readonly ConsultaItensNFRequest _consultaItensNF;
        
        public ConsultaItensNotaSaidaController(ConsultaItensNFRequest consultaItens)
        {

            _consultaItensNF = consultaItens;

        }
        [HttpGet("ConsultaItensNf")]
        public async Task<IActionResult> ConsultaItensNF()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var docCodHeader = Request.Headers["docCod"].ToString();

            var resultado = await _consultaItensNF.ConsultaItensNF(cnxFilCodHeader, cnxUsnCodHeader, docCodHeader);
            return Ok(resultado);
            
        }
    }
}

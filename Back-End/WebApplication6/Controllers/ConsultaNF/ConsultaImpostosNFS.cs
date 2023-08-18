using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaImpostosNFSController : Controller
    {
        private readonly ConsultaImpostosNFRequest _consultaImpostosNF;

        public ConsultaImpostosNFSController(ConsultaImpostosNFRequest consultaImpostos)
        {

            _consultaImpostosNF = consultaImpostos;

        }
        [HttpGet("ConsultaImpostos")]
        public async Task<IActionResult> ConsultaImposto()
        {
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var docCodHeader = Request.Headers["docCod"].ToString();

            var resultado = await _consultaImpostosNF.ConsultaImpostosNF(cnxFilCodHeader, cnxUsnCodHeader, docCodHeader);
            return Ok(resultado);

        }
    }
}
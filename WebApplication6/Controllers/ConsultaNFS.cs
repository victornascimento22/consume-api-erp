using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaNFS : Controller
    {
        private readonly ConsultaNFSRequest _consultaNFS;

        public ConsultaNFS(ConsultaNFSRequest consultaNFSRequest)
        {

            _consultaNFS = consultaNFSRequest;

        }
        [HttpGet("ConsultaNF")]
        public async Task<IActionResult> ConsultaNF() 
        {
            var refExtHeader = Request.Headers["refExt"].ToString();
            var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var resultado = await _consultaNFS.ConsultaNF(filCodHeader, usnCodHeader, refExtHeader);
            return Ok();
        }
    }
}

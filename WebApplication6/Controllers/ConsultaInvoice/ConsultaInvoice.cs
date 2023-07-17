using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaInvoice;

namespace WebApplication6.Controllers.ConsultaInvoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaInvoiceController : Controller
    {
        private readonly ConsultaInvoiceRequest _consultaInvoice;

        public ConsultaInvoiceController(ConsultaInvoiceRequest consultaInvoice)
        {

            _consultaInvoice = consultaInvoice;


        }
        [HttpGet("ConsultaInvoice")]
        public async Task<IActionResult> ConsultaInvoice()
        {
            var refExtHeader = Request.Headers["refExt"].ToString();
            var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();
            var resultado = await _consultaInvoice.ConsultaInvoice(filCodHeader, usnCodHeader, refExtHeader);
            return Ok(resultado);
        }
    }
}

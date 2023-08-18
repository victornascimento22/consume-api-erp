using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication6.Services.ConsultaInvoice;

namespace WebApplication6.Controllers.ConsultaInvoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaItensInvoiceController : Controller
    {

        private readonly ConsultaItensInvoiceRequest _consultaItensInvoice;

        public ConsultaItensInvoiceController(ConsultaItensInvoiceRequest consultaItensInvoice)
        {

            _consultaItensInvoice = consultaItensInvoice;

        }
        [HttpGet("ConsultaItensInvoice")]
        public async Task<IActionResult> ConsultaItensInvoice()
        {
            var invEspNumeroHeader = Request.Headers["invEspNumero"].ToString();
            var filCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var usnCodHeader = Request.Headers["CNXUSN-COD"].ToString();

            var resultado = await _consultaItensInvoice.ConsultaItensInvoice(filCodHeader, usnCodHeader, invEspNumeroHeader);
            return Ok(resultado);
        }
    }
}

using System.Collections.Generic;
using WebApplication6.DTO.ConsultaBL;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.ConsultaInvoice
{
    public class CnxListResponseInvoiceDTO
    {
        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<InvoiceDTO> Rows { get; set; }
    }
}

using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.ConsultaInvoice
{
    public class CnxListResponseItensInvoiceDTO
    {

        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ItensInvoiceDTO> Rows { get; set; }
    }
}

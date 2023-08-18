using System.Collections.Generic;
using WebApplication6.DTO.ConsultaBL;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.ConsultaDIDTO
{
    public class CnxListResponseDIDTO
    {

        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ConsultaDI> Rows { get; set; }
    }
}


using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.ProcessoEventosDTO
{
    public class CnxListResponseProcessoEventoDTO
    {
        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ProcessoEventoDTO> Rows { get; set; }
    }
}

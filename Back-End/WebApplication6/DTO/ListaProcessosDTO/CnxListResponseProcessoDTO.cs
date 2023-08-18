using System;
using System.Collections.Generic;

namespace WebApplication6.DTO.ListaProcessosDTO
{
    public class CnxListResponseProcessoDTO
    {
        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ListaProcessoDTO> Rows { get; set; }
    }




}

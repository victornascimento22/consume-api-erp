using System;
using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;
using WebApplication6.DTO.ProcessoEventosDTO;

namespace WebApplication6.DTO.ConsultaBL
{
    public class CnxListResponseConhecimentoContainersDTO
    {
        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ContainersDTO> Rows { get; set; }
    }


}

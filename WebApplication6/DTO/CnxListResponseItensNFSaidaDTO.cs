using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO
{
    public class CnxListResponseItensNFSaidaDTO
    {

        public int count { get; set; }
        public int pageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<NumeroNfSaidaDTO> rows { get; set; }
    }
}

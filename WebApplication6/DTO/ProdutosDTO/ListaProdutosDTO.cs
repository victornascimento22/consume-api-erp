using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.Produtos
{

    public class CnxListResponseProdutoDTO
    {
        public long Count { get; set; }
        public long PageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ProdutoDTO> Rows { get; set; }
    }

    public class ProdutoDTO
    {
        public long PrdCod { get; set; }
        public long PthCod { get; set; }
        public string PrdDesNome { get; set; }
        public string PrdVldSituacao { get; set; }
    }
}

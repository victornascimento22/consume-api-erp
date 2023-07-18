using Newtonsoft.Json;
using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO
{
    public class ProdutoImpostoNfSaidaDTO
    {
        [JsonProperty("prdCod")]
        public long PrdCod { get; set; }

        [JsonProperty("impostos")]
        public List<ImpostosNfSaidaDTO> Impostos { get; set; }
    }

    public class ImpostosNfSaidaDTO
    {
        [JsonProperty("dtrNumOrdem")]
        public int? DtrNumOrdem { get; set; }

        [JsonProperty("impDesNome")]
        public string? ImpDesNome { get; set; }

        [JsonProperty("dtrPctAliquota")]
        public decimal? DtrPctAliquota { get; set; }

        [JsonProperty("dtrMnyValormn")]
        public decimal? DtrMnyValormn { get; set; }

        [JsonProperty("dtrMnyValorDolar")]
        public decimal? DtrMnyValorDolar { get; set; }
    }

    public class CnxListResponseProdutoImpostoNfSaidaDTO
    {
        public int? count { get; set; }
        public int? pageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<ProdutoImpostoNfSaidaDTO> Rows { get; set; }
    }
}

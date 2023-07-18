using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication6.DTO
{
    public class ItensNfSaidaDTO
    {
        [JsonProperty("prdCod")]
        public long? PrdCod { get; set; }

        [JsonProperty("tpcDesNome")]
        public string? TpcDesNome { get; set; }

        [JsonProperty("cfoEspCod")]
        public string? CfoEspCod { get; set; }

        [JsonProperty("undDesNome")]
        public string? UndDesNome { get; set; }

        [JsonProperty("dprQtdQuantidade")]
        public decimal? DprQtdQuantidade { get; set; }

        [JsonProperty("prjCod")]
        public long? PrjCod { get; set; }

        [JsonProperty("ctpDesNome")]
        public string? CtpDesNome { get; set; }

        [JsonProperty("ccuDesNome")]
        public string? CcuDesNome { get; set; }

        [JsonProperty("ungDesNome")]
        public string? UngDesNome { get; set; }

        [JsonProperty("prdDesNome")]
        public string? PrdDesNome { get; set; }

        [JsonProperty("dprPreValorun")]
        public decimal? DprPreValorun { get; set; }

        [JsonProperty("dprPreTotalbruto")]
        public decimal? DprPreTotalbruto { get; set; }

        [JsonProperty("dprPreTotalLiquido")]
        public decimal? DprPreTotalLiquido { get; set; }
    }

    public class NumeroNfSaidaDTO
    {
        [JsonProperty("docEspNumero")]
        public string? DocEspNumero { get; set; }

        [JsonProperty("itensNfSaidaDTOList")]
        public List<ItensNfSaidaDTO>? ItensNfSaidaDTOList { get; set; }
    }

}

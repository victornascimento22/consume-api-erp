using Newtonsoft.Json;
using System.Collections.Generic;
using WebApplication6.DTO.ListaProcessosDTO;
using WebApplication6.DTO.Produtos;

namespace WebApplication6.DTO
{

    public class CnxListResponseAvisoLancamentosDTO
    {
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("pageNumber")]
        public int pageNumber { get; set; }

        [JsonProperty("summary")]
        public CnxResponseSummaryDTO summary { get; set; }

        [JsonProperty("rows")]
        public List<AvisoLancamentoDTO>? rows { get; set; }
    }

    public class AvisoLancamentoDTO
    {
        [JsonProperty("tnsDatTrasnf")]
        public string? tnsDatTrasnf { get; set; }

        [JsonProperty("tnsMnyValor")]
        public decimal? tnsMnyValor { get; set; }

        [JsonProperty("gerDes")]
        public string? gerDes { get; set; }

        [JsonProperty("projetos")]
        public List<ProjetoDTO>? projetos { get; set; }
    }


    public class ProjetoDTO
    {
        [JsonProperty("prjCod")]
        public long? prjCod { get; set; }

        [JsonProperty("ctpDesNome")]
        public string? ctpDesNome { get; set; }

        [JsonProperty("tsdMnyValor")]
        public decimal? tsdMnyValor { get; set; }

        [JsonProperty("tsdMemComplemento")]
        public string? tsdMemComplemento { get; set; }
    }

}

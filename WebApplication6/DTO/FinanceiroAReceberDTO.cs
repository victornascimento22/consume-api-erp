using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO
{
    public class FinanceiroAReceberDTO
    {
        [JsonProperty]
        public long? docCod { get; set; }
        [JsonProperty]
        public string? docDtaEmissao { get; set; }
        [JsonProperty]
        public string? docDtaMovimento { get; set; }
        [JsonProperty]
        public string gerDes { get; set; }
        [JsonProperty]
        public decimal docMnyValor { get; set; }
        [JsonProperty]
        public decimal mnyPis { get; set; }
        [JsonProperty]
        public decimal mnyCofins { get; set; }
        [JsonProperty]
        public decimal mnyCsll { get; set; }
        [JsonProperty]
        public decimal mnyIrrf { get; set; }
        [JsonProperty]
        public string vldStatus { get; set; }
        [JsonProperty]
        public List<FinanceiroAReceberItensDTO> itens { get; set; }
        public List<FinanceiroAReceberTitulosDTO> titulos { get; set; }
    }
    public class FinanceiroAReceberItensDTO
    {
        [JsonProperty("dprCodSeq")]
        public long? dprCodSeq { get; set; }

        [JsonProperty("dprPreValorun")]
        public decimal? dprPreValorun { get; set; }

        [JsonProperty("prjCod")]
        public long? prjCod { get; set; }

        [JsonProperty("ctpDesNome")]
        public string? ctpDesNome { get; set; }

        [JsonProperty("ccuEspConta")]
        public string? ccuEspConta { get; set; }

        [JsonProperty("ccuDesNome")]
        public string? ccuDesNome { get; set; }

        [JsonProperty("priCodProd")]
        public long? priCodProd { get; set; }

        [JsonProperty("ungDesNome")]
        public string? ungDesNome { get; set; }
    }

    public class FinanceiroAReceberTitulosDTO
    {
        [JsonProperty("titEspNum")]
        public string? titEspNum { get; set; }

        [JsonProperty("titDtaVenc")]
        public string? titDtaVenc { get; set; }

        [JsonProperty("titMnyTotPag")]
        public decimal? titMnyTotPag { get; set; }
    }

    public class CnxListResponseFinanceiroAReceberDTO
    {
        [JsonProperty("count")]
        public long count { get; set; }

        [JsonProperty("pageNumber")]
        public long pageNumber { get; set; }

        [JsonProperty("summary")]
        public CnxResponseSummaryDTO summary { get; set; }

        [JsonProperty("rows")]
        public List<FinanceiroAReceberDTO>? rows { get; set; }
    }


}

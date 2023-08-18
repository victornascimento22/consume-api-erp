using System.Collections.Generic;
using System;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.FinanceiroDTO
{
    public class FinanceiroAPagDTO
    {
        public long? docCod { get; set; }
        public string docDtaEmissao { get; set; }
        public string docDtaMovimento { get; set; }
        public string gerDes { get; set; }
        public decimal? docMnyValor { get; set; }
        public decimal? mnyPis { get; set; }
        public decimal? mnyCofins { get; set; }
        public decimal? mnyCsll { get; set; }
        public decimal? mnyIrrf { get; set; }
        public string vldStatus { get; set; }
        public List<FinanceiroAPagarItensDTO> itens { get; set; }
        public List<FinanceiroAPagarTitulosDTO> titulos { get; set; }
    }

    public class FinanceiroAPagarItensDTO
    {
        public long? dprCodSeq { get; set; }
        public decimal? dprPreValorun { get; set; }
        public long? prjCod { get; set; }
        public string ctpDesNome { get; set; }
        public string ccuEspConta { get; set; }
        public string ccuDesNome { get; set; }
        public long? priCodProd { get; set; }
        public string ungDesNome { get; set; }
    }

    public class FinanceiroAPagarTitulosDTO
    {
        public string titEspNum { get; set; }
        public string titDtaVenc { get; set; }
        public decimal? titMnyTotPag { get; set; }
    }

    public class CnxListResponseFinanceiroAPagarDTO
    {
        public long count { get; set; }
        public long pageNumber { get; set; }
        public CnxResponseSummaryDTO summary { get; set; }
        public List<FinanceiroAPagDTO> rows { get; set; }
    }

}

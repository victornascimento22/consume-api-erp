using System.Collections.Generic;
using System;
using WebApplication6.DTO.ListaProcessosDTO;

namespace WebApplication6.DTO.NFEntradaDTO
{
    public class NotaFiscalEntradaDTO
    {
        public long? docCod { get; set; }
        public string docDtaEmissao { get; set; }
        public string docDtaMovimento { get; set; }
        public string dpeNomPessoa { get; set; }
        public decimal? docMnyValor { get; set; }
        public List<ItensNfEntradaDTO> itensNfEntradaDTOList { get; set; }
    }
    public class ItensNfEntradaDTO
    {
        public long? prdCod { get; set; }
        public decimal? dprFltCustoMedio { get; set; }
        public long? prjCod { get; set; }
        public string ctpDesNome { get; set; }
        public string ccuEspConta { get; set; }
    }

    public class CnxListResponseNumeroNfEntradaDTO
    {
        public int count { get; set; }
        public int pageNumber { get; set; }
        public CnxResponseSummaryDTO Summary { get; set; }
        public List<NotaFiscalEntradaDTO> rows { get; set; }

    }

}

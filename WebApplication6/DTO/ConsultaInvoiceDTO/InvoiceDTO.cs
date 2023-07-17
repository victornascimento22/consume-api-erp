using Newtonsoft.Json;

namespace WebApplication6.DTO.ConsultaInvoice
{
    public class InvoiceDTO
    {
        [JsonProperty("invEspNumero")]
        public string? InvEspNumero { get; set; }

        [JsonProperty("invMnyVlrSeguro")]
        public decimal? InvMnyVlrSeguro { get; set; }

        [JsonProperty("dpeNomPessoaExp")]
        public string? DpeNomPessoaExp { get; set; }

        [JsonProperty("dpeNomPessoaImp")]
        public string? DpeNomPessoaImp { get; set; }

        [JsonProperty("ufEspSiglaExp")]
        public string? UfEspSiglaExp { get; set; }

        [JsonProperty("endDesCidadeExp")]
        public string? EndDesCidadeExp { get; set; }

        [JsonProperty("paDesNomeImp")]
        public string? PaDesNomeImp { get; set; }

        [JsonProperty("ufEspSiglaImp")]
        public string? UfEspSiglaImp { get; set; }

        [JsonProperty("endDesCidadeImp")]
        public string? EndDesCidadeImp { get; set; }

        [JsonProperty("cntEspNumeroHouse")]
        public string? CntEspNumeroHouse { get; set; }

        [JsonProperty("oriDesNomeOri")]
        public string? OriDesNomeOri { get; set; }

        [JsonProperty("oriDesNomeDest")]
        public string? OriDesNomeDest { get; set; }

        [JsonProperty("moeEspNomeSeg")]
        public string? MoeEspNomeSeg { get; set; }

        [JsonProperty("vlrTotalFrt")]
        public decimal? VlrTotalFrt { get; set; }

        [JsonProperty("paCodProcDesc")]
        public string? PaCodProcDesc { get; set; }
    }

}

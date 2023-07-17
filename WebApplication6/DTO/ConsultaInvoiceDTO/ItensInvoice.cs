using Newtonsoft.Json;

namespace WebApplication6.DTO.ConsultaInvoice
{
    public class ItensInvoiceDTO
    {
        [JsonProperty("invCod")]
        public long? InvCod { get; set; }

        [JsonProperty("invEspNumero")]
        public string? InvEspNumero { get; set; }

        [JsonProperty("iniItem")]
        public long? IniItem { get; set; }

        [JsonProperty("iniEspCodExport")]
        public string? IniEspCodExport { get; set; }

        [JsonProperty("prdCod")]
        public long? PrdCod { get; set; }

        [JsonProperty("prdDesNome")]
        public string? PrdDesNome { get; set; }

        [JsonProperty("tecEspCod")]
        public string? TecEspCod { get; set; }

        [JsonProperty("tecEspCodSeq")]
        public string? TecEspCodSeq { get; set; }

        [JsonProperty("undDesNome")]
        public string? UndDesNome { get; set; }

        [JsonProperty("iniQtdQuantidade")]
        public decimal? IniQtdQuantidade { get; set; }

        [JsonProperty("iniPrePesoBruto")]
        public decimal? IniPrePesoBruto { get; set; }

        [JsonProperty("iniPrePesoLiquido")]
        public decimal? IniPrePesoLiquido { get; set; }

        [JsonProperty("iniPreValorun")]
        public decimal? IniPreValorun { get; set; }

        [JsonProperty("vlrIi")]
        public decimal? VlrIi { get; set; }

        [JsonProperty("vlrIpi")]
        public decimal? VlrIpi { get; set; }

        [JsonProperty("vlrPis")]
        public decimal? VlrPis { get; set; }

        [JsonProperty("vlrCofins")]
        public decimal? VlrCofins { get; set; }

        [JsonProperty("listLicCod")]
        public long[]? ListLicCod { get; set; }

        [JsonProperty("dpeNomPessoa")]
        public string? DpeNomPessoa { get; set; }

        [JsonProperty("paDesNome")]
        public string PaDesNome { get; set; }

        [JsonProperty("paDesFabr")]
        public string? PaDesFabr { get; set; }

        [JsonProperty("iniPrePesoBrutoUn")]
        public decimal? IniPrePesoBrutoUn { get; set; }

        [JsonProperty("iniPrePesoLiquidoUn")]
        public decimal? IniPrePesoLiquidoUn { get; set; }

        [JsonProperty("iniPreValortotal")]
        public decimal? IniPreValortotal { get; set; }

        [JsonProperty("vlrLiq")]
        public decimal? VlrLiq { get; set; }

        [JsonProperty("undDesMe")]
        public string? UndDesMe { get; set; }

        [JsonProperty("iniEspDescr")]
        public string? IniEspDescr { get; set; }
    }
}

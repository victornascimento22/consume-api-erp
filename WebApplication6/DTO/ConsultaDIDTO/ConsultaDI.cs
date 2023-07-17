using Newtonsoft.Json;
using System;

namespace WebApplication6.DTO.ConsultaDIDTO
{
    public class ConsultaDI
    {
        [JsonProperty("cdiCodSeq")]
        public long? CdiCodSeq { get; set; }

        [JsonProperty("cdiVldDidsi")]
        public string? CdiVldDidsi { get; set; }

        [JsonProperty("cdiVldTipo")]
        public string? CdiVldTipo { get; set; }

        [JsonProperty("priCod")]
        public long? PriCod { get; set; }

        [JsonProperty("priEspRefcliente")]
        public string? PriEspRefcliente { get; set; }

        [JsonProperty("pesCod")]
        public long? PesCod { get; set; }

        [JsonProperty("dpeNomPessoa")]
        public string? DpeNomPessoa { get; set; }

        [JsonProperty("viaDesNome")]
        public string? ViaDesNome { get; set; }

        [JsonProperty("cdiVldCanal")]
        public string? CdiVldCanal { get; set; }

        [JsonProperty("cdiDtaCi")]
        public string? CdiDtaCi { get; set; }

        [JsonProperty("cdiPrePesoLiquido")]
        public decimal? CdiPrePesoLiquido { get; set; }

        [JsonProperty("cdiDtaRegistro")]
        public string? CdiDtaRegistro { get; set; }

        [JsonProperty("cdiQtdAdicoes")]
        public long? CdiQtdAdicoes { get; set; }

        [JsonProperty("cdiQtdItens")]
        public long? CdiQtdItens { get; set; }

        [JsonProperty("urfDesNomeDes")]
        public string? UrfDesNomeDes { get; set; }

        [JsonProperty("urfDesNomeEnt")]
        public string? UrfDesNomeEnt { get; set; }

        [JsonProperty("rctDesNome")]
        public string? RctDesNome { get; set; }

        [JsonProperty("adicoesDiDTOList")]
        public adicoesDiDTOList[]? AdicoesDiDTOList { get; set; }

        [JsonProperty("itensDiDTOList")]
        public ItensDIDTO[]? ItensDiDTOList { get; set; }
    }
}

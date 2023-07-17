using Newtonsoft.Json;

namespace WebApplication6.DTO.ConsultaDIDTO
{
    public class ItensDIDTO
    {
        [JsonProperty("prdCod")]
        public long? PrdCod { get; set; }

        [JsonProperty("idiPreQuantidade")]
        public decimal? IdiPreQuantidade { get; set; }

        [JsonProperty("idiPrePesoLiquido")]
        public decimal? IdiPrePesoLiquido { get; set; }

        [JsonProperty("idiFltValor")]
        public decimal? IdiFltValor { get; set; }

        [JsonProperty("idiMnyVlrAdicional")]
        public decimal? IdiMnyVlrAdicional { get; set; }

        [JsonProperty("seqItem")]
        public long? SeqItem { get; set; }
    }
}

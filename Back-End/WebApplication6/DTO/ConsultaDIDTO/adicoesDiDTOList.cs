using Newtonsoft.Json;

namespace WebApplication6.DTO.ConsultaDIDTO
{
    public class adicoesDiDTOList
    {
        [JsonProperty("tvaEspDescricao")]
        public string? TvaEspDescricao { get; set; }

        [JsonProperty("adiEspAplicacao")]
        public string? AdiEspAplicacao { get; set; }

        [JsonProperty("tecEspCod")]
        public string? TecEspCod { get; set; }
    }
}

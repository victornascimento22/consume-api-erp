using Newtonsoft.Json;

namespace WebApplication6.DTO
{
    public class ConsultaTotalAbertoDTO
    {
        [JsonProperty]
        public string? PriEspReferencia {get;set;}
        [JsonProperty]
        public decimal? TotalAberto { get;set;}
    }
}

using Newtonsoft.Json;

namespace WebApplication6.DTO.LoginDTO
{
    public class CnxFiliaisDTO
    {
        [JsonProperty("filCod")]
        public int FilCod { get; set; }

        [JsonProperty("filDesNome")]
        public string FilDesNome { get; set; }

        [JsonProperty("filDocFederalFmt")]
        public string FilDocFederalFmt { get; set; }

        [JsonProperty("ufEspSigla")]
        public string UfEspSigla { get; set; }

        [JsonProperty("filVldStatus")]
        public int FilVldStatus { get; set; }
    }
}
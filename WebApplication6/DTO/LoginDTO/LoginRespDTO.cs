using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication6.DTO.LoginDTO
{


    public class LoginRespDTO
    {
        [JsonProperty("usnCod")]
        public int UsnCod { get; set; }

        [JsonProperty("filiais")]
        public List<CnxFiliaisDTO> Filiais { get; set; }

        [JsonProperty("filCodDefault")]
        public int? FilCodDefault { get; set; }

        [JsonProperty("urlLoginRedirect")]
        public string UrlLoginRedirect { get; set; }

        [JsonProperty("messageToUser")]
        public string MessageToUser { get; set; }

        [JsonProperty("erpVersion")]
        public string ErpVersion { get; set; }

        [JsonProperty("vldSistema")]
        public string VldSistema { get; set; }

        [JsonProperty("vldVendedor")]
        public string VldVendedor { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

    }
}

using System.Collections.Generic;

namespace WebApplication6.Model
{
    public class LoginResp
    {
        public int UsnCod { get; set; }
        public List<CnxFiliais> Filiais { get; set; }
        public int? FilCodDefault { get; set; }
        public string UrlLoginRedirect { get; set; }
        public string MessageToUser { get; set; }
        public string ErpVersion { get; set; }
        public string VldSistema { get; set; }
        public string VldVendedor { get; set; }
        public string RedirectTo { get; set; }
    }
}

using System.Collections.Generic;

namespace WebApplication6.DTO.LoginDTO
{
    public class LoginErrorResponse
    {
        public string Type { get; set; }
        public List<SessionInfo> Sessions { get; set; }
    }

    public class SessionInfo
    {
        public string SessionId { get; set; }
        public int UsnCod { get; set; }
        public long SessionLastAccessedTime { get; set; }
        public string Username { get; set; }
        public string RemoteAddress { get; set; }
        public string MachineID { get; set; }
        public string MachineName { get; set; }
        public string MachineUser { get; set; }
    }
}

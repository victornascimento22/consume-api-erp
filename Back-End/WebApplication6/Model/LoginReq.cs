namespace WebApplication6.Model
{
    public class LoginReq
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string MfaToken { get; set; }
        public string SessionToKill { get; set; }
        public string NewPassword { get; set; }
        public string MachineID { get; set; }
        public string MachineName { get; set; }
        public string MachineUser { get; set; }
        public bool KillOtherSessions { get; set; }
        public WebAuthenticationDetails AuthDetails { get; set; }
        public string VldSistema { get; set; }
        public string DeviceToken { get; set; }
        public string NotificationToken { get; set; }
        public string OauthType { get; set; }
        public string OauthCode { get; set; }
        public string[] Certs { get; set; }

        public string SessionData { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;
using WebApplication6.Model;

namespace WebApplication6.DTO.LoginDTO
{
    public class LoginReqDTO
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("mfaToken")]
        public string MfaToken { get; set; }

        [JsonProperty("sessionToKill")]
        public string SessionToKill { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("machineID")]
        public string MachineID { get; set; }

        [JsonProperty("machineName")]
        public string MachineName { get; set; }

        [JsonProperty("machineUser")]
        public string MachineUser { get; set; }

        [JsonProperty("killOtherSessions")]
        public bool KillOtherSessions { get; set; }

        [JsonProperty("authDetails")]
        public WebAuthenticationDetails AuthDetails { get; set; }

        [JsonProperty("vldSistema")]
        public string VldSistema { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("notificationToken")]
        public string NotificationToken { get; set; }

        [JsonProperty("oauthType")]
        public string OauthType { get; set; }

        [JsonProperty("oauthCode")]
        public string OauthCode { get; set; }

        [JsonProperty("certs")]
        public string[] Certs { get; set; }
        [JsonProperty("LoginResp")]
        public LoginRespDTO LoginResp { get; set; }

        [JsonProperty("SessionData")]
        public string SessionData { get; set; }
    }



}


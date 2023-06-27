using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using WebApplication6.DTO.ListaProcessosDTO;
using WebApplication6.DTO.LoginDTO;
using WebApplication6.Repositories;

namespace WebApplication6.Services
{
    public class LoginRequest
    {


        private string GetSidFromResponse(HttpResponseMessage response)
        {
            var httpClientHandler = new HttpClientHandler();
            var cookieContainer = new CookieContainer();
            httpClientHandler.CookieContainer = cookieContainer;
            var cookies1 = cookieContainer.GetCookies(new Uri("https://seu-servidor.com"));

            // Encontra o cookie específico pelo nome
            var sessionCookie = cookies1["session"];

            if (sessionCookie != null)
            {
                // Extrai o valor do ID de sessão do cookie
                var sessionId = sessionCookie.Value;

                // Armazene o valor do ID de sessão em uma variável para uso posterior
                // sessionId pode ser armazenado em uma variável, banco de dados, cache, etc.
            }

            if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
            {
                foreach (var cookie in cookies)
                {
                    var cookieParts = cookie.Split(';');
                    var sidCookie = cookieParts.FirstOrDefault(c => c.Trim().StartsWith("sid="));
                    if (!string.IsNullOrEmpty(sidCookie))
                    {
                        var sidValue = sidCookie.Substring("sid=".Length).Trim();
                        return sidValue;
                    }
                }
            }

            return null;
        }

        private string GetXcnxAuthFromResponse(HttpResponseMessage response)
        {
            if (response.Headers.TryGetValues("X-Cnx-Auth", out var values))
            {
                return values.FirstOrDefault();
            }

            return null;
        }

        public object Login(LoginReqDTO loginReq)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.ConnectionClose = false;

                var viewModel = new
                {
                    username = loginReq.Username,
                    password = loginReq.Password,
                    mfaToken = loginReq.MfaToken,
                    sessionToKill = loginReq.SessionToKill,
                    newPassword = loginReq.NewPassword,
                    machineID = loginReq.MachineID,
                    machineName = loginReq.MachineName,
                    machineUser = loginReq.MachineUser,
                    killOtherSessions = loginReq.KillOtherSessions,
                    authDetails = loginReq.AuthDetails,
                    vldSistema = loginReq.VldSistema,
                    deviceToken = loginReq.DeviceToken,
                    notificationToken = loginReq.NotificationToken,
                    oauthType = loginReq.OauthType,
                    oauthCode = loginReq.OauthCode,
                    certs = loginReq.Certs
                };

                var json = JsonConvert.SerializeObject(viewModel);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = httpClient.PostAsync("https://capital-homologacao.conexos.cloud/api-etl/capital/login", content).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var sidCookie = GetSidFromResponse(response);
                    if (!string.IsNullOrEmpty(sidCookie))
                    {
                        var cookieRepository = new CookieRepository();
                        var cookie = new Cookies
                        {
                            Name = "sid",
                            Value = sidCookie,
                            Domain = "capital-homologacao.conexos.cloud",
                            Path = "/"
                        };

                        if (response.Headers.TryGetValues("Set-Cookie", out var setCookieValues))
                        {
                            var setCookieValue = setCookieValues.FirstOrDefault();
                            if (!string.IsNullOrEmpty(setCookieValue))
                            {
                                var setCookieParts = setCookieValue.Split(';');
                                var cookieValue = setCookieParts[0].Trim().Substring("sid=".Length);
                                var setCookie = new SetCookieHeaderValue(cookieValue);
                            }

                            cookieRepository.saveCookie(cookie);
                        }

                        var xcnxAuth = GetXcnxAuthFromResponse(response);

                        if (!string.IsNullOrEmpty(xcnxAuth))
                        {
                            httpClient.DefaultRequestHeaders.Add("X-Cnx-Auth", xcnxAuth);
                        }

                        var resultado = response.Content.ReadAsStringAsync().Result;
                        var obj = JsonConvert.DeserializeObject<LoginRespDTO>(resultado);
                        return obj;
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        var resultado = response.Content.ReadAsStringAsync().Result;
                        var errorObj = JsonConvert.DeserializeObject<LoginErrorResponse>(resultado);
                        return errorObj;
                    }
                    else
                    {
                        throw new Exception($"Ocorreu um erro: {response.StatusCode}");
                        
                    }
                   
                }
                return null;
            }
        }
    }
}
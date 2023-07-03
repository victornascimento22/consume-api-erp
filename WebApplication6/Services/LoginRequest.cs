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
            var cookies = response.Headers.GetValues("Set-Cookie");

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
                    password = loginReq.Password
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

                        cookieRepository.saveCookie(cookie);

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

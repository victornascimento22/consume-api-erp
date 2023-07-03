using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplication6.DTO.ListaProcessosDTO;
using WebApplication6.Repositories;

namespace WebApplication6.Services
{
    public class ListaProcessos
    {
        private readonly CookieRepository _cookieRepository;

        public ListaProcessos(CookieRepository cookieRepository)
        {
            _cookieRepository = cookieRepository;
        }

        public CnxListResponseProcessoDTO ListagemProcessos(string filCod, string usnCod, DateTime? dtaIni, DateTime? dtaFim)
        {
            if (string.IsNullOrEmpty(filCod) || string.IsNullOrEmpty(usnCod))
            {
                // Retornar uma resposta de erro indicando que as credenciais são inválidas
                throw new ArgumentException("Credenciais inválidas");
            }

            string url;

            if (dtaIni.HasValue && dtaFim.HasValue)
            {
                url = $"https://capital-homologacao.conexos.cloud/api-etl/capital/listaProcessos";
            }
            else
            {
                var dataInicio = DateTime.Now.Date.AddDays(-365);
                var dataFim = DateTime.Now.Date;
                url = $"https://capital-homologacao.conexos.cloud/api-etl/capital/listaProcessos";
            }

            var cookieContainer = new CookieContainer();
            var uri = new Uri("https://capital-homologacao.conexos.cloud");

            var cookieDto = _cookieRepository.RecuperarCookie(); // Recupera o cookie do repositório
            if (cookieDto != null)
            {
                var cookie = new System.Net.Cookie
                {
                    Name = cookieDto.Name,
                    Value = cookieDto.Value,
                    Domain = cookieDto.Domain,
                    Path = cookieDto.Path,
                    Expires = cookieDto.Expires // Certifique-se de que Expires seja do tipo DateTime
                };

                cookieContainer.Add(uri, cookie); // Adiciona o cookie ao CookieContainer

                using (var httpClient = new HttpClient(new HttpClientHandler { CookieContainer = cookieContainer }))
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
                    httpClient.DefaultRequestHeaders.Add("Cnx-filCod", filCod);
                    httpClient.DefaultRequestHeaders.Add("Cnx-usnCod", usnCod);

                    var response = httpClient.GetAsync(url).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var obj = JsonConvert.DeserializeObject<CnxListResponseProcessoDTO>(responseContent);
                        return obj;
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        var unauthorizedResult = responseContent;
                        throw new ArgumentException("Acesso não autorizado");
                    }
                    else
                    {
                        Console.WriteLine($"Ocorreu um erro: {response.StatusCode}");
                        // Outras ações, como registrar o erro, lidar com a falha, etc.
                        return null;
                    }
                }
            }
            else
            {
                // Lidar com o caso em que o cookie não foi encontrado no repositório
                throw new ArgumentException("Cookie não encontrado");
            }
        }
    }
}

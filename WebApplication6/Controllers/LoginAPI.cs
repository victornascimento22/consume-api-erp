using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using WebApplication6.DTO.LoginDTO;
using WebApplication6.Services;
using WebApplication6.View;
using Newtonsoft.Json;
using System.Linq;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginRequest _apiServices;

        public LoginController(LoginRequest apiServices)
        {
            _apiServices = apiServices;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] loginView login)
        {
            var loginReq = new LoginReqDTO
            {
                Username = login.Username,
                Password = login.Password
            };

            var resultado = _apiServices.Login(loginReq);

            if (resultado is LoginRespDTO loginResp)
            {
                // Converto a lista de filiais para o formato esperado
                var filiais = loginResp.Filiais.Select(f => new CnxFiliaisDTO
                {
                    FilCod = f.FilCod,
                    FilDesNome = f.FilDesNome,
                    FilDocFederalFmt = f.FilDocFederalFmt,
                    UfEspSigla = f.UfEspSigla,
                    FilVldStatus = f.FilVldStatus
                }).ToList();

                // Obter a chave secreta JWT do contexto
                

                // Gere o token JWT usando o serviço JwtService
                //var jwtToken = JwtService.GenerateJwtToken(filiais, loginResp.UsnCod);

                //// Definir o valor do cookie como o token JWT
                //Response.Cookies.Append("AuthToken", jwtToken, new Microsoft.AspNetCore.Http.CookieOptions
                //{
                //    Expires = DateTime.Now.AddDays(7),
                //    HttpOnly = true,
                //    Secure = true,
                //    Path = "/"
                //});

                return Ok(loginResp);
            }
            else if (resultado is LoginErrorResponse errorResponse)
            {
                return Unauthorized(errorResponse);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

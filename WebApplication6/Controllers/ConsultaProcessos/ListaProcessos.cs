using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Security.Claims;
using WebApplication6.DTO.LoginDTO;
using WebApplication6.Services.ConsultaProcesso;

namespace WebApplication6.Controllers.ConsultaProcessos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListagemProcessosController : ControllerBase
    {
        private readonly ListaProcessos _apiServices;
        public ListagemProcessosController(ListaProcessos apiServices)
        {
            _apiServices = apiServices;
        }

        [HttpGet("ListaProcessos")]

        public IActionResult ListaProcessos([FromQuery] DateTime dtaIni, [FromQuery] DateTime dtaFim)
        {
            //esse é o token com as informacoes do usuario logado como filiais de acesso e codigo de usuario
            //string jwtToken = Request.Cookies["AuthToken"];

            //// Verificar se o usuário está autenticado
            //if (string.IsNullOrEmpty(jwtToken))
            //{
            //    return Unauthorized();
            //}

            //// Acesso às informações do usuário autenticado
            //var userIdClaim = User.FindFirst("UsuarioCodigo");
            //var filialClaims = User.FindAll("FilialCodigo");

            //if (userIdClaim == null)ListagemProcessos/ListaProcessos
            //{
            //    return BadRequest("Credenciais inválidas");
            //}

            //var userId = userIdClaim.Value;

            //var filialCodigos = filialClaims?.Select(c => c.Value).ToList();

            //// Acesso ao header da solicitação
            //var filialCodigoHeader = Request.Headers["FilialCodigo"].ToString();

            //// Verificar se o header "FilialCodigo" está presente
            //if (!filialCodigos.Contains(filialCodigoHeader))
            //{
            //    return BadRequest("Filial inválida");
            //}

            //// Validar a filial
            //if (!filialCodigos.Contains(filialCodigoHeader))
            //{
            //    return BadRequest("Filial inválida");
            //}

            // Realizar a lógica para obter a lista de processos
            var cnxFilCodHeader = Request.Headers["CNXFIL-COD"].ToString();
            var cnxUsnCodHeader = Request.Headers["CNXUSN-COD"].ToString();

            var resultado = _apiServices.ListagemProcessos(cnxFilCodHeader, cnxUsnCodHeader, dtaIni, dtaFim); // Passando o token de acesso como argumento

            // Retornar a resposta adequada com a lista de processos
            return Ok(resultado);
        }
    }
}
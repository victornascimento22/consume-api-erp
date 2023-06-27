
using System.Security.Claims;
using System.Text;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Collections.Generic;
using WebApplication6.DTO.LoginDTO;

namespace WebApplication6.Services
{
    public static class JwtService
    {
        public static string GenerateJwtToken(List<CnxFiliaisDTO> filiais, int usnCod)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var chave = KEY.Secret;

            var key = Encoding.ASCII.GetBytes(chave.ToString());

            var claims = new List<Claim>
            {
                new Claim("UsuarioCodigo", usnCod.ToString())
            };

            foreach (var filial in filiais)
            {
                claims.Add(new Claim("FilialCodigo", filial.FilCod.ToString()));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1), // Defina a duração desejada para o token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}
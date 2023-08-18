using Dapper;
using System;
using System.Data.SqlClient;
using System.Net;
using WebApplication6.DTO;

namespace WebApplication6.Repositories
{
    public class CookieRepository
    {

        private readonly string _connection = @"Data Source=CPTSC-SI104\SQLEXPRESS;Initial Catalog=apiCT;Integrated Security=True;";

        public bool saveCookie(Cookies cookie)
        {
            try
            {

                var query = @"INSERT INTO Cookies
                            (Name, Value, Domain, Path)
                            VALUES(@name, @value, @domain, @path)";

                using (var connection = new SqlConnection(_connection))
                {

                    var parametros = new
                    {

                        name = cookie.Name,
                        value = cookie.Value,
                        domain = cookie.Domain,
                        path = cookie.Path,
                        //expires = cookie.Expires,
                       
                    };

                    connection.Execute(query, parametros);
                    return true;

                }
            }
            
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public CookiesDTO RecuperarCookie()
        {
            try
            {
                var query = @"SELECT Name, Value, Domain, Path
              FROM Cookies
              WHERE Id = (SELECT MAX(Id) FROM Cookies)";


                using (var connection = new SqlConnection(_connection))
                {
                    
                    return connection.QueryFirstOrDefault<CookiesDTO>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

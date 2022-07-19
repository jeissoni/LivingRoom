using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data.SqlClient;

namespace LivingRoom.Repositoy
{
    public class StringConnectionBuilder
    {
        
        private readonly IConfiguration _configuration;

        public StringConnectionBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ConnectionString() 
        {

            NpgsqlConnectionStringBuilder connectionStringBuilder = new()
            {
                Host = _configuration["Host"],
                Database = _configuration["Database"],
                Username = _configuration["user"],
                Password = _configuration["password"]
            };                     

            return connectionStringBuilder.ConnectionString;
        }
    }
}

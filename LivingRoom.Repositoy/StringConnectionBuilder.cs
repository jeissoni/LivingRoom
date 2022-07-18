using Microsoft.Extensions.Configuration;
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
            SqlConnectionStringBuilder
                connectionStringBuilder = new()
                {
                    DataSource = _configuration["Host"],
                    InitialCatalog = _configuration["Database"],
                    UserID = _configuration["Username"],
                    Password = _configuration["Password"]
                };

            return connectionStringBuilder.ConnectionString;
        }
    }
}

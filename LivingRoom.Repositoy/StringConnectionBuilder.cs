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
                connectionStringBuilder = new();

            connectionStringBuilder.DataSource = _configuration["Host"];
            connectionStringBuilder.InitialCatalog = _configuration["Database"];
            connectionStringBuilder.UserID = _configuration["Username"];
            connectionStringBuilder.Password = _configuration["Password"];

            return connectionStringBuilder.ConnectionString;
        }
    }
}

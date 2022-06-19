using LivingRoom.Repositoy.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LivingRoom.Repositoy
{
    //fabrica de contexto
    public class LivingRoomContextFactory : 
        IDesignTimeDbContextFactory<LivingRoomContext>
    {
        private readonly IConfiguration _configuration;

        public LivingRoomContextFactory(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public LivingRoomContext CreateDbContext(string[] args)
        {
            var OptionBuilder = 
                new DbContextOptionsBuilder<LivingRoomContext>();

            OptionBuilder.UseNpgsql
                ($"Host={_configuration["Host"]};" +
                $"Database={_configuration["Database"]};" +
                $"Username={_configuration["Username"]};" +
                $"Password= {_configuration["Password"]}");

            return new LivingRoomContext(OptionBuilder.Options);    
        }
    }
}

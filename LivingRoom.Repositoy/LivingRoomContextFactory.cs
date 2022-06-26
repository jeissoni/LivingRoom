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

        //private readonly IConfiguration _configuration;
        private readonly StringConnectionBuilder _stringConnectionBuilder;

        public LivingRoomContextFactory(IConfiguration configuration) 
        {
            _stringConnectionBuilder = new StringConnectionBuilder(configuration);
        }
        public LivingRoomContext CreateDbContext(string[] args)
        {
            var OptionBuilder = 
                new DbContextOptionsBuilder<LivingRoomContext>();                       

            OptionBuilder.UseNpgsql(_stringConnectionBuilder.ConnectionString());
                        
            return new LivingRoomContext(OptionBuilder.Options);    
        }
    }
}

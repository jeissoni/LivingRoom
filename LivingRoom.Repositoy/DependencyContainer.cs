using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.DataContext;
using LivingRoom.Repositoy.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace LivingRoom.Repositoy
{
    public static class DependencyContainer
    {

        //para poder inyectar los servicios
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            
            var OptionBuilder =
               new DbContextOptionsBuilder<LivingRoomContext>();

            var connectionString = $"Host={configuration["Host"]};" +
                $"Database={configuration["Database"]};" +
                $"Username={configuration["User"]};" +
                $"Password={configuration["Password"]}";

            services.AddDbContext<LivingRoomContext>(options =>
                        options.UseNpgsql(
                            connectionString)
                            //configuration.GetConnectionString("LivingRoom"))
            );

            services.AddDbContext<LivingRoomContext>(options =>
            options.UseNpgsql(connectionString));

            services.AddScoped<IUsuarioRepository, UserRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            //agregar servicio para poder ler los secretos
            services.AddSingleton(configuration);

            return services;
        }
    }
}

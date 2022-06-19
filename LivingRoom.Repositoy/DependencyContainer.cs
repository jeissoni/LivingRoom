using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.DataContext;
using LivingRoom.Repositoy.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LivingRoom.Repositoy
{
    public static class DependencyContainer
    {
        //para poder inyectar los servicios
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<LivingRoomContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("LivingRoom")));

            services.AddScoped<IUsuarioRepository, UserRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            //agregar servicio para poder ler los secretos
            services.AddSingleton(configuration);

            return services;
        }
    }
}

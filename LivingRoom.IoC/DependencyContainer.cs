using LivingRoom.Presenter;
using LivingRoom.Repositoy;
using LivingRoom.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// clase usada para invertir dependencias
namespace LivingRoom.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddLivingRoomDependencies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenter();
            return services;

        }
    }
}

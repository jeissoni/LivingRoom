using LivingRoom.UseCasesPort;
using Microsoft.Extensions.DependencyInjection;

namespace LivingRoom.Presenter
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenter(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateUserOutPutPort, CreateUserPresenter>();

            services.AddScoped<IGetAllUserOutputPort, GetAllUserPresenter>();

            return services;
        }
    }
}

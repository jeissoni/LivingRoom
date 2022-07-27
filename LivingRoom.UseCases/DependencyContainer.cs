using LivingRoom.UseCases.CreateUser;
using LivingRoom.UseCases.GetAllProducts;
using LivingRoom.UseCasesPort;
using Microsoft.Extensions.DependencyInjection;

namespace LivingRoom.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {

            // cuando me lo pidan regreso la intancia, 
            // por eso se usa 'Transient'

            //en los contexto, durante toda la peticion
            //cuando me pidan  un contexto, regresar el mismo contexto 
            //por  eso se usa como 'Scoped'
            services.AddTransient<ICreateUserInputPort, CreateUserInteractor>();

            services.AddTransient<IGetAllUserInputPort, GetAllUserInteractor>();

            return services;
        }
    }
}

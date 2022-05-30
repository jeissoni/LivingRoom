using LivingRoom.DTOs;

namespace LivingRoom.UseCasesPort
{
    //recibir desde un controlador un DTO 
    //datos de entrada del caso de uso
    public interface ICreateUserInputPort
    {
        Task Handle(CreateUserDTO user);
    }
}

using LivingRoom.DTOs;

namespace LivingRoom.UseCasesPort
{
    //abstraccion para retornar valores 
    public interface ICreateUserOutPutPort
    {
        Task Handle(UserDTO user);
    }
}

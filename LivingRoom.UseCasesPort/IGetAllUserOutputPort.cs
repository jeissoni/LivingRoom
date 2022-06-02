using LivingRoom.DTOs;

namespace LivingRoom.UseCasesPort
{
    public interface IGetAllUserOutputPort
    {
        Task Handle(IEnumerable<UserDTO> userDTOs);
    }
}

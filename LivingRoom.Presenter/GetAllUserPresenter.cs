using LivingRoom.DTOs;
using LivingRoom.UseCasesPort;

namespace LivingRoom.Presenter
{
    public class GetAllUserPresenter : IGetAllUserOutputPort, IPresenter<IEnumerable<UserDTO>>
    {
        public IEnumerable<UserDTO> Content { get; private set; }

        public Task Handle(IEnumerable<UserDTO> userDTOs)
        {
            Content = userDTOs;
            return Task.CompletedTask;
        }
    }
}

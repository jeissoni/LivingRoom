using LivingRoom.DTOs;
using LivingRoom.UseCasesPort;

namespace LivingRoom.Presenter
{
    public class CreateUserPresenter : ICreateUserOutPutPort , IPresenter<UserDTO>
    {
        public UserDTO Content { get; private set; }

        public Task Handle(UserDTO user)
        {
            Content = user;
            return Task.CompletedTask;
        }

    }
}

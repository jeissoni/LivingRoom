using LivingRoom.DTOs;
using LivingRoom.UseCasesPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

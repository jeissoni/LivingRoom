using LivingRoom.DTOs;
using LivingRoom.UseCasesPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

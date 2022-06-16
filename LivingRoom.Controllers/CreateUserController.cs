using LivingRoom.DTOs;
using LivingRoom.Presenter;
using LivingRoom.UseCasesPort;
using Microsoft.AspNetCore.Mvc;

namespace LivingRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateUserController
    {
        readonly ICreateUserInputPort inputPort;
        readonly ICreateUserOutPutPort outPutPort;

        public CreateUserController(
            ICreateUserInputPort _inputPort,
            ICreateUserOutPutPort _outPutPort) 
        {
            inputPort = _inputPort;
            outPutPort = _outPutPort;
        }

        [HttpPost]
        public async Task<UserDTO> CreateUser(CreateUserDTO user) 
        {
            await inputPort.Handle(user);
            return ((IPresenter<UserDTO>)outPutPort).Content;
        }
    }
}

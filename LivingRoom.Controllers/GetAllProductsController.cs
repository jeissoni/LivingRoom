using LivingRoom.DTOs;
using LivingRoom.Presenter;
using LivingRoom.UseCasesPort;
using Microsoft.AspNetCore.Mvc;

namespace LivingRoom.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllUserInputPort inputPort;
        readonly IGetAllUserOutputPort outPutPort;

        public GetAllProductsController(
            IGetAllUserInputPort _inputPort,
            IGetAllUserOutputPort _outPutPort)
        {
            inputPort = _inputPort;
            outPutPort = _outPutPort;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAllProducts() 
        {
            await inputPort.Handle();
            return ((IPresenter<IEnumerable<UserDTO>>)outPutPort).Content;
        }
    }
}

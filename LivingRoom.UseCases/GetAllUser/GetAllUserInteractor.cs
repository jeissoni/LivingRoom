using LivingRoom.DTOs;
using LivingRoom.Entities.Interfaces;
using LivingRoom.UseCasesPort;

namespace LivingRoom.UseCases.GetAllProducts
{
    public class GetAllUserInteractor : IGetAllUserInputPort
    {
        readonly IUsuarioRepository usuarioRepository;
        readonly IGetAllUserOutputPort outputPort;

        public GetAllUserInteractor(
            IUsuarioRepository _usuarioRepository, 
            IGetAllUserOutputPort _outputPort) 
        {
            usuarioRepository = _usuarioRepository;
            outputPort = _outputPort;   
        }
        public Task Handle()
        {
            var Users = usuarioRepository.GetAll().Select(x =>
            new UserDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,    
                LastName = x.LastName,  
                Age = x.Age
            });
            
            outputPort.Handle(Users);
            return Task.CompletedTask;
        }
    }
}

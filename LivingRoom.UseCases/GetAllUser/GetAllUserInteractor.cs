using LivingRoom.DTOs;
using LivingRoom.Entities.Interfaces;
using LivingRoom.UseCasesPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Name = x.Name
            });
            
            outputPort.Handle(Users);
            return Task.CompletedTask;
        }
    }
}

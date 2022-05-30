using LivingRoom.DTOs;
using LivingRoom.Entities.Interfaces;
using LivingRoom.Entities.POCOs;
using LivingRoom.UseCasesPort;

namespace LivingRoom.UseCases.CreateUser
{
    public class CreateUserInteractor : ICreateUserInputPort
    {
        readonly IUsuarioRepository repository;
        readonly IUnitOfWork unitOfWork;
        readonly ICreateUserOutPutPort outPutPort;

        public CreateUserInteractor(
            IUsuarioRepository _repository,
            IUnitOfWork _unitOfWork,
            ICreateUserOutPutPort _outPutPort)
        {
            repository = _repository;
            unitOfWork = _unitOfWork;
            outPutPort = _outPutPort;
        }
        public async Task Handle(CreateUserDTO user)
        {
            User newUser = new User
            {
                Name = user.UserName
            };

            repository.CreateUser(newUser);
            await unitOfWork.SaveChanges();
            await outPutPort.Handle(
                new UserDTO
                {
                    Id = newUser.Id,
                    Name = user.UserName
                });
        }
    }
}

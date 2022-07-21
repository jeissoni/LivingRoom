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
            User newUser = new()
            {
                IdUser = user.IdUser,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth, 
                Email = user.Email, 
                Gender = user.Gender,
                CellPhoneNumber = user.CellPhoneNumber,
                Occupation = user.Occupation,
                Address = user.Address

            };

            repository.CreateUser(newUser);
            await unitOfWork.SaveChanges();
            await outPutPort.Handle(
                new UserDTO
                {
                    Id = newUser.Id,
                    Age = user.Age,
                    FirstName = user.FirstName,
                    LastName= user.LastName                   
                });
        }
    }
}

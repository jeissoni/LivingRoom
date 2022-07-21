﻿using LivingRoom.DTOs;
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
            try
            {
                User newUser = new()
                {
                    IdUser = user.IdUser,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    Gender = user.Gender,
                    Occupation = user.Occupation,
                    CellPhoneNumber = user.CellPhoneNumber,
                    Email = user.Email,
                    Leader = user.Leader,
                    Support = user.Support,
                    Attendee = user.Attendee

                };
           


            repository.CreateUser(newUser);
            await unitOfWork.SaveChanges();
            await outPutPort.Handle(
                new UserDTO
                {
                    IdUser = user.IdUser,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    Gender = user.Gender,
                    Occupation = user.Occupation,
                    CellPhoneNumber = user.CellPhoneNumber,
                    Email = user.Email,
                    Leader = user.Leader,
                    Support = user.Support,
                    Attendee = user.Attendee

                });

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

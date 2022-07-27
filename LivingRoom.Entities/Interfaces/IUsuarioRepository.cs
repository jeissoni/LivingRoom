using LivingRoom.Entities.POCOs;

namespace LivingRoom.Entities.Interfaces
{
    //Lo que quiero hacer, pero no como 
    //repositorio orientaod al dominio
    public interface IUsuarioRepository
    {
        //una forma para poder crear usuarios 
        void CreateUser(User usuario);

        //una manera que me regrese todos los usuarios
        IEnumerable<User> GetAll();
    }
}

using LivingRoom.Entities.POCOs;

namespace LivingRoom.Entities.Interfaces
{
    public interface IUsuarioRepository
    {
        void CreateUser(User usuario);
        IEnumerable<User> GetAll();
    }
}

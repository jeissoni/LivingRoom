using LivingRoom.Entities.Interfaces;
using LivingRoom.Entities.POCOs;
using LivingRoom.Repositoy.DataContext;

namespace LivingRoom.Repositoy.Repositories
{
    public class UserRepository : IUsuarioRepository
    {
        readonly LivingRoomContext context;

        public UserRepository(LivingRoomContext _context)
        {
            context = _context;
        }
        public void CreateUser(User usuario)
        {
            context.Add(usuario);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }
     
    }
}

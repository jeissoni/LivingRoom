using LivingRoom.Entities.Interfaces;
using LivingRoom.Entities.POCOs;
using LivingRoom.Repositoy.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

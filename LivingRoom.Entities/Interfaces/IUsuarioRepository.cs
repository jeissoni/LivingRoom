using LivingRoom.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Entities.Interfaces
{
    public interface IUsuarioRepository
    {
        void CreateUser(User usuario);
        IEnumerable<User> GetAll();
    }
}

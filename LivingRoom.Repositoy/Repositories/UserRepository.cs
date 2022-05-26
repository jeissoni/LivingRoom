using LivingRoom.Entities.DTO;
using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.DataContext;
using LivingRoom.Repositoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Repositoy.Repositories
{
    public class UserRepository : IUsuarioRepository
    {
        readonly bdtosahdContext context;

        public UserRepository(bdtosahdContext _context) 
        {
            context = _context;
        }
        public void CreateUser(TUsuarios usuario)
        {
            context.Add(usuario);
        }

        public IEnumerable<TUsuarios> GetAll()
        {
            return (IEnumerable<TUsuarios>)context.TUsuarios;
        }
    }
}

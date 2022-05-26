using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Repositoy.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly bdtosahdContext context;

        public UnitOfWork(bdtosahdContext _context)
        {
            context = _context;
        }
        public Task<int> SaveChanges()
        {
            try
            {
                return context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}

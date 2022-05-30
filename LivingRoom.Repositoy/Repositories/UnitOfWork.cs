using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.DataContext;

namespace LivingRoom.Repositoy.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly LivingRoomContext context;

        public UnitOfWork(LivingRoomContext _context)
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
                //capturar los errores y manejarlos 
                throw;
            }

        }
    }
}

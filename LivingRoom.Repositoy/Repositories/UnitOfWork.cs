using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.DataContext;

namespace LivingRoom.Repositoy.Repositories
{
    /*
     *Los patrones de repositorio y unidad de trabajo están destinados a
     *crear una capa de abstracción entre la capa de acceso a datos y 
     *la capa de lógica empresarial de una aplicación. La implementación 
     *de estos patrones puede ayudar a aislar su aplicación de los cambios 
     *en el almacén de datos y puede facilitar las pruebas unitarias 
     *automatizadas o el desarrollo basado en pruebas (TDD).
     */
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

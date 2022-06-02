namespace LivingRoom.Entities.Interfaces
{
    //patron de diseño que agrupa las transacciones de una entidad
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}

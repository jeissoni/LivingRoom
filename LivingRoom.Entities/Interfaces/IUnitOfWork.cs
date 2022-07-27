namespace LivingRoom.Entities.Interfaces
{
    //patron de diseño que agrupa las transacciones de una entidad
    //Los patrones de repositorio y unidad de trabajo están destinados
    //a crear una capa de abstracción entre la capa de acceso a datos y
    //la capa de lógica empresarial de una aplicación.La implementación
    //de estos patrones puede ayudar a aislar su aplicación de los cambios
    //en el almacén de datos y puede facilitar las pruebas unitarias
    //automatizadas o el desarrollo basado en pruebas (TDD).

    //sealed implementa en la capa de repositorios 
    //LivingRoom.Repositoy.Repositories

    public interface IUnitOfWork
    {
        //un metodo que regrese un entero
        Task<int> SaveChanges();
    }

}

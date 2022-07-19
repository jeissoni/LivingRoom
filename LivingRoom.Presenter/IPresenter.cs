namespace LivingRoom.Presenter
{
    //son clases que se usan solo para formatear los datos 
    //no tiene logica de nogocio, solo logica para formatear datos 
    //va tomar datos y los presenta el formato elegido
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}

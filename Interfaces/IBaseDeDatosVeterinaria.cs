namespace Interfaces
{

    public interface IBaseDeDatosVeterinaria<T>
    {
        List<T> ObtenerTodosLosDatos();
        //T ObtenerPorId(int id);
        bool Agregar(T entidad);
        bool Modificar(T entidad);
        bool Eliminar(T entidad);
    }
    

}
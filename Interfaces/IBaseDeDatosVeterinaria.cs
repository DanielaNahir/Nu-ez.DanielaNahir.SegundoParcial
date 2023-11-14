namespace Interfaces
{

    public interface IBaseDeDatosVeterinaria<T>
    {
        //List<T> ObtenerTodosLosDatos();
        //T ObtenerPorId(int id);
        //bool Agregar(T entidad);
        bool Agregar(string comando);
        bool Eliminar(string comando);

        bool PruebaConexion();
    }
    

}
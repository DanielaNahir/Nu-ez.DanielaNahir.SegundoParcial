namespace Entidades
{

    public interface IBaseDeDatos<T>
    {
        List<T> ObtenerTodosLosDatos();
        //bool Modificar(string comando);
        bool Agregar(T entidad);
        bool Eliminar(T entidad);

        bool PruebaConexion();
    }
    

}
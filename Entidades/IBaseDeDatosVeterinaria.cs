namespace Entidades
{

    public interface IBaseDeDatosVeterinaria<T>
    {
        List<T> ObtenerTodosLosDatos();
        //bool Modificar(string comando);
        bool Agregar(T entidad);
        bool Eliminar(T entidad);

        bool PruebaConexion();
    }
    

}
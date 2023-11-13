namespace Interfaces
{
    public interface IBaseDeDatos<T>
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
        void Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepción que se lanza cuando hay un error relacionado con el 
    /// espacio de internación.
    /// </summary>
    public class EspacioInternacionException : Exception
    {
        public EspacioInternacionException()
            : base()
        {
        }
    }
    /// <summary>
    /// Excepción que se lanza cuando hay un error en la base de datos.
    /// </summary>
    public class BaseDeDatosSQLException : Exception
    {

        public BaseDeDatosSQLException(string mensajeException)
            : base($"Error en la base de datos!\n{mensajeException}")
        {
        }
    }
    /// <summary>
    /// Excepción que se lanza cuando no se puede establecer conexión.
    /// </summary>
    public class ErrorConexionException : Exception
    {
        public ErrorConexionException()
            : base("No se pudo establecer conexion")
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EspacioInternacionException : Exception
    {
        public EspacioInternacionException()
            : base()
        {
        }
    }

    public class BaseDeDatosSQLException : Exception
    {
        public BaseDeDatosSQLException(string mensajeException)
            : base($"Error en la base de datos!\n{mensajeException}")
        {
        }
    }

    public class ErrorConexionException : Exception
    {
        public ErrorConexionException()
            : base("No se pudo establecer conexion")
        {
        }
    }
}
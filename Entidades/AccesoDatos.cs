using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase base para el acceso a datos utilizando SqlConnection y SqlCommand.
    /// </summary>
    public class AccesoDatos
    {
        protected SqlConnection conexion;
        protected static string cadena_conexion;
        protected SqlCommand comando;
        protected SqlDataReader? lector;

        /// <summary>
        /// Inicializa la cadena de conexión estática desde los recursos de la aplicación.
        /// </summary>
        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.conexion;
        }
        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public AccesoDatos()
        {
            this.comando = new SqlCommand();
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        /// <summary>
        /// Realiza una prueba de conexión a la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la conexión fue exitosa, de lo contrario, lanza una excepción.</returns>

        public bool PruebaConexion()
        {
            bool result = false;

            try
            {
                this.conexion.Open();
                result = true;
            }
            catch
            {
                throw new ErrorConexionException();
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                    this.conexion.Close();
            }

            return result;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatos
    {
        protected SqlConnection conexion;
        protected static string cadena_conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.conexion;
        }
        public AccesoDatos()
        {
            this.comando = new SqlCommand();
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        public bool PruebaConexion()
        {
            bool result = false;

            try
            {
                this.conexion.Open();
                result = true;
            }
            catch (Exception ex)
            {

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

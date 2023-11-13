using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Entidades
{
    public class AccesoBaseDatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static AccesoBaseDatos()
        {
            AccesoBaseDatos.cadena_conexion = Properties.Resources.conexion;
            //AccesoBaseDatos.cadena_conexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=NuñezDanielaNahir_SegundoParcial;Integrated Security=True";
        }
        public AccesoBaseDatos()
        {
            this.conexion = new SqlConnection(AccesoBaseDatos.cadena_conexion);
        }

        public bool PruebaConexion()
        {
            bool result = false;

            try
            {
                this.conexion.Open();
                result = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return result;
        }
    }
}

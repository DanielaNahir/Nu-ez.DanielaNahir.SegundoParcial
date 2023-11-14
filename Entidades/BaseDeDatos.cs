using Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BaseDeDatos<T> : IBaseDeDatosVeterinaria<T>
    {
        protected SqlConnection conexion;
        protected static string cadena_conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;

        static BaseDeDatos()
        {
            BaseDeDatos<T>.cadena_conexion = Properties.Resources.conexion;
        }
        public BaseDeDatos()
        {
            this.conexion = new SqlConnection(BaseDeDatos<T>.cadena_conexion);
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

        public bool Agregar(string comandoINSERTSQL)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = comandoInsertSQL;
                this.comando.Connection = this.conexion;
                
                this.conexion.Open();
                int filas = this.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;
            }
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                    this.conexion.Close();
            }

            return result;
        }

        public bool Eliminar(string comandoDELETESQL)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = comandoDELETESQL;
                this.comando.Connection = this.conexion;
                
                this.conexion.Open();
                int filas = this.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;

            }
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                    this.conexion.Close();
            }

            return result;
        }
    
    }
}

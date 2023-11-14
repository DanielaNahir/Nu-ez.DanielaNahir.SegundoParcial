using Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entidades
{
    public class AccesoDatosListaMascotas<T> : AccesoDatos, IBaseDeDatosVeterinaria<T> where T : Mascota
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static AccesoDatosListaMascotas()
        {
            AccesoDatosListaMascotas<T>.cadena_conexion = Properties.Resources.conexion;
        }
        public AccesoDatosListaMascotas()
        {
            this.conexion = new SqlConnection(AccesoDatosListaMascotas<T>.cadena_conexion);
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

        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select nombre, precio from productos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Producto prod = new Producto();
                    prod.Nombre = this.lector["nombre"].ToString();
                    prod.Precio = (float)this.lector.GetDouble(1);
                    lista.Add((T)prod);
                }
                this.lector.Close();
            }
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                    this.conexion.Close();
            }

            return lista;
        }
        public bool Agregar(T prod)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "insert into productos(nombre, precio) values('" + prod.Nombre + "'," + prod.Precio + ")";
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
        public bool Modificar(T prod)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                this.comando.Parameters.AddWithValue("@precio", prod.Precio);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "update productos set nombre = @nombre, precio = @precio where nombre = @nombre";
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
        public bool Eliminar(T prod)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();
                //this.comando.Parameters.AddWithValue("@nombre", prod.Nombre);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"DELETE from productos WHERE nombre = '{prod.Nombre}'";
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
}

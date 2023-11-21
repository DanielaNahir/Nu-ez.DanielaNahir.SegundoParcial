using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Entidades
{
    /// <summary>
    /// Clase para acceder y manipular datos de productos en una base de datos.
    /// </summary>
    /// <typeparam name="T">producto</typeparam>
    public class AccesoDatosProducto<T>: AccesoDatos, IBaseDeDatos<T> where T : Producto
    {
        /// <summary>
        /// Obtiene todos los productos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "select nombre, precio from productos";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = base.comando.ExecuteReader();

                while (base.lector.Read())
                {
                    Producto prod = new Producto();
                    prod.Nombre = base.lector["nombre"].ToString();
                    prod.Precio = (float)base.lector.GetDouble(1);
                    lista.Add((T)prod);
                }
                base.lector.Close();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosSQLException(ex.Message);
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return lista;
        }

        /// <summary>
        /// Agrega un producto a la base de datos.
        /// </summary>
        /// <param name="prod">Producto a agregar.</param>
        /// <returns>True si se agrega correctamente, false en caso contrario.</returns>
        public bool Agregar(T prod)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "insert into productos(nombre, precio) values('" + prod.Nombre + "'," + prod.Precio + ")";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                int filas = base.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosSQLException(ex.Message);
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }

        /// <summary>
        /// Modifica un producto en la base de datos.
        /// </summary>
        /// <param name="prod">Producto a modificar.</param>
        /// <returns>True si se modifica correctamente, false en caso contrario.</returns>
        public bool Modificar(T prod)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();
                base.comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                base.comando.Parameters.AddWithValue("@precio", prod.Precio);

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "update productos set nombre = @nombre, precio = @precio where nombre = @nombre";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                int filas = base.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;

            }
            catch (Exception ex)
            {
                throw new BaseDeDatosSQLException(ex.Message);
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }

        /// <summary>
        /// Elimina un producto de la base de datos.
        /// </summary>
        /// <param name="prod">Producto a eliminar.</param>
        /// <returns>True si se elimina correctamente, false en caso contrario.</returns>
        public bool Eliminar(T prod)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"DELETE from productos WHERE nombre = '{prod.Nombre}'";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                int filas = base.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;

            }
            catch (Exception ex)
            {
                throw new BaseDeDatosSQLException(ex.Message);
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }

    }
}

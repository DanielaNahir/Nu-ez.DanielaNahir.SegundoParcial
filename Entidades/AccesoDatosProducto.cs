using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Interfaces;

namespace Entidades
{
    public class AccesoDatosProducto<T>: BaseDeDatos //,IBaseDeDatosVeterinaria<T> where T : Producto
    {
        public AccesoDatosProducto():base() {}

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
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return lista;
        }
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
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }
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
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }
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
            //catch (Exception ex)
            //{

            //}
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                    base.conexion.Close();
            }

            return result;
        }

    }
}

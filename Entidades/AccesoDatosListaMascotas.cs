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
    public class AccesoDatosListaMascotas<T> : BaseDeDatos //, IBaseDeDatosVeterinaria<T> where T : Mascota
    {
        public AccesoDatosListaMascotas() : base() { }
        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "select nombre from listaMascotas";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = base.comando.ExecuteReader();

                while (base.lector.Read())
                {
                    Perro prod = new Perro();
                    prod.Nombre = base.lector["nombre"].ToString();
                    lista.Add((T)(Mascota)prod);
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
                base.comando.CommandText = "insert into listaMascotas(nombre values('" + prod.Nombre + "')";
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
                if (this.conexion.State == System.Data.ConnectionState.Open)
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

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "update listaMascotas set nombre = @nombre where nombre = @nombre";
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
                base.comando.CommandText = $"DELETE from listaMascotas WHERE nombre = '{prod.Nombre}'";
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

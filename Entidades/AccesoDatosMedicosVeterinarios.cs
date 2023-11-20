using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatosMedicosVeterinarios<T> : AccesoDatos, IBaseDeDatos<T> where T : MedicoVeterinario
    {
        public bool Agregar(T med)
        {
            bool result = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "insert into medicosVeterinarios(nombre, apellido, especialidad, sueldo)" +
                    $" values('{med.Nombre}','{med.Apellido}', '{med.Especialidad}', {med.Sueldo})";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filas = this.comando.ExecuteNonQuery();
                if (filas == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosSQLException(ex.Message);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                    this.conexion.Close();
            }

            return result;
        }

        public bool Eliminar(T med)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"DELETE from medicosVeterinarios WHERE nombre = '{med.Nombre}' and apellido = '{med.Apellido}'";
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

        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "select * from medicosVeterinarios";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = base.comando.ExecuteReader();

                while (base.lector.Read())
                {
                    MedicoVeterinario med = new MedicoVeterinario();
                    med.Nombre = base.lector["nombre"].ToString();
                    med.Apellido = base.lector["apellido"].ToString();
                    med.Especialidad = this.ParsearEspecialidad();
                    med.Sueldo = (float)base.lector.GetDouble(3);
                    lista.Add((T)med);
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

        public bool Modificar(T med)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();
                base.comando.Parameters.AddWithValue("@nombre", med.Nombre);
                base.comando.Parameters.AddWithValue("@apellido", med.Apellido);
                base.comando.Parameters.AddWithValue("@especialidad", med.Especialidad.ToString());
                base.comando.Parameters.AddWithValue("@sueldo", med.Sueldo);

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "update medicosVeterinarios set nombre = @nombre, apellido = @apellido," +
                    "especialidad = @especialidad, sueldo = @sueldo where nombre = @nombre and apellido = @apellido";
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

        public EEspecialidad ParsearEspecialidad()
        {
            EEspecialidad esp = new EEspecialidad();
            if (base.lector["especialidad"] != null)
            {
                switch (base.lector["especialidad"].ToString())
                {
                    case "Clinico":
                        esp = EEspecialidad.Clinico;
                        break;
                    case "Cardiologo":
                        esp = EEspecialidad.Cardiologo;
                        break;
                    case "Dermatologo":
                        esp = EEspecialidad.Dermatologo;
                        break;
                    case "Cirujano":
                        esp = EEspecialidad.Cirujano;
                        break;
                }
            }
            return esp;
        }
    }
}

using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entidades
{
    public class AccesoDatosListaMascotas<T> : AccesoDatos, IParsearEnumerados, IBaseDeDatosVeterinaria<T> where T : Mascota
    {
        public string tabla;
        public AccesoDatosListaMascotas(string tabla) : base()
        {
            this.tabla = tabla;
        }
        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"select * from {this.tabla}";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = base.comando.ExecuteReader();

                while (base.lector.Read())
                {
                    if (base.lector["tipoMascota"].ToString() == "Perro")
                    {
                        Perro masc = new Perro();
                        masc.TipoMascota = EMascota.Perro;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];
                        masc.Raza = this.ParsearRazaPerro();
                        if(base.lector["muerde"].ToString()=="True")
                            masc.Muerde = true;
                        else masc.Muerde = false;

                        lista.Add((T)(Mascota)masc);

                    }
                    else if (base.lector["tipoMascota"].ToString() == "Gato")
                    {
                        Gato masc = new Gato();
                        masc.TipoMascota = EMascota.Gato;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];
                        masc.Raza = this.ParsearRazaGato();
                        if (base.lector["rasguña"].ToString() == "True")
                            masc.Rasguña = true;
                        else masc.Rasguña = false;
                        if (base.lector["castrado"].ToString() == "True")
                            masc.Castrado = true;
                        else masc.Castrado = false;

                        lista.Add((T)(Mascota)masc);
                    }
                    else
                    {
                        Exotico masc = new Exotico();
                        masc.TipoMascota = EMascota.Exotico;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];
                        masc.Animal = this.ParsearExotico();
                        masc.Alimento = this.ParsearAlimentacion();

                        lista.Add((T)(Mascota)masc);
                    }

                    
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
        public bool Agregar(T masc) 
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                if (masc.TipoMascota == EMascota.Perro)
                {
                    base.comando.CommandText = $"insert into {this.tabla}(nombre, nombreDueño, apellidoDueño, edad, raza, muerde, tipoMascota) " +
                    $"values('{masc.Nombre}','{masc.NombreDueño}', '{masc.ApellidoDueño}', {masc.Edad}," +
                    $"'{(masc as Perro)?.Raza}', '{(masc as Perro)?.Muerde}', '{masc.TipoMascota}')";
                }
                else if (masc.TipoMascota == EMascota.Gato)
                {
                    base.comando.CommandText = $"insert into {this.tabla}(nombre, nombreDueño, apellidoDueño, edad, raza, rasguña, castrado, tipoMascota) " +
                    $"values('{masc.Nombre}','{masc.NombreDueño}', '{masc.ApellidoDueño}', {masc.Edad}," +
                    $"'{(masc as Gato)?.Raza}', '{(masc as Gato)?.Rasguña}', '{(masc as Gato)?.Castrado}', '{masc.TipoMascota}')";
                }
                else
                {
                    base.comando.CommandText = $"insert into {this.tabla}(nombre, nombreDueño, apellidoDueño, edad, animal, alimento, tipoMascota) " +
                    $"values('{masc.Nombre}','{masc.NombreDueño}', '{masc.ApellidoDueño}', {masc.Edad}," +
                    $"'{(masc as Exotico)?.Animal}', '{(masc as Exotico)?.Alimento}', '{masc.TipoMascota}')";
                }

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
        public bool Modificar(T masc)
        {
            bool result = false;
            try
            {
                StringBuilder sb = new StringBuilder();
                base.comando = new SqlCommand();
                base.comando.Parameters.AddWithValue("@nombre", masc.Nombre);
                base.comando.Parameters.AddWithValue("@nombreDueño", masc.NombreDueño);
                base.comando.Parameters.AddWithValue("@apellidoDueño", masc.ApellidoDueño);
                base.comando.Parameters.AddWithValue("@edad", (int)masc.Edad);
                base.comando.Parameters.AddWithValue("@tipoMascota", masc.TipoMascota.ToString());

                sb.Append($"update {this.tabla} set nombre = @nombre, nombreDueño = @nombreDueño, apellidoDueño = @apellidoDueño, edad = @edad, tipoMascota = @tipoMascota,");                      

                if (masc.TipoMascota == EMascota.Perro)
                {
                    base.comando.Parameters.AddWithValue("@raza", (masc as Perro)?.Raza);
                    base.comando.Parameters.AddWithValue("@muerde", (masc as Perro)?.Muerde);
                    sb.Append("raza = @raza, muerde = @muerde ");
                }
                else if (masc.TipoMascota == EMascota.Gato)
                {
                    base.comando.Parameters.AddWithValue("@raza", (masc as Gato)?.Raza);
                    base.comando.Parameters.AddWithValue("@rasguña", (masc as Gato)?.Rasguña);
                    base.comando.Parameters.AddWithValue("@castrado", (masc as Gato)?.Castrado);
                    sb.Append("raza = @raza, rasguña = @rasguña, castrado = @castrado ");
                }
                else
                {
                    base.comando.Parameters.AddWithValue("@animal", (masc as Exotico)?.Animal);
                    base.comando.Parameters.AddWithValue("@alimento", (masc as Exotico)?.Alimento);
                    sb.Append("animal = @animal, alimento = @alimento ");
                }
                sb.Append("where nombre = @nombre and tipoMascota = @tipoMascota and nombreDueño = @nombreDueño and apellidoDueño = @apellidoDueño");
                base.comando.CommandText = sb.ToString();
                base.comando.CommandType = System.Data.CommandType.Text;
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
        public bool Eliminar(T masc)
        {
            bool result = false;
            try
            {
                base.comando = new SqlCommand();

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"DELETE from {this.tabla} WHERE nombre = '{masc.Nombre}'" +
                    $" and tipoMascota = '{masc.TipoMascota}' and nombreDueño = '{masc.NombreDueño}' and apellidoDueño = '{masc.ApellidoDueño}'";
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

        public ERazaPerro ParsearRazaPerro()
        {
            ERazaPerro raza = new ERazaPerro();
            if (base.lector["raza"] != null)
            {
                switch (base.lector["raza"].ToString())
                {
                    case "Bulldog":
                        raza = ERazaPerro.Bulldog;
                        break;
                    case "Caniche":
                        raza = ERazaPerro.Caniche;
                        break;
                    case "Golden":
                        raza = ERazaPerro.Golden;
                        break;
                    case "Labrador":
                        raza = ERazaPerro.Labrador;
                        break;
                    case "Mestizo":
                        raza = ERazaPerro.Mestizo;
                        break;
                }
            }
            return raza;
        }
        public ERazaGato ParsearRazaGato()
        {
            ERazaGato raza = new ERazaGato();
            if (base.lector["raza"] != null)
            {
                switch (base.lector["raza"].ToString())
                {
                    case "Persa":
                        raza = ERazaGato.Persa;
                        break;
                    case "Siames":
                        raza = ERazaGato.Siames;
                        break;
                    case "Europeo":
                        raza = ERazaGato.Europeo;
                        break;
                    case "Siberiano":
                        raza = ERazaGato.Siberiano;
                        break;
                }
            }
            return raza;
        }

        public EExotico ParsearExotico()
        {
            EExotico raza = new EExotico();
            if (base.lector["raza"] != null)
            {
                switch (base.lector["raza"].ToString())
                {
                    case "Cobayo":
                        raza = EExotico.Cobayo;
                        break;
                    case "Hamster":
                        raza = EExotico.Hamster;
                        break;
                    case "Huron":
                        raza = EExotico.Huron;
                        break;
                    case "Tortuga":
                        raza = EExotico.Tortuga;
                        break;
                }
            }
            return raza;
        }

        public EAlimento ParsearAlimentacion()
        {
            EAlimento raza = new EAlimento();
            if (base.lector["raza"] != null)
            {
                switch (base.lector["raza"].ToString())
                {
                    case "Especial":
                        raza = EAlimento.Especial;
                        break;
                    case "Cereales":
                        raza = EAlimento.Cereales;
                        break;
                    case "Vegetales":
                        raza = EAlimento.Vegetales;
                        break;
                }
            }
            return raza;
        }

    }
}

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
    public class AccesoDatosListaMascotas<T> : AccesoDatos, IBaseDeDatosVeterinaria<T> where T : Mascota
    {
        public AccesoDatosListaMascotas() : base() { }
        public List<T> ObtenerTodosLosDatos()
        {
            List<T> lista = new List<T>();
            try
            {
                base.comando = new SqlCommand();
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = "select * from listaMascotas";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = base.comando.ExecuteReader();


                while (base.lector.Read())
                {
                    Mascota masc;
                    if (base.lector["tipoMascota"].ToString() == "Perro")
                    {
                        masc = new Perro();
                        masc.TipoMascota = EMascota.Perro;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];

                    }
                    else if (base.lector["tipoMascota"].ToString() == "Gato")
                    {
                        masc = new Gato();
                        masc.TipoMascota = EMascota.Gato;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];
                    }
                    else
                    {
                        masc = new Exotico();
                        masc.TipoMascota = EMascota.Exotico;
                        masc.Nombre = base.lector["nombre"].ToString();
                        masc.NombreDueño = base.lector["nombreDueño"].ToString();
                        masc.ApellidoDueño = base.lector["apellidoDueño"].ToString();
                        masc.Edad = (int)base.lector["edad"];
                    }

                    lista.Add((T)(Mascota)masc);
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
                //this.comando.Parameters.AddWithValue("@nombre", prod.Nombre);

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

        /// <summary>
        /// Parsea y deternima el valor de la raza de perro seleccionada por el usuario
        /// /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado ERazaPerro que representa la raza del perro</returns>
        public ERazaPerro ParsearRazaPerro()
        {
            ERazaPerro raza = ERazaPerro.Mestizo;
            if (this.radBtnBulldog.Checked)
            {
                raza = ERazaPerro.Bulldog;
            }
            else if (this.radBtnCaniche.Checked)
            {
                raza = ERazaPerro.Caniche;
            }
            else if (this.radBtnGolden.Checked)
            {
                raza = ERazaPerro.Golden;
            }
            else if (this.radBtnLabrador.Checked)
            {
                raza = ERazaPerro.Labrador;
            }
            return raza;
        }

        /// <summary>
        /// Parsea y deternima el valor de la raza de gato seleccionada por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado ERazaGato que representa la raza del gato</returns>
        public ERazaGato ParsearRazaGato()
        {
            ERazaGato raza = ERazaGato.Europeo;
            if (this.radBtnSiberiano.Checked)
            {
                raza = ERazaGato.Siberiano;
            }
            else if (this.radBtnSiames.Checked)
            {
                raza = ERazaGato.Siames;
            }
            else if (this.radBtnPersa.Checked)
            {
                raza = ERazaGato.Persa;
            }
            return raza;
        }

        /// <summary>
        /// Parsea y deternima el valor del animal seleccionado por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado EExotico que representa el animal exotico</returns>
        public EExotico ParsearExotico()
        {
            EExotico animal = EExotico.Hamster;
            if (this.radBtnHuron.Checked)
            {
                animal = EExotico.Huron;
            }
            else if (this.radBtnCobayo.Checked)
            {
                animal = EExotico.Cobayo;
            }
            else if (this.radBtnTortuga.Checked)
            {
                animal = EExotico.Tortuga;
            }
            return animal;
        }

        /// <summary>
        /// Parsea y deternima el valor de la alimentacion seleccionada por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado EAlimento que representa la alimentacion</returns>
        public EAlimento ParsearAlimentacion()
        {
            EAlimento alimento = EAlimento.Especial;
            if (this.radBtnCereales.Checked)
            {
                alimento = EAlimento.Cereales;
            }
            else if (this.radBtnVegetales.Checked)
            {
                alimento = EAlimento.Vegetales;
            }
            return alimento;
        }
    }
}

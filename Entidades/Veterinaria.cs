using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa al una veterinaria
    /// </summary>
    public class Veterinaria
    {
        private List<Mascota> listaMascotas;
        private List<Mascota> listaMascotasInternadas; // agregar capacidad limite para la cant de mascotas internadas
        private List<MedicoVeterinario> listaMedicosVeterinarios;
        private List<Producto> listaPrecios;
        private List<Turno> listaTurnos;    

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Veterinaria()
        {
            this.listaMascotas = new List<Mascota>();
            this.listaMascotasInternadas = new List<Mascota>();
            this.listaMedicosVeterinarios = new List<MedicoVeterinario>();
            this.listaPrecios = new List<Producto>();
            this.listaTurnos = new List<Turno>();
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura del atributo listaMascotas
        /// </summary>
        public List<Mascota> ListaMascotas
        {
            get { return this.listaMascotas; }
            set { this.listaMascotas = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo listaMascotasInternadas
        /// </summary>
        public List<Mascota> ListaMascotasInternadas
        {
            get { return this.listaMascotasInternadas; }
            set { this.listaMascotasInternadas = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo listaMedicosVeterinarios
        /// </summary>
        public List<MedicoVeterinario> ListaMedicosVeterinarios
        {
            get { return this.listaMedicosVeterinarios; }
            set { this.listaMedicosVeterinarios = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo listaProductos
        /// </summary>
        public List<Producto> ListaProductos
        {
            get { return this.listaPrecios; }
            set { this.listaPrecios = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo listaTurnos
        /// </summary>
        public List<Turno> ListaTurnos
        {
            get { return this.listaTurnos;}
            set { this.listaTurnos = value;}
        }
        #endregion

        #region SOBRECARGAS

        #region mascota/vete
        /// <summary>
        /// Sobrecarga del operador == para comparar si Mascota esta Veterinaria.listaMascota
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Mascota masc, Veterinaria vete)
        {
            bool result = false;
            if (masc.VerificarIgualdad(vete.listaMascotas))
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar no Mascota esta Veterinaria.listaMascota
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Mascota masc, Veterinaria vete)
        {
            return !(masc == vete);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar una mascota a la lista mascota
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Mascota</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator +(Veterinaria vete, Mascota masc)
        {
                if (masc != vete)
                {
                    vete.listaMascotas.Add(masc);
                }

            return vete;
        }
        /// <summary>
        /// Sobrecarga del operador - para eliminar una mascota de la lista mascota
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Mascota</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator -(Veterinaria vete, Mascota masc)
        {
            if (masc == vete)
            {
                vete.listaMascotas.Remove(masc);
            }

            return vete;
        }
        #endregion

        #region profesional/vete
        /// <summary>
        /// Sobrecarga del operador == para comparar si MedicoVeterinario esta Veterinaria.listaMedicosVeterinarios
        /// </summary>
        /// <param name="m1">MedicoVeterinario</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(MedicoVeterinario med, Veterinaria vete)
        {
            bool result = false;
            foreach (MedicoVeterinario m in vete.listaMedicosVeterinarios)
            {
                if (m == med)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar si MedicoVeterinario esta Veterinaria.listaMedicosVeterinarios
        /// </summary>
        /// <param name="m1">MedicoVeterinario</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(MedicoVeterinario med, Veterinaria vete)
        {
            return !(med == vete);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un MedicoVeterinario a la lista Medicos
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">MedicoVeterinario</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator +(Veterinaria vete, MedicoVeterinario med)
        {
            if (med != vete)
            {
                vete.listaMedicosVeterinarios.Add(med);
            }

            return vete;
        }
        /// <summary>
        /// Sobrecarga del operador - para eliminar un MedicoVeterinario de la lista medicos
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">MedicoVeterinario</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator -(Veterinaria vete, MedicoVeterinario masc)
        {
            if (masc == vete)
            {
                vete.listaMedicosVeterinarios.Remove(masc);
            }

            return vete;
        }
        #endregion

        #region producto/vete
        /// <summary>
        /// Sobrecarga del operador == para comparar si Producto esta en Veterinaria.listaPrecios
        /// </summary>
        /// <param name="m1">producto</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Producto pod, Veterinaria vete)
        {
            bool result = false;
            foreach (Producto m in vete.listaPrecios)
            {
                if (m == pod)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar si Producto esta en Veterinaria.listaPrecios
        /// </summary>
        /// <param name="m1">Producto</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Producto pro, Veterinaria vete)
        {
            return !(pro == vete);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un Producto a la lista de producto
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Producto</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator +(Veterinaria vete, Producto prod)
        {
            if (prod != vete)
            {
                vete.listaPrecios.Add(prod);
            }

            return vete;
        }
        /// <summary>
        /// Sobrecarga del operador - para eliminar un Producto de la lista de Producto
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Producto</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator -(Veterinaria vete, Producto prod)
        {
            if (prod == vete)
            {
                vete.listaPrecios.Remove(prod);
            }

            return vete;
        }
        #endregion

        #region turno/vete
        /// <summary>
        /// Sobrecarga del operador == para comparar si Turno esta Veterinaria.listaTurnos
        /// </summary>
        /// <param name="m1">Turno</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Turno tur, Veterinaria vete)
        {
            bool result = false;
            foreach (Turno m in vete.listaTurnos)
            {
                if (m == tur)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar si Turno esta Veterinaria.listaTurno
        /// </summary>
        /// <param name="m1">Turno</param>
        /// <param name="m2">Veterinaria</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Turno tur, Veterinaria vete)
        {
            return !(tur == vete);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un Turno a la lista de turnos
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Turno</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator +(Veterinaria vete, Turno tur)
        {
            if (tur != vete)
            {
                vete.listaTurnos.Add(tur);
            }

            return vete;
        }
        /// <summary>
        /// Sobrecarga del operador - para eliminar un Turno de la lista de turnos
        /// </summary>
        /// <param name="m1">Veterinaria</param>
        /// <param name="m2">Turno</param>
        /// <returns>Veterinaria con la lista modificada</returns>
        public static Veterinaria operator -(Veterinaria vete, Turno tur)
        {
            if (tur == vete)
            {
                vete.listaTurnos.Remove(tur);
            }

            return vete;
        }
        #endregion


        #endregion
        
        /// <summary>
        /// Compara dos Veterinaria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Veterinaria)
            {
                result = this == (Veterinaria)obj;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "";
        }
    }
}

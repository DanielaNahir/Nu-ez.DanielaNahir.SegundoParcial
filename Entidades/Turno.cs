using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase con las caracteristicas de un turno medico para una mascota
    /// </summary>
    public class Turno
    {
        private Mascota mascota;
        private MedicoVeterinario profesional;
        private DateTime fecha;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Turno()
        {
            this.mascota = new Perro();
            this.profesional = new MedicoVeterinario();
            this.fecha = DateTime.Now;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="mascota"></param>
        /// <param name="profesional"></param>
        /// <param name="fecha"></param>
        public Turno(Mascota mascota, MedicoVeterinario profesional, DateTime fecha) : this()
        {
            this.mascota = mascota;
            this.profesional = profesional;
            this.fecha = fecha;
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo mascota
        /// </summary>
        public Mascota Mascota
        {
            get { return mascota; }
            set { this.mascota = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo profesional
        /// </summary>
        public MedicoVeterinario Profesional
        {
            get { return this.profesional; }
            set { this.profesional = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo fecha
        /// </summary>
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        /// <summary>
        /// Muestra ciertos datos de Turno
        /// </summary>
        /// <returns>String con los datos correspondientes</returns>
        public string Mostrar()
        {
            return $"{this.mascota.Nombre.ToUpper()} - {this.fecha} - {this.profesional.nombre} {this.profesional.apellido}";
        }

        /// <summary>
        /// Metodo que muestra todos los datos de Turno
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.mascota.Mostrar("MASCOTA"));
            sb.AppendLine("PROFESIONAL:");
            sb.AppendLine(this.profesional.Mostrar());

            return sb.ToString();
        }
        /// <summary>
        /// Compara dos Turno
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Turno)
            {
                result = this == (Turno)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar dos Turno
        /// </summary>
        /// <param name="m1">Turno</param>
        /// <param name="m2">Turno</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Turno t1, Turno t2)
        {
            return t1.profesional == t2.profesional
                && t1.fecha == t2.fecha;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Turno
        /// </summary>
        /// <param name="m1">Turno</param>
        /// <param name="m2">Turno</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Turno t1, Turno t2)
        {
            return !(t1 == t2);
        }

    }
}

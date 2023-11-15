using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un medico Veterinario
    /// </summary>
    public class MedicoVeterinario
    {
        public string nombre;
        public string apellido;
        public EEspecialidad especialidad;
        private float sueldo;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public MedicoVeterinario()
        {
            this.nombre = "";
            this.apellido = "";
            this.especialidad = EEspecialidad.Clinico;
            this.sueldo = 0;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="especialidad"></param>
        /// <param name="sueldo"></param>
        public MedicoVeterinario(string nombre, string apellido, EEspecialidad especialidad, int sueldo) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.sueldo = sueldo;
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value;}
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo especialidad
        /// </summary>
        public EEspecialidad Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo sueldo
        /// </summary>
        public float Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }

        #region ORDENAMIENTO
        /// <summary>
        /// Ordena de forma ascentente dos MedicoVeterinario segun la edad
        /// </summary>
        /// <param name="m1">primer MedicoVeterinario</param>
        /// <param name="m2">segunda MedicoVeterinario</param>
        /// <returns>Int 1 si el primero es mayor, -1 si el primero es menor, o si son iguales</returns>
        public static int OrdenarPorEdadAscendenten(MedicoVeterinario m1, MedicoVeterinario m2)
        {
            if (m1.sueldo > m2.sueldo)
                return 1;
            else if (m1.sueldo < m2.sueldo)
                return -1;
            else
                return 0;

        }
        /// <summary>
        /// Ordena de forma descentente dos MedicoVeterinario segun la edad
        /// </summary>
        /// <param name="m1">rimer MedicoVeterinario</param>
        /// <param name="m2">segunda MedicoVeterinario</param>
        /// <returns>Int 1 si el primero es menor, -1 si el primero es mayor, o si son iguales</returns>
        public static int OrdenarPorEdadDescendente(MedicoVeterinario m1, MedicoVeterinario m2)
        {
            if (m1.sueldo < m2.sueldo)
                return 1;
            else if (m1.sueldo > m2.sueldo)
                return -1;
            else
                return 0;
        }
        /// <summary>
        /// Metodo que ordena a dos MedicoVeterinario segun el nombre
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>Int que representa la comparacion</returns>
        public static int OrdenarPorNombre(MedicoVeterinario m1, MedicoVeterinario m2)
        {
            return String.Compare(m1.nombre, m2.nombre);

        }
        #endregion

        /// <summary>
        /// Muestra ciertos datos de MedicoVeterinario
        /// </summary>
        /// <returns>String con los datos correspondientes</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido} - {this.especialidad.ToString()}");

            return sb.ToString();
        }
        /// <summary>
        /// Metodo que muestra todos los datos de MedicoVeterinario
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} {this.apellido}");
            sb.AppendLine($"Especialidad: {this.especialidad}");
            sb.AppendLine($"Sueldo: {this.sueldo}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar dos MedicoVeterinario
        /// </summary>
        /// <param name="m1">MedicoVeterinario</param>
        /// <param name="m2">MedicoVeterinario</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(MedicoVeterinario m1, MedicoVeterinario m2)
        {
            return m1.nombre == m2.nombre
                && m1.apellido == m2.apellido;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos MedicoVeterinario
        /// </summary>
        /// <param name="m1">MedicoVeterinario</param>
        /// <param name="m2">MedicoVeterinario</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(MedicoVeterinario m1, MedicoVeterinario m2)
        {
            return !(m1 == m2);
        }
        /// <summary>
        /// Compara dos MedicoVeterinario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is MedicoVeterinario)
            {
                result = this == (MedicoVeterinario)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un Perro
    /// </summary>
    public class Perro : Mascota
    {
        protected ERazaPerro raza;
        protected bool muerde;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Perro() : base()
        {
            this.muerde = false;
            this.raza = ERazaPerro.Mestizo;
        }

        //uno menos
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="muerde"></param>
        public  Perro(string nombre, int edad, string nombreDueño,
            string apellidoDueño, bool muerde)
            : base(EMascota.Perro, nombre, edad, nombreDueño, apellidoDueño)
        {
            this.muerde = muerde;
        }
        //todos los parametros
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="muerde"></param>
        /// <param name="raza"></param>
        public Perro(string nombre, int edad, string nombreDueño,
            string apellidoDueño, bool muerde, ERazaPerro raza)
            : this(nombre, edad, nombreDueño, apellidoDueño, muerde)
        {
            this.raza = raza;
        }
        //sobre carga a eleccion -> invertir los parametros
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="raza"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="muerde"></param>
        public Perro(ERazaPerro raza, string nombre, int edad, string nombreDueño,
            string apellidoDueño, bool muerde)
            : this(nombre, edad, nombreDueño, apellidoDueño, muerde, raza) { }
        #endregion

        #region METODOS
        /// <summary>
        /// Verifica si este Perro esta en la lista de mascotas recibida
        /// </summary>
        /// <param name="lista">Lista sobre la que se verificara si esta</param>
        /// <returns>Booleano que representa si esta en la lista (true) o no (false)</returns>
        public override bool VerificarIgualdad(List<Mascota> lista)
        {
            bool result = false;
            foreach (Mascota m in lista)
            {
                if (m is Perro)
                {
                    result = m==this;
                }
            }
            return result;
        }
        /// <summary>
        /// Metodo que determinara si el Perro es agresivo o no
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool DeterminarAgresividad()
        {
            bool agresividad = false;
            if (this.muerde == true)
            {
                agresividad = true;
            }
            return agresividad;
        }

        /// <summary>
        /// Parsea y deternima el valor de la raza de perro recibido
        /// </summary>
        /// <returns>Un valor del enumerado ERazaPerro que representa la raza del perro</returns>

        public bool ParsearEnumerado(string raza)
        {
            bool result = true;
            raza = raza.ToLower();

            if (raza == "bulldog")
            {
                this.raza = ERazaPerro.Bulldog;
            }
            else if (raza == "caniche")
            {
                this.raza = ERazaPerro.Caniche;
            }
            else if (raza == "golden")
            {
                this.raza = ERazaPerro.Golden;
            }
            else if (raza == "labrador")
            {
                this.raza = ERazaPerro.Labrador;
            }
            else if (raza == "mestizo")
            {
                this.raza = ERazaPerro.Mestizo;
            }
            else
            {
                result = false;
            }

            return result;
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura del atributo raza
        /// </summary>
        public ERazaPerro Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo muerde
        /// </summary>
        public bool Muerde
        {
            get { return this.muerde; }
            set { this.muerde = value; }
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Sobrecarga del operador == para comparar dos Perro
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Perro m1, Perro m2)
        {
            return m1 == m2 && m1.raza == m2.raza;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Perro
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Perro m1, Perro m2)
        {
            return !(m1 == m2);
        }

        #endregion

        /// <summary>
        /// Metodo que muestra todos los datos de Perro
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Raza: {this.raza}");
            if (this.DeterminarAgresividad())
                sb.Append("Es agresivo");
            else
                sb.Append("No es agresivo");

            return sb.ToString();
        }
        /// <summary>
        /// Compara dos Perro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Perro)
            {
                result = this == (Perro)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
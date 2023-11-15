using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un Gato
    /// </summary>
    public class Gato : Mascota
    {
        protected ERazaGato raza;
        protected bool rasguña;
        protected bool castrado;

        #region CONSTRUCTORES
        /// <summary>
        /// Contructos sin parametros
        /// </summary>
        public Gato()
        {

        }

        //uno menos
        /// <summary>
        /// Constructos de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="raza"></param>
        /// <param name="rasguña"></param>
        public Gato(string nombre, int edad, string nombreDueño, 
            string apellidoDueño, ERazaGato raza, bool rasguña)
            : base(EMascota.Gato, nombre, edad, nombreDueño, apellidoDueño)
        {
            this.raza = raza;
            this.rasguña = rasguña;
        }
        //todos los parametros
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="raza"></param>
        /// <param name="rasguña"></param>
        /// <param name="castrado"></param>
        public Gato(string nombre, int edad, string nombreDueño,
            string apellidoDueño, ERazaGato raza, bool rasguña, bool castrado)
            : this(nombre, edad, nombreDueño, apellidoDueño, raza, rasguña)
        {
            this.castrado = castrado;
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
        /// <param name="rasguña"></param>
        /// <param name="castrado"></param>
        public Gato(ERazaGato raza, string nombre, int edad, string nombreDueño,
            string apellidoDueño, bool rasguña, bool castrado)
            : this(nombre, edad, nombreDueño, apellidoDueño, raza, rasguña, castrado) { }
        #endregion

        #region METODOS
        /// <summary>
        /// Verifica si este Gato esta en la lista de mascotas recibida
        /// </summary>
        /// <param name="lista">Lista sobre la que se verificara si esta</param>
        /// <returns>Booleano que representa si esta en la lista (true) o no (false)</returns>
        public override bool VerificarIgualdad(List<Mascota> lista)
        {
            bool result = false;
            foreach (Mascota m in lista)
            {
                if (m is Gato)
                {
                    result = m == this;
                }
            }
            return result;
        }
        /// <summary>
        /// Metodo que determinara si el Gato es agresivo o no
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool DeterminarAgresividad()
        {
            bool agresividad = false;
            if (this.rasguña == true && this.castrado == false)
            {
                agresividad = true;
            }
            return agresividad;
        }

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura del atributo raza
        /// </summary>
        public ERazaGato Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo rasguña
        /// </summary>
        public bool Rasguña
        {
            get { return this.rasguña; }
            set { this.rasguña = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo castrado
        /// </summary>
        public bool Castrado
        {
            get { return this.castrado; }
            set { this.castrado = value; }
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Sobrecarga del operador == para comparar dos Gatos
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Gato m1, Gato m2)
        {
            return m1 == m2 && m1.raza == m2.raza;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Gatos
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Gato m1, Gato m2)
        {
            return !(m1 == m2);
        }

        #endregion

        /// <summary>
        /// Metodo que muestra todos los datos de Gato
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Raza: {this.raza}");
            if (this.castrado)
                sb.AppendLine($"Castrado");
            if (this.DeterminarAgresividad())
                sb.AppendLine("Es agresivo");
            else
                sb.AppendLine("No es agresivo");

            return sb.ToString();
        }

        /// <summary>
        /// Compara dos Gatos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Gato)
            {
                result = this == (Gato)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
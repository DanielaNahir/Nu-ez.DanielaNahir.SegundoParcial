using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un animal Exotico
    /// </summary>
    public class Exotico : Mascota
    {
        protected EExotico animal;
        protected EAlimento alimento;

        #region CONSTRUCTORES
        /// <summary>
        /// constructor sin parametros
        /// </summary>
        public Exotico() : base()
        {
            this.animal = EExotico.Hamster;
            this.alimento = EAlimento.Especial;
        }

        //uno menos
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="animal"></param>
        public Exotico(string nombre, int edad, string nombreDueño,
            string apellidoDueño, EExotico animal)
            : base(EMascota.Exotico, nombre, edad, nombreDueño, apellidoDueño)
        {
            this.animal = animal;
        }
        //todos los parametros
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        /// <param name="animal"></param>
        /// <param name="alimento"></param>
        public Exotico(string nombre, int edad, string nombreDueño,
            string apellidoDueño, EExotico animal, EAlimento alimento)
            : this(nombre, edad, nombreDueño, apellidoDueño, animal)
        {
            this.alimento = alimento;
        }
        //sobre carga a eleccion -> invertir los parametros
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="alimento"></param>
        /// <param name="nombreDueño"></param>
        /// <param name="apellidoDueño"></param>
        public Exotico(EExotico animal, string nombre, int edad, EAlimento alimento, string nombreDueño,
            string apellidoDueño)
            : this(nombre, edad, nombreDueño, apellidoDueño, animal, alimento) { }
        #endregion

        #region METODOS
        /// <summary>
        /// Verifica si este Exotico esta en la lista de mascotas recibida
        /// </summary>
        /// <param name="lista">Lista sobre la que se verificara si esta</param>
        /// <returns>Booleano que representa si esta en la lista (true) o no (false)</returns>
        public override bool VerificarIgualdad(List<Mascota> lista)
        {
            bool result = false;
            foreach (Mascota m in lista)
            {
                if (m is Exotico)
                {
                    result = m == this;
                }
            }
            return result;
        }
        /// <summary>
        /// Metodo que determinara si el Exotico es agresivo o no
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool DeterminarAgresividad()
        {
            return false; //los animales exoticos no seran considerados agresivos debido a los
                            // tipos de animales permitidos (tortuga, hamster, etc.)
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura del atributo animal
        /// </summary>
        public EExotico Animal
        {
            get { return this.animal; }
            set { this.animal = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo alimento
        /// </summary>
        public EAlimento Alimento
        {
            get { return this.alimento; }
            set { this.alimento = value; }
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Sobrecarga del operador == para comparar dos Exotico
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Exotico m1, Exotico m2)
        {
            return m1 == m2 && m1.animal == m2.animal;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Exotico
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascora</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Exotico m1, Exotico m2)
        {
            return !(m1 == m2);
        }

        #endregion

        /// <summary>
        /// Metodo que muestra todos los datos de Exotico
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Animal: {this.animal}");
            sb.AppendLine($"Alimento: {this.alimento}");

            return sb.ToString();
        }
        /// <summary>
        /// Compara dos Exotico
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Exotico)
            {
                result = this == (Exotico)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
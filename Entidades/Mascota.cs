using System.Text;
using System.Xml.Serialization;


namespace Entidades
{
    [XmlInclude(typeof(Perro))]
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Exotico))]
    
    public abstract class Mascota 
    {
        protected string nombre;
        protected EMascota tipoMascota;
        protected int edad;
        protected string nombreDueño;
        protected string apellidoDueño;


        #region CONSTRUCTORES

        /// <summary>
        /// Constructor sin parametors de la clase
        /// </summary>
        public Mascota()
        {
            this.nombre = "";
            this.nombreDueño = "";
            this.apellidoDueño = "";
            this.edad = 0;
            this.tipoMascota = EMascota.Perro;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tipo">objeto de tipo EMascota</param>
        public Mascota(EMascota tipo) : this()
        {
            this.tipoMascota = tipo;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tipo">objeto de tipo EMascota</param>
        /// <param name="nombre">string</param>
        public Mascota(EMascota tipo,string nombre) : this(tipo)
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tipo">objeto de tipo EMascota</param>
        /// <param name="nombre">string</param>
        /// <param name="nombreDueño">string</param>
        public Mascota(EMascota tipo, string nombre, string nombreDueño) : this(tipo, nombre)
        {
            this.nombreDueño = nombreDueño;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tipo">objeto de tipo EMascota</param>
        /// <param name="nombre">string</param>
        /// <param name="nombreDueño">string</param>
        /// <param name="apellidoDueño">string</param>
        public Mascota(EMascota tipo, string nombre, string nombreDueño,
            string apellidoDueño) : this(tipo, nombre, nombreDueño)
        {
            this.apellidoDueño = apellidoDueño;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="tipo">objeto de tipo EMascota</param>
        /// <param name="nombre">string</param>
        /// <param name="nombreDueño">string</param>
        /// <param name="apellidoDueño">string</param>
        /// <param name="apellidoDueño">string</param>
        public Mascota(EMascota tipo, string nombre, int edad, string nombreDueño,
            string apellidoDueño) : this(tipo, nombre, nombreDueño, apellidoDueño)
        {
            this.edad = edad;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Verifica si esta mascota esta en la lista de mascotas recibida
        /// </summary>
        /// <param name="lista">Lista sobre la que se verificara si esta</param>
        /// <returns>Booleano que representa si esta en la lista (true) o no (false)</returns>
        public virtual bool VerificarIgualdad(List<Mascota> lista)
        {
            return lista.Contains(this);
        }

        /// <summary>
        /// Muestra ciertos datos de Mascota
        /// </summary>
        /// <returns>String con los datos correspondientes</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombreDueño} {this.apellidoDueño} - {(this.nombre).ToUpper()}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra ciertos datos de Mascota
        /// </summary>
        /// <param name="Titulo">String que sera agregado como titulo</param>
        /// <returns>String con los datos correspondientes</returns>
        public string Mostrar(string Titulo) //sobrecarga de metodo
        {
            return $"{Titulo}\n{this}";
        }

        /// <summary>
        /// Metodo abstracto que determinara si un animal es agresivo o no
        /// </summary>
        /// <returns>Boleano</returns>
        public abstract bool DeterminarAgresividad();

        //public abstract bool ParsearEnumerado(string valorEnumerado);

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombreDueño
        /// </summary>
        public string NombreDueño
        {
            get { return this.nombreDueño; }
            set { this.nombreDueño = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo tipoMascota
        /// </summary>
        public EMascota TipoMascota
        {
            get { return this.tipoMascota; }
            set { this.tipoMascota = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo edad
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo apellidoNombre
        /// </summary>
        public string ApellidoDueño
        {
            get { return this.apellidoDueño; }
            set { this.apellidoDueño = value; }
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Sobrecarga del operador == para comparar dos Mascotas
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascota</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return m1.nombre == m2.nombre 
                && m1.tipoMascota == m2.tipoMascota 
                && m1.nombreDueño == m2.nombreDueño
                && m1.apellidoDueño == m2.apellidoDueño;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Mascotas
        /// </summary>
        /// <param name="m1">Mascota</param>
        /// <param name="m2">Mascota</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        /// <summary>
        /// Parsea una mascota a string
        /// </summary>
        /// <param name="m">string de Mascota</param>
        public static explicit operator string(Mascota m)
        {
            return $"{m.nombreDueño} {m.apellidoDueño} - {m.nombre.ToUpper()}";
        }

        #endregion

        #region ORDENAMIENTO
        /// <summary>
        /// Ordena de forma ascentente dos Mascotas segun la edad
        /// </summary>
        /// <param name="m1">primer Mascota</param>
        /// <param name="m2">segunda Mascota</param>
        /// <returns>Int 1 si el primero es mayor, -1 si el primero es menor, o si son iguales</returns>
        public static int OrdenarPorEdadAscendenten(Mascota m1, Mascota m2)
        {
            if (m1.edad > m2.edad)
                return 1;
            else if (m1.edad < m2.edad)
                return -1;
            else
                return 0;

        }
        /// <summary>
        /// Ordena de forma descentente dos Mascotas segun la edad
        /// </summary>
        /// <param name="m1">primer Mascota</param>
        /// <param name="m2">segunda Mascota</param>
        /// <returns>Int 1 si el primero es menor, -1 si el primero es mayor, o si son iguales</returns>
        public static int OrdenarPorEdadDescendente(Mascota m1, Mascota m2)
        {
            if (m1.edad < m2.edad)
                return 1;
            else if (m1.edad > m2.edad)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Metodo que ordena a dos Mascotas segun el nombre
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>Int que representa la comparacion</returns>
        public static int OrdenarPorNombre(Mascota m1, Mascota m2)
        {
            return String.Compare(m1.nombre, m2.nombre);

        }
        #endregion
        
        /// <summary>
        /// Metodo que muestra todos los datos de Mascota
        /// </summary>
        /// <returns>String todos los datos correspondientes</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Mostrar());
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Tipo: {this.tipoMascota}");

            return sb.ToString();
        }

        /// <summary>
        /// Compara dos Mascotas
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Mascota)
            {
                result = this == (Mascota)obj;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
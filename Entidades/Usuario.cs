namespace Entidades
{
    /// <summary>
    /// Clase que representa a un usuario
    /// </summary>
    public class Usuario
    {
        protected string Nombre;
        protected string Apellido;
        protected int Legajo;
        private string Correo;
        private string Clave;
        protected string Perfil;
        private bool accesoEliminar;
        private bool accesoCrear;
        private bool accesoModificar;


        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Usuario()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Legajo = 0;
            this.Correo = "";
            this.Clave = "";
            this.Perfil = "";
            this.accesoEliminar = false;
            this.accesoCrear = false;
            this.accesoModificar = false;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="legajo"></param>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <param name="perfil"></param>
        public Usuario(string nombre, string apellido, int legajo, string correo,
                        string clave, string perfil):this() 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        #region PROPIEDADES 
        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string nombre
        {
            get { return this.Nombre; }
            set { this.Nombre = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo apellido
        /// </summary>
        public string apellido
        {
            get { return this.Apellido; }
            set { this.Apellido = value;}
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo legajo
        /// </summary>
        public int legajo
        {
            get { return this.Legajo; }
            set { this.Legajo = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo correo
        /// </summary>
        public string correo
        {
            get { return this.Correo; }
            set { this.Correo = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo clave
        /// </summary>
        public string clave
        {
            get { return this.Clave; }
            set { this.Clave = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo perfil
        /// </summary>
        public string perfil
        {
            get { return this.Perfil; }
            set 
            {
                this.Perfil = value;
                switch (this.perfil)
                {
                    case "administrador":
                        this.accesoEliminar = true;
                        this.accesoCrear = true;
                        this.accesoModificar = true;
                        break;
                    case "supervisor":
                        this.accesoCrear = true;
                        this.accesoModificar = true;
                        break;
                }; 
            }
        }

        /// <summary>
        /// Propiedad de lectura del atributo accesoEliminar
        /// </summary>
        public bool AccesoEliminar { get { return this.accesoEliminar; }}

        /// <summary>
        /// Propiedad de lectura del atributo accesoCrear
        /// </summary>
        public bool AccesoCrear { get { return this.accesoCrear; } }

        /// <summary>
        /// Propiedad de lectura del atributo accesoModificar
        /// </summary>
        public bool AccesoModificar { get { return this.accesoModificar; } } 

        #endregion


    }
}
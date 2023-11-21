using Entidades;

namespace Formularios
{
    /// <summary>
    /// Clase que representa un formulario para listar datos
    /// </summary>
    public partial class FrmListadoDatos : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmListadoDatos()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        /// <summary>
        /// Metodo para cambiar el texto de la etiqueta lblTituloLista
        /// </summary>
        /// <param name="texto"></param>
        public void LblText(string texto)
        {
            this.lblTituloLista.Text = texto;
        }

        /// <summary>
        /// Crea un formulario segun el tipo de las herencias de Mascota
        /// </summary>
        /// <param name="indice">indice que representa a la mascota, a la que se le creara el
        ///                       formulario, dentro de la lista de mascotas</param>
        /// <param name="lista">lista de la que se sacara la mascota</param>
        /// <returns>El formulario creado</returns>
        protected FrmMostrarMascota CrearFrmDelAnimalSeleccionado(int indice, List<Mascota> lista)
        {
            FrmMostrarMascota frm1;

            if (lista[indice] is Perro)
            {
                Perro p = (Perro)lista[indice];

                frm1 = new FrmMostrarMascota(p);
            }
            else if (lista[indice] is Gato)
            {
                Gato g = (Gato)lista[indice];

                frm1 = new FrmMostrarMascota(g);
            }
            else
            {
                Exotico ex = (Exotico)lista[indice];

                frm1 = new FrmMostrarMascota(ex);
            }

            return frm1;
        }
        
        protected void FrmListadoDatos_Load(object sender, EventArgs e)
        {

        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que permite actualizar el listBox del formulario con las mascotas de la lista de mascotas
        /// </summary>
        /// <param name="lista">lista de mascotas que seran escritas en el listBox</param>
        protected void ActualizarVisor(List<Mascota> lista)
        {
            this.lstVisor.Items.Clear();

            foreach (Mascota masc in lista)
            {
                this.lstVisor.Items.Add(masc.Mostrar());
            }
        }
        /// <summary>
        /// Metodo que permite actualizar el listBox del formulario con los productos de la lista de productos
        /// </summary>
        /// <param name="lista">lista de productos que seran escritos en el listBox</param>
        protected void ActualizarVisor(List<Producto> lista)
        {
            this.lstVisor.Items.Clear();

            foreach (Producto pro in lista)
            {
                this.lstVisor.Items.Add(pro.ToString());
            }
        }
        /// <summary>
        /// Metodo que permite actualizar el listBox del formulario con los medicos
        /// de la lista de medicos veterios
        /// </summary>
        /// <param name="lista">lista de medicos que seran escritos en el listBox</param>
        protected void ActualizarVisor(List<MedicoVeterinario> lista)
        {
            this.lstVisor.Items.Clear();

            foreach (MedicoVeterinario masc in lista)
            {
                this.lstVisor.Items.Add(masc.Mostrar());
            }
        }

        /// <summary>
        /// Metodo que permite actualizar el listBox del formulario con los productos de la lista de turnos
        /// </summary>
        /// <param name="lista">lista de turnos que seran escritos en el listBox</param>
        protected void ActualizarVisor(List<Turno> lista)
        {
            this.lstVisor.Items.Clear();

            foreach (Turno st in lista)
            {
                this.lstVisor.Items.Add(st.Mostrar());
            }
        }

        /// <summary>
        /// Muestra un cuadro de mensaje de alerta con el mensaje de error proporcionado por la excepción.
        /// </summary>
        /// <param name="ex">La excepción que contiene el mensaje de error a mostrar.</param>
        public void AlertarError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
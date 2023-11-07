using Entidades;

namespace Formularios
{
    /// <summary>
    /// Representa un formulario para crear y eliminar turnos de la
    /// lista de turnos de la clase veterinaria 
    /// </summary>
    public partial class FrmCRUDTurnos : FrmListadoDatos
    {
        private Veterinaria veterinaria;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="veterinaria">instancia de la clase Veterinaria que contiene la lista de productos</param>
        public FrmCRUDTurnos(Veterinaria veterinaria)
        {
            InitializeComponent();
            base.LblText("Turnos");
            this.CenterToScreen();
            this.veterinaria = veterinaria;
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el atributo privado veterinaria
        /// </summary>
        public Veterinaria Veterinaria
        {
            get { return this.veterinaria; }
            set { this.veterinaria = value; }
        }

        /// <summary>
        /// Se ejecuta cuando carga el formulario, llama al metodo de la clase base ActualizarVisor para 
        /// actualizar el listBox del formulario con los turnos de la lista de turnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDTurnos_Load(object sender, EventArgs e)
        {
            base.ActualizarVisor(this.veterinaria.ListaTurnos);
        }

        /// <summary>
        /// Maneja el evento del boton Agregar para agregar a la 
        /// lista de turnos al turno seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmTurnos frmTurnos = new FrmTurnos(this.veterinaria.ListaMedicosVeterinarios,
                                                    this.veterinaria.ListaMascotas);
            frmTurnos.ShowDialog();

            if (frmTurnos.DialogResult == DialogResult.OK)
            {
                if (!this.veterinaria.ListaTurnos.Contains(frmTurnos.turno))
                {
                    this.veterinaria += frmTurnos.turno;
                    base.ActualizarVisor(this.veterinaria.ListaTurnos);
                }
                else
                {
                    MessageBox.Show("Ese turno no esta disponible");
                }
            }
        }

        /// <summary>
        /// Maneja el evento del boton Eliminar para eliminar de la 
        /// lista de turnos al turno seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = base.lstVisor.SelectedIndex;
            DialogResult respuesta;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return;
            }
            else
            {
                respuesta = MessageBox.Show($"¿Eliminar turno?:\n{this.veterinaria.ListaTurnos[indice]}", "Atención!",
                                                            MessageBoxButtons.OKCancel);
            }
            

            if (respuesta == DialogResult.OK)
            {
                if (this.veterinaria.ListaTurnos.Contains(this.veterinaria.ListaTurnos[indice]))
                {
                    this.veterinaria -= this.veterinaria.ListaTurnos[indice];
                    base.ActualizarVisor(this.veterinaria.ListaTurnos);
                }
                else
                {
                    MessageBox.Show("Ese turno no existe");
                }
            }
        }

        /// <summary>
        /// Manejador de eventos para manejar el cierre del formulario y establecer el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDTurnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
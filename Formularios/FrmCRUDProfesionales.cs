using Entidades;

namespace Formularios
{
    /// <summary>
    /// Representa un formulario que realiza un CRUD sobre los datos de la 
    /// lista de medicos veterinarios de la clase veterinaria 
    /// </summary>
    public partial class FrmCRUDProfesionales : FrmListadoDatos
    {
        private Veterinaria veterinaria;
        private AccesoDatosMedicosVeterinarios<MedicoVeterinario> accesoDatos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="veterinaria">instancia de la clase Veterinaria que contiene la lista de productos</param>
        public FrmCRUDProfesionales(Veterinaria veterinaria)
        {
            InitializeComponent();
            base.LblText("Profesionales");
            this.CenterToScreen();
            this.veterinaria = veterinaria;
            this.accesoDatos = new AccesoDatosMedicosVeterinarios<MedicoVeterinario>();
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
        /// actualizar el listBox del formulario con los medicos de la lista de medicos veterinarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProfesionales_Load(object sender, EventArgs e)
        {
            if (!this.radBtnSueldo.Checked)
            {
                this.radBtnDesc.Enabled = false;
                this.radBtnAscen.Enabled = false;
            }
            base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
        }

        /// <summary>
        /// Maneja el evento del boton Agregar para agregar a la 
        /// lista de medicos veterinarios al medico seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmProfesionales frmProfesionales = new FrmProfesionales();
            frmProfesionales.ShowDialog();

            if (frmProfesionales.DialogResult == DialogResult.OK)
            {
                if (!this.veterinaria.ListaMedicosVeterinarios.Contains(frmProfesionales.medico))
                {
                    this.veterinaria += frmProfesionales.medico;
                    if (this.accesoDatos.Agregar(frmProfesionales.medico))
                        MessageBox.Show("Profesional agregado");
                    base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
                }
                else
                {
                    MessageBox.Show("El profesional que esta intentando agregar ya existe");
                }
            }
        }

        /// <summary>
        /// Maneja el evento del boton Eliminar para Eliminar de la 
        /// lista de medicos veterinarios el medico seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = base.lstVisor.SelectedIndex;

            FrmProfesionales frm1;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista");
                return;
            }
            else
            {
                frm1 = new FrmProfesionales(this.veterinaria.ListaMedicosVeterinarios[indice]);
            }

            frm1.ShowDialog();
            if (frm1.DialogResult == DialogResult.OK)
            {
                if (this.veterinaria.ListaMedicosVeterinarios.Contains(frm1.medico))
                {
                    this.veterinaria -= frm1.medico;
                    if (this.accesoDatos.Eliminar(frm1.medico))
                        MessageBox.Show("Profesional eliminado");
                    base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
                }
                else
                {
                    MessageBox.Show("El profesional que esta intentando eliminar no existe");
                }
            }
        }

        /// <summary>
        /// Maneja el evento del boton Modificar para modificar de la 
        /// lista de medicos veterinarios el medico seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int indice = base.lstVisor.SelectedIndex;

            FrmProfesionales frm1;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista");
                return;
            }
            else
            {
                frm1 = new FrmProfesionales(this.veterinaria.ListaMedicosVeterinarios[indice]);
            }

            frm1.ShowDialog();
            if (frm1.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaMedicosVeterinarios[indice] = frm1.medico;
                if (this.accesoDatos.Modificar(frm1.medico))
                    MessageBox.Show("Profesional modificado");
                base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
            }
        }

        /// <summary>
        /// Manejador de eventos para manejar el cierre del formulario y establecer el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProfesionales_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Ordena la lista segun el nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.radBtnAscen.Enabled = false;
            this.radBtnDesc.Enabled = false;
            this.veterinaria.ListaMedicosVeterinarios.Sort(MedicoVeterinario.OrdenarPorNombre);
            base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
        }

        /// <summary>
        /// Activa los radioButton de ascendente y descendente para ordenar la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnSueldo_CheckedChanged(object sender, EventArgs e)
        {
            this.radBtnDesc.Enabled = true;
            this.radBtnAscen.Enabled = true;
        }

        /// <summary>
        /// Ordena la lista de manera ascendente segun la edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnSueldo.Checked)
            {
                this.veterinaria.ListaMedicosVeterinarios.Sort(MedicoVeterinario.OrdenarPorEdadDescendente);
                base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
            }
        }

        /// <summary>
        /// Ordena la lista de forma ascendente segun la edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnAscen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnSueldo.Checked)
            {
                this.veterinaria.ListaMedicosVeterinarios.Sort(MedicoVeterinario.OrdenarPorEdadAscendenten);
                base.ActualizarVisor(this.veterinaria.ListaMedicosVeterinarios);
            }
        }
    }
}
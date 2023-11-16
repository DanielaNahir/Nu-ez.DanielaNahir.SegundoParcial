using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    /// <summary>
    /// Clase que representa un formulario para contener un objeto de tipo MedicoVeterinario
    /// </summary>
    public partial class FrmProfesionales : Form
    {
        public MedicoVeterinario medico;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmProfesionales()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.medico = new MedicoVeterinario();
        }

        /// <summary>
        /// Constructor de la clase que recide un MedicoVeterinario
        /// </summary>
        /// <param name="medico">Medico que establece algunos datos del formulario</param>
        public FrmProfesionales(MedicoVeterinario medico) : this()
        {
            this.medico = medico;
            this.txtApellido.Text = medico.apellido;
            this.txtNombre.Text = medico.nombre;
            this.txtSueldo.Text = medico.Sueldo.ToString();
            this.ClickEspecialidad(medico);
        }

        private void FrmCRUDProfesionales_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que verifica que el usuario introduzca todos los datos necesarios del formulario
        /// </summary>
        /// <returns>Booleano que representa si el usuario ingreso los datos necesarios (true) o no (false)</returns>
        private bool Verificar()
        {
            bool resp = false;
            if (this.txtApellido.Text != "" && this.txtNombre.Text != ""
                && this.txtSueldo.Text != "")
            {
                if (this.radBtnCardiologo.Checked || this.radBtnCirujano.Checked
                    || this.radBtnClinico.Checked || this.radBtnDermatologo.Checked)
                {
                    try
                    {
                        float num = float.Parse(this.txtSueldo.Text);
                        if (num > 0)
                        {
                            resp = true;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese un precio correcto");
                        resp = false;
                    }

                }
                else
                {
                    MessageBox.Show("Debe elegir una especialidad");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }

            return resp;
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar, le asigna el medico creado
        /// a la intancia del medico del formulario y establece el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Verificar())
            {
                this.medico = new MedicoVeterinario(this.txtNombre.Text, this.txtApellido.Text, this.ParsearEspecialidad(),
                                                int.Parse(this.txtSueldo.Text));
            }
            else
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Parsea y deternima el valor de la especial seleccionada
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado EEspecialidad que representa la especialidad</returns>
        public EEspecialidad ParsearEspecialidad()
        {
            EEspecialidad espe = EEspecialidad.Clinico;
            if (this.radBtnCardiologo.Checked)
            {
                espe = EEspecialidad.Cardiologo;
            }
            else if (this.radBtnCirujano.Checked)
            {
                espe = EEspecialidad.Cirujano;
            }
            else if (this.radBtnDermatologo.Checked)
            {
                espe = EEspecialidad.Dermatologo;
            }
            return espe;
        }

        /// <summary>
        /// Metodo que relaciona un radioButton con el valor del enumerado de la especialidad
        /// del medico ingresado
        /// </summary>
        /// <param name="med">objeto de tipo MedicoVeterinario, se utiliza para relacionar los botones 
        ///                     con su tipo de especialidad</param>
        public void ClickEspecialidad(MedicoVeterinario med)
        {
            switch (med.especialidad)
            {
                case EEspecialidad.Cirujano:
                    this.radBtnCirujano.Checked = true;
                    break;
                case EEspecialidad.Clinico:
                    this.radBtnClinico.Checked = true;
                    break;
                case EEspecialidad.Cardiologo:
                    this.radBtnCardiologo.Checked = true;
                    break;
                case EEspecialidad.Dermatologo:
                    this.radBtnDermatologo.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Cancelar y establece el resultado del dialogo en Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

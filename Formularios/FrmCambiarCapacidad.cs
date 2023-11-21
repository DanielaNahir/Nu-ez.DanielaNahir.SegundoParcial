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
    public partial class FrmCambiarCapacidad : Form
    {
        public int capacidad;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmCambiarCapacidad()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Cambiar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.capacidad = int.Parse(this.txtCapacidad.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Ingrese una capacidad correcta");
            }

        }

        /// <summary>
        /// Manejador de eventos para el botón "Cancelar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmCambiarCapacidad_Load(object sender, EventArgs e)
        {

        }
    }
}

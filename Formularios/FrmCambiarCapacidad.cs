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
        public FrmCambiarCapacidad()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.capacidad = int.Parse(this.txtCapacidad.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Ingrese una edad correcto");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

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
    /// Clase que representa un formulario que muestra objetos
    /// </summary>
    public partial class FrmMostrarObjeto : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmMostrarObjeto()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        /// Metodo que permite cambiar el texto del boton Aceptar
        /// </summary>
        /// <param name="text"></param>
        public void CambiarTextBotonBase(string text)
        {
            this.btnAceptar.Text = text;
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar y establece el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Cancelar y establece el resultado del dialogo en Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

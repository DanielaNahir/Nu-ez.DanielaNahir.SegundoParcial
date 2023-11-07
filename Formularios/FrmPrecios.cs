using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Formularios
{
    /// <summary>
    /// Clase que representa un formulario para contener un objeto de tipo Producto
    /// </summary>
    public partial class FrmPrecios : Form
    {
        public Producto producto;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmPrecios()
        {
            InitializeComponent();
            this.producto = new Producto();
        }
        /// <summary>
        /// Constructor de la clase que recibe un objeto de tipo Producto y establece sus datos en el formulario
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto</param>
        public FrmPrecios(Producto producto) : this()
        {
            this.txtPrecio.Text = producto.Precio.ToString();
            this.txtNombre.Text = producto.Nombre;
        }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar, le asigna el producto creado
        /// a la intancia del producto del formulario y establece el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Verificar())
            {
                this.producto = new Producto(this.txtNombre.Text, float.Parse(this.txtPrecio.Text));
            }
            else
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Metodo que verifica que el usuario introduzca todos los datos necesarios del formulario
        /// </summary>
        /// <returns>Booleano que representa si el usuario ingreso los datos necesarios (true) o no (false)</returns>
        private bool Verificar()
        {
            bool resp = false;
            if (this.txtNombre.Text != "" && this.txtPrecio.Text != "")
            {
                try
                {
                    float num = float.Parse(this.txtPrecio.Text);
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
                MessageBox.Show("Ingrese los datos correspondientes");
            }

            return resp;
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Cancelar, establece el resultado del dialogo en Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

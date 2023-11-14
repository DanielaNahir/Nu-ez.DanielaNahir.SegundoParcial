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
    /// Representa un formulario que realiza un CRUD sobre los datos de la 
    /// lista de productos de la clase veterinaria 
    /// </summary>
    public partial class FrmCRUDPrecios : FrmListadoDatos
    {
        private Veterinaria veterinaria;
        private AccesoDatosProducto<Producto> accesoDatosProducto;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="veterinaria">instancia de la clase Veterinaria que contiene la lista de productos</param>
        public FrmCRUDPrecios(Veterinaria veterinaria)
        {
            InitializeComponent();
            this.CenterToScreen();
            base.LblText("Precios");
            this.veterinaria = veterinaria;
            this.accesoDatosProducto = new AccesoDatosProducto<Producto>();
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
        /// actualizar el listBox del formulario con los productos de la lista de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDPrecios_Load(object sender, EventArgs e)
        {
            base.ActualizarVisor(this.accesoDatosProducto.ObtenerTodosLosDatos());
        }

        /// <summary>
        /// Maneja el evento del boton Agregar para agregar a la 
        /// lista de productos el producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmPrecios frmPrecio = new FrmPrecios();
            frmPrecio.ShowDialog();

            if (frmPrecio.DialogResult == DialogResult.OK)
            {
                if (!frmPrecio.producto.VerificarIgualdad(this.veterinaria.ListaProductos))
                {
                    this.veterinaria += frmPrecio.producto;
                    if (this.accesoDatosProducto.Agregar(frmPrecio.producto))
                        MessageBox.Show("Producto agregado");
                    else
                        MessageBox.Show("No pudo agregarse el producto");

                    base.ActualizarVisor(this.accesoDatosProducto.ObtenerTodosLosDatos());
                }
                else
                {
                    MessageBox.Show("El producto que esta intentando agregar ya existe");
                }
            }
        }

        /// <summary>
        /// Maneja el evento del boton Modificar para modificar al producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int indice = base.lstVisor.SelectedIndex;

            FrmPrecios frmPrecio;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista");
                return;
            }
            else
            {
                frmPrecio = new FrmPrecios(this.veterinaria.ListaProductos[indice]);
            }

            frmPrecio.ShowDialog();
            if (frmPrecio.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaProductos[indice] = frmPrecio.producto;
                if (this.accesoDatosProducto.Modificar(frmPrecio.producto))
                    MessageBox.Show("Producto modificado");
                
                base.ActualizarVisor(this.accesoDatosProducto.ObtenerTodosLosDatos());
            }
        }

        /// <summary>
        /// Maneja el evento del boton Eliminar para eliminar de la 
        /// lista de productos al producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = base.lstVisor.SelectedIndex;

            FrmPrecios frmPrecio;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista");
                return;
            }
            else
            {
                frmPrecio = new FrmPrecios(this.veterinaria.ListaProductos[indice]);
            }

            frmPrecio.ShowDialog();
            if (frmPrecio.DialogResult == DialogResult.OK)
            {
                if (frmPrecio.producto.VerificarIgualdad(this.veterinaria.ListaProductos))
                {
                    this.veterinaria -=frmPrecio.producto;
                    if (this.accesoDatosProducto.Eliminar(frmPrecio.producto))
                        MessageBox.Show("Producto eliminado");
                    base.ActualizarVisor(this.accesoDatosProducto.ObtenerTodosLosDatos());
                }
                else
                {
                    MessageBox.Show("El producto que esta intentando eliminar no existe");
                }
            }
        }

        /// <summary>
        /// Manejador de eventos para manejar el cierre del formulario y establecer el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDPrecios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

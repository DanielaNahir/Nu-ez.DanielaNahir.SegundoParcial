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
    /// Clase que representa un formularios para agregar una nueva mascota internada a una 
    /// instancia de una clase veterinaria
    /// </summary>
    public partial class FrmInternacion : Form
    {
        private List<Mascota> listaMascotas;
        public Mascota mascota;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="listaMascotas">lista de mascotas</param>
        public FrmInternacion(List<Mascota> listaMascotas)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.listaMascotas = listaMascotas;
            this.mascota = new Perro();
        }

        /// <summary>
        /// Crea un formulario segun el tipo de las herencias de Mascota
        /// </summary>
        /// <param name="indice">indice que representa a la mascota, a la que se le creara el
        ///                       formulario, dentro de la lista de mascotas</param>
        /// <returns>El formulario creado</returns>
        private FrmMostrarMascota CrearFrmDelAnimalSeleccionado(int indice)
        {
            FrmMostrarMascota frm1;

            if (this.listaMascotas[indice] is Perro)
            {
                Perro p = (Perro)this.listaMascotas[indice];

                frm1 = new FrmMostrarMascota(p);
            }
            else if (this.listaMascotas[indice] is Gato)
            {
                Gato g = (Gato)this.listaMascotas[indice];

                frm1 = new FrmMostrarMascota(g);
            }
            else
            {
                Exotico ex = (Exotico)this.listaMascotas[indice];

                frm1 = new FrmMostrarMascota(ex);
            }

            return frm1;
        }

        /// <summary>
        /// Metodo que permite actualizar el listBox del formulario con las mascotas de la lista de mascotas
        /// </summary>
        private void ActualizarVisor()
        {
            this.lstVisor.Items.Clear();

            foreach (Mascota masc in this.listaMascotas)
            {
                this.lstVisor.Items.Add((string)masc);
            }
        }


        /// <summary>
        /// SE activa al hacer clic en el botón "Seleccionar"
        /// Permite al usuario seleccionar una mascota de la lista y actualiza la instancia
        /// de mascota de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            FrmMostrarMascota frm1;

            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar una mascota de la lista");
                return;
            }
            else
            {
                frm1 = this.CrearFrmDelAnimalSeleccionado(indice);
            }

            frm1.ShowDialog();
            if (frm1.DialogResult == DialogResult.OK)
            {
                this.mascota = frm1.mascota;
                this.DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// Se ejecuta cuando carga el formulario, llama al metodo ActualizarVisor para 
        /// actualizar el listBox del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDInternacion_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }

        /// <summary>
        /// Manejador de eventos para manejar el cierre del formulario y establecer el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCRUDInternacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

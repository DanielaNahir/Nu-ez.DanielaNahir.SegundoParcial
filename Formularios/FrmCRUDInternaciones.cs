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
    /// Representa un formulario que realiza un CRUD sobre los datos de la 
    /// lista de mascotas internadas de la clase veterinaria 
    /// </summary>
    public partial class FrmCRUDInternaciones : FrmListadoDatos
    {
        private Veterinaria veterinaria;
        private AccesoDatosListaMascotas<Mascota> accesoDatos;
        public event delegadoFalla falla;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="veterinaria">instancia de la clase Veterinaria que contiene la lista de mascotas</param>
        public FrmCRUDInternaciones(Veterinaria veterinaria)
        {
            InitializeComponent();
            this.LblText("Mascotas Internadas");
            this.CenterToScreen();
            this.veterinaria = veterinaria;
            this.accesoDatos = new AccesoDatosListaMascotas<Mascota>("listaMascotasInternadas");
            this.falla += new delegadoFalla(base.AlertarError);
            this.btnCapacidad.Click += new EventHandler(this.CambiarCapacidad);
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
        /// actualizar el listBox del formulario con las mascotas de la lista de mascotas internadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInternaciones_Load(object sender, EventArgs e)
        {
            base.ActualizarVisor(this.veterinaria.ListaMascotasInternadas);
            Task tareaCambiarLbl = Task.Run(() => this.CambiarTextoLBL(this.veterinaria.CapacidadInternaciones));
        }

        public void CambiarTextoLBL(int capacidad)
        {
            if (this.lblCapacidad.InvokeRequired)
            {
                delegadoCambiarCapacidad delegado = new delegadoCambiarCapacidad(CambiarTextoLBL);

                this.lblCapacidad.Invoke(delegado, capacidad);
            }
            else
            {
                this.lblCapacidad.Text = $"Capacidad: {this.veterinaria.ListaMascotasInternadas.Count()}" +
                    $" de {this.veterinaria.CapacidadInternaciones}";
                if(this.veterinaria.ListaMascotasInternadas.Count() == this.veterinaria.CapacidadInternaciones)
                    this.lblCapacidad.BackColor = Color.Red;
                else
                    this.lblCapacidad.BackColor = Color.Transparent;
            }
        }

        

        /// <summary>
        /// Maneja el evento del boton Agregar para agregar a la 
        /// lista de mascotas internadas la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.veterinaria.UsuarioActual.AccesoCrear)
            {
                FrmInternacion frmAgregarMascota = new FrmInternacion(this.veterinaria.ListaMascotas);
                frmAgregarMascota.ShowDialog();

                if (frmAgregarMascota.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        if (!frmAgregarMascota.mascota.VerificarIgualdad(this.veterinaria.ListaMascotasInternadas))
                        {
                            if (this.accesoDatos.Agregar(frmAgregarMascota.mascota))
                                MessageBox.Show("Mascota agregada");
                            this.veterinaria.AgregarMascotaInternacion(frmAgregarMascota.mascota);
                            this.ActualizarVisor(this.veterinaria.ListaMascotasInternadas);
                            Task tareaCambiarLbl = Task.Run(() => this.CambiarTextoLBL(this.veterinaria.CapacidadInternaciones));
                        }
                        else
                        {
                            MessageBox.Show("La mascota que quiere agregar ya existe");
                        }
                    }
                    catch (EspacioInternacionException)
                    {
                        MessageBox.Show($"No hay espacio disponible!");
                    }
                    catch (BaseDeDatosSQLException ex)
                    {
                        this.falla.Invoke(ex);
                    }
                    
                }
            }
            else
                MessageBox.Show("Su usuario no tiene los permisos necesarios para esta operación");

        }

        /// <summary>
        /// Maneja el evento del boton Eliminar para eliminar de la 
        /// lista de mascotas internadas la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.veterinaria.UsuarioActual.AccesoEliminar)
            {
                int indice = this.lstVisor.SelectedIndex;

                FrmMostrarMascota frmMostrarMascota;

                if (indice == -1)
                {
                    MessageBox.Show("Debe seleccionar una mascota de la lista");
                    return;
                }
                else
                {
                    frmMostrarMascota = base.CrearFrmDelAnimalSeleccionado(indice, this.veterinaria.ListaMascotasInternadas);
                }

                frmMostrarMascota.ShowDialog();
                if (frmMostrarMascota.DialogResult == DialogResult.OK)
                {
                    if (frmMostrarMascota.mascota.VerificarIgualdad(this.veterinaria.ListaMascotasInternadas))
                    {
                        try
                        {
                            if (this.accesoDatos.Eliminar(frmMostrarMascota.mascota))
                                MessageBox.Show("Mascota eliminada");
                            this.veterinaria.ListaMascotasInternadas.RemoveAt(indice);
                            base.ActualizarVisor(this.veterinaria.ListaMascotasInternadas);
                            Task tareaCambiarLbl = Task.Run(() => this.CambiarTextoLBL(this.veterinaria.CapacidadInternaciones));
                        }
                        catch (BaseDeDatosSQLException ex)
                        {
                            this.falla.Invoke(ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La mascota que quiere eliminar no existe");
                    }
                }
            }
            else
                MessageBox.Show("Su usuario no tiene los permisos necesarios para esta operación");

        }

        /// <summary>
        /// Manejador de eventos para manejar el cierre del formulario y establecer el resultado del dialogo en OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInternaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CambiarCapacidad(object? sender, EventArgs e)
        {
            FrmCambiarCapacidad frmCambiarCapacidad = new FrmCambiarCapacidad();
            frmCambiarCapacidad.ShowDialog();

            if (frmCambiarCapacidad.DialogResult == DialogResult.OK)
            {
                this.veterinaria.CapacidadInternaciones = frmCambiarCapacidad.capacidad;
                Task tareaCambiarLbl = Task.Run(() => this.CambiarTextoLBL(this.veterinaria.CapacidadInternaciones));
            }
        }
    }
}

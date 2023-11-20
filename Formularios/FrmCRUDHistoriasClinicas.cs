using Entidades;
using System.Xml.Serialization;
using System.Xml;

namespace Formularios
{
    /// <summary>
    /// Representa un formulario que realiza un CRUD sobre los datos de la lista de mascotas de la clase veterinaria 
    /// </summary>
    public partial class FrmCRUDHistoriasClinicas : FrmListadoDatos
    {
        private Veterinaria veterinaria;
        private AccesoDatosListaMascotas<Mascota> accesoDatos;
        public event delegadoFalla falla;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="veterinaria">instancia de la clase Veterinaria que contiene la lista de mascotas</param>
        public FrmCRUDHistoriasClinicas(Veterinaria veterinaria)
        {
            InitializeComponent();
            base.LblText("Historias clinicas");
            this.CenterToScreen();
            this.veterinaria = veterinaria;
            this.accesoDatos = new AccesoDatosListaMascotas<Mascota>("listaMascotas");
            this.falla += new delegadoFalla(base.AlertarError);
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
        /// actualizar el listBox del formulario con las mascotas de la lista de mascotas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistoriasClinicasMascotas_Load(object sender, EventArgs e)
        {
            if (!this.radBtnEdad.Checked)
            {
                this.radBtnDesc.Enabled = false;
                this.radBtnAscen.Enabled = false;
            }
            base.ActualizarVisor(this.veterinaria.ListaMascotas);
        }

        /// <summary>
        /// Maneja el evento del boton Modificar para modificar la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (this.Veterinaria.UsuarioActual.AccesoModificar)
            {
                int indice = base.lstVisor.SelectedIndex;

                FrmMostrarMascota frm1;

                if (indice == -1)
                {
                    MessageBox.Show("Debe seleccionar una mascota de la lista");
                    return;
                }
                else
                {
                    frm1 = base.CrearFrmDelAnimalSeleccionado(indice, this.veterinaria.ListaMascotas);
                }

                frm1.ShowDialog();
                if (frm1.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        if (this.accesoDatos.Modificar(frm1.mascota))
                            MessageBox.Show("Mascota modificada");
                        this.veterinaria.ListaMascotas[indice] = frm1.mascota;
                        base.ActualizarVisor(this.veterinaria.ListaMascotas);
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
        /// Maneja el evento del boton Eliminar para eliminar de la lista de mascotas la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.veterinaria.UsuarioActual.AccesoEliminar)
            {
                int indice = base.lstVisor.SelectedIndex;

                FrmMostrarMascota frmMostrarMascota;

                if (indice == -1)
                {
                    MessageBox.Show("Debe seleccionar una mascota de la lista");
                    return;
                }
                else
                {
                    frmMostrarMascota = base.CrearFrmDelAnimalSeleccionado(indice, this.veterinaria.ListaMascotas);
                }

                frmMostrarMascota.ShowDialog();
                if (frmMostrarMascota.DialogResult == DialogResult.OK)
                {
                    if (frmMostrarMascota.mascota.VerificarIgualdad(this.veterinaria.ListaMascotas))
                    {
                        try
                        {
                            if (this.accesoDatos.Eliminar(frmMostrarMascota.mascota))
                                MessageBox.Show("Mascota eliminada");
                            this.veterinaria -= frmMostrarMascota.mascota;
                            base.ActualizarVisor(this.veterinaria.ListaMascotas);
                        }
                        catch (BaseDeDatosSQLException ex)
                        {
                            this.falla.Invoke(ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La historia clinica que esta intentando eliminar no existe");
                    }
                }
            }
            else
                MessageBox.Show("Su usuario no tiene los permisos necesarios para esta operación");
        }

        /// <summary>
        /// Maneja el evento del boton Agregar para agregar a la lista de mascotas la mascota seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.veterinaria.UsuarioActual.AccesoCrear)
            {
                FrmHistoriasClinicas frmAgregarMascota = new FrmHistoriasClinicas();
                frmAgregarMascota.ShowDialog();

                if (frmAgregarMascota.DialogResult == DialogResult.OK)
                {
                    if (!frmAgregarMascota.mascota.VerificarIgualdad(this.veterinaria.ListaMascotas))
                    {
                        try
                        {
                            if (this.accesoDatos.Agregar(frmAgregarMascota.mascota))
                                MessageBox.Show("Mascota agregada");
                            this.veterinaria += frmAgregarMascota.mascota;
                            base.ActualizarVisor(this.veterinaria.ListaMascotas);
                        }
                        catch (BaseDeDatosSQLException ex)
                        {
                            this.falla.Invoke(ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La historia clinica que esta intentando crear ya existe");
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
        private void FrmHistoriasClinicasMascotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Activa los radioButton de ascendente y descendente para ordenar la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnEdad_CheckedChanged(object sender, EventArgs e)
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
            if (this.radBtnEdad.Checked)
            {
                this.veterinaria.ListaMascotas.Sort(Mascota.OrdenarPorEdadDescendente);
                base.ActualizarVisor(this.veterinaria.ListaMascotas);
            }
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
            this.veterinaria.ListaMascotas.Sort(Mascota.OrdenarPorNombre);
            base.ActualizarVisor(this.veterinaria.ListaMascotas);
        }

        /// <summary>
        /// Ordena la lista de forma ascendente segun la edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnAscen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnEdad.Checked)
            {
                this.veterinaria.ListaMascotas.Sort(Mascota.OrdenarPorEdadAscendenten);
                base.ActualizarVisor(this.veterinaria.ListaMascotas);
            }
        }
    }
}
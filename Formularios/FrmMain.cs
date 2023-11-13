using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using Entidades;
using System.IO;

namespace Formularios
{
    /// <summary>
    /// Menu principal de la aplicacion
    /// </summary>
    public partial class FrmMain : Form
    {
        private Usuario usuario;
        private Veterinaria veterinaria;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.usuario = new Usuario();
            this.veterinaria = new Veterinaria();
            this.lblHora.Text = DateTime.Now.Date.ToShortDateString();
        }
        /// <summary>
        /// Constructor que recibe y almacena un parametro de tipo Usuario
        /// </summary>
        /// <param name="usuario"></param>
        public FrmMain(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.lblNombre.Text = $"Usuario: {this.usuario.nombre} {this.usuario.apellido}";
        }

        /// <summary>
        /// Se ejecuta cuando carga el formulario, deserializa el archivo XML con los datos de la aplicacion
        /// y llama al metodo ActualizarHistorial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.ActualizarHistorial(this.usuario);
            this.DeserializarXML();
            this.MostrarTurnosDelDia();
        }

        /// <summary>
        /// Actualiza el archivo Usuarios.log con el nombre del usuario y la hora de conexion
        /// </summary>
        /// <param name="usu"></param>
        private void ActualizarHistorial(Usuario usu)
        {
            string path = Environment.CurrentDirectory;

            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (StreamWriter swriter = new StreamWriter(path + @"\Usuarios.log", true))
                {
                    swriter.WriteLine($"{this.usuario.nombre} {this.usuario.apellido} {DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Maneja el evento del click sobre el boton Conexiones y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConexiones_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.ShowDialog();
        }

        /// <summary>
        /// Maneja el evento del click sobre el boton Historial Clinico y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            FrmCRUDHistoriasClinicas frmHistorial = new FrmCRUDHistoriasClinicas(this.veterinaria);
            frmHistorial.ShowDialog();

            if (frmHistorial.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaMascotas = frmHistorial.Veterinaria.ListaMascotas;
            }
        }

        /// <summary>
        /// Se ejecuta cuando se cierra el formulario y muestra un mensaje de confirmación para salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de salir de la apricación?\nLos datos " +
                                     "que no haya guardado se perderan", "Atención!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        ///  Maneja el evento del click sobre el boton Profesionales y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            FrmCRUDProfesionales frmProfesionales = new FrmCRUDProfesionales(this.veterinaria);
            frmProfesionales.ShowDialog();

            if (frmProfesionales.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaMedicosVeterinarios = frmProfesionales.Veterinaria.ListaMedicosVeterinarios;
            }
        }

        /// <summary>
        ///  Maneja el evento del click sobre el boton Precios y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrecios_Click(object sender, EventArgs e)
        {
            FrmCRUDPrecios frmPrecios = new FrmCRUDPrecios(this.veterinaria);
            frmPrecios.ShowDialog();

            if (frmPrecios.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaProductos = frmPrecios.Veterinaria.ListaProductos;
            }
        }

        /// <summary>
        /// Maneja el evento del click sobre el boton Historial Turnos y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorialTurnos_Click(object sender, EventArgs e)
        {
            FrmCRUDTurnos frmTurnos = new FrmCRUDTurnos(this.veterinaria);
            frmTurnos.ShowDialog();

            if (frmTurnos.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaTurnos = frmTurnos.Veterinaria.ListaTurnos;
            }
            this.MostrarTurnosDelDia();
        }

        /// <summary>
        /// Maneja el evento del click sobre el boton Internaciones y abre otro formulario relacionado a el mismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternaciones_Click(object sender, EventArgs e)
        {
            FrmCRUDInternaciones frmInternaciones = new FrmCRUDInternaciones(this.veterinaria);
            frmInternaciones.ShowDialog();

            if (frmInternaciones.DialogResult == DialogResult.OK)
            {
                this.veterinaria.ListaMascotasInternadas = frmInternaciones.Veterinaria.ListaMascotasInternadas;
            }
        }

        /// <summary>
        /// Serializa los datos en el archivo Veterinaria.xml
        /// </summary>
        private void SerializarXML()
        {
            string path = Environment.CurrentDirectory;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path += @"..\..\..\..\Veterinaria.xml", System.Text.Encoding.UTF8))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(Veterinaria));
                    serial.Serialize(writer, this.veterinaria);
                }
                MessageBox.Show("Datos guardados con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Deserializa los datos del archivo Veterinaria.xml sore la aplicacion
        /// </summary>
        private void DeserializarXML()
        {
            string path = Environment.CurrentDirectory;
            try
            {
                using (XmlTextReader reader = new XmlTextReader(path += @"..\..\..\..\Veterinaria.xml"))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(Veterinaria));
                    this.veterinaria = (Veterinaria)serial.Deserialize(reader);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// llama al método SerializarXML para guardar la información en un archivo XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.SerializarXML();
        }

        /// <summary>
        /// Actualiza el listBox de turnos con los turnos exixtentes en la veterinaria
        /// </summary>
        private void MostrarTurnosDelDia()
        {
            this.lstVisor.Items.Clear();

            foreach (Turno turn in this.veterinaria.ListaTurnos)
            {
                if (turn.Fecha.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    this.lstVisor.Items.Add(turn.Mostrar());
                }
            }
        }

        /// <summary>
        /// Serializa los datos en el archivo Veterinaria.xml
        /// </summary>
        private void GuardarBaseDeDatos()
        {
            string path = Environment.CurrentDirectory;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path += @"..\..\..\..\Veterinaria.xml", System.Text.Encoding.UTF8))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(Veterinaria));
                    serial.Serialize(writer, this.veterinaria);
                }
                MessageBox.Show("Datos guardados con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
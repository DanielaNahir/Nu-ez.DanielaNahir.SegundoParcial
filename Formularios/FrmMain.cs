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
        private FrmLog fromlog;
        private event delegadoSaveDialog guardar;
        private string path;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.veterinaria = new Veterinaria();
            this.lblHora.Text = DateTime.Now.Date.ToShortDateString();
            this.usuario = new Usuario();
            this.fromlog = new FrmLog();
            this.guardar += new delegadoSaveDialog(this.GuardarSaveDialog);
            this.path = Environment.CurrentDirectory + @"..\..\..\..\Veterinaria.xml";
        }
        ///// <summary>
        ///// Constructor que recibe y almacena un parametro de tipo Usuario y el frmLog
        ///// </summary>
        ///// <param name="usuario"></param>
        public FrmMain(Usuario usuario, FrmLog frmlog) : this()
        {
            this.DeserializarXML();
            this.usuario = usuario;
            this.veterinaria.UsuarioActual = usuario;
            this.fromlog = frmlog;
            this.lblNombre.Text = $"Usuario: {this.veterinaria.UsuarioActual.nombre} {this.veterinaria.UsuarioActual.apellido}";
        }

        /// <summary>
        /// Se ejecuta cuando carga el formulario, deserializa el archivo XML con los datos de la aplicacion
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.ActualizarHistorial(this.usuario);
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
            this.SerializarXML(this.path);
            DialogResult respuesta = MessageBox.Show("¿Está seguro de salir de la aplicación?", "Atención!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.fromlog.Show();
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
        private void SerializarXML(string path)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(Veterinaria));
                    serial.Serialize(writer, this.veterinaria);
                }
                //MessageBox.Show("Datos guardados con exito");
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
        private void GuardarSaveDialog(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
                saveFileDialog.Title = "Guardar copia en XML de los datos";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;

                    this.SerializarXML(path);

                    MessageBox.Show("Copia de datos guardada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la copia de datos: " + ex.Message);
            }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar.Invoke(sender, e);
        }

    }
}
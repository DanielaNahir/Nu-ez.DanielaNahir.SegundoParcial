using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.IO;

namespace Formularios
{

    /// <summary>
    /// Clase que representa un formulario para mostrar un historial de usuarios
    /// almacenados en el archivo "Usuarios.log"
    /// </summary>
    public partial class FrmHistorial : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmHistorial()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.lstHistorial.Items.Clear();
        }

        /// <summary>
        /// Carga y muestra el historial de usuarios al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistoria_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string line;

            try
            {
                using (StreamReader sreader = new StreamReader(path+ @"\Usuarios.log"))
                {
                    while ((line = sreader.ReadLine()) != null)
                    {
                        this.lstHistorial.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
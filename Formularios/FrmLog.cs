using System.Text.Json;
using Entidades;
using System;

namespace Formularios
{
    

    /// <summary>
    /// Formulario de registro 
    /// Pide introducir un correo y una contraseña
    /// Si son coincidentes con algun usuario cargado en el archivo MOCK_DATA.json
    /// Se le permitira el ingreso
    /// </summary>
    public partial class FrmLog : Form
    {
        private List<Usuario> usuarios;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FrmLog()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
            this.CenterToScreen();
        }

        /// <summary>
        /// Se deserializan los datos con los que se compararan los datos ingresados con los usuarios 
        /// Existentes en el archivo MOCK_DATA.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLog_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            try
            {
                using (System.IO.StreamReader sreader = new StreamReader(path + @"..\..\..\..\MOCK_DATA.json"))
                {
                    string stringJson = sreader.ReadToEnd();
                    this.usuarios = (List<Usuario>)JsonSerializer.Deserialize(stringJson, typeof(List<Usuario>));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"nou: {ex.Message}");
            }
        }


        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Verifica que los datos ingresados sean coincidentes con los usuarios existentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.lblIncorrecto.Visible = false;

            int cont = 0;

            if (this.txtMail.Text != "" && this.txtContraseña.Text != "")
            {
                foreach (Usuario usu in this.usuarios)
                {
                    cont++;
                    if (usu.correo == this.txtMail.Text && usu.clave == this.txtContraseña.Text)
                    {
                        //this.lblIncorrecto.Visible = false;
                        Task tareaMostrarError = Task.Run(this.CambiarVisibilidadLBL);
                        FrmMain frmMain = new FrmMain(usu, this);
                        frmMain.Show();
                        this.txtContraseña.Clear();
                        this.txtMail.Clear();
                        this.Hide();
                        break;
                    }
                    else if (cont == this.usuarios.Count())
                    {
                        this.lblIncorrecto.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }

        public void CambiarVisibilidadLBL()
        {
            if (this.lblIncorrecto.InvokeRequired)
            {
                delegadoMostrarLBL delegado = new delegadoMostrarLBL(CambiarVisibilidadLBL);
                this.lblIncorrecto.Invoke(delegado);
            }
            else
                this.lblIncorrecto.Visible = false;
        }
    }

}
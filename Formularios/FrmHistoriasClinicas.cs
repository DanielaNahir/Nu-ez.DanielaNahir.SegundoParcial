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
    /// Clase que representa un formularios para agregar una nueva mascota a una 
    /// instancia de una clase veterinaria
    /// </summary>
    public partial class FrmHistoriasClinicas : Form
    {

        public Mascota mascota;

        private List<RadioButton> radioButtonsPerro;
        private List<RadioButton> radioButtonsGato;
        private List<RadioButton> radioButtonsExotico;

        private bool perro;
        private bool gato;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmHistoriasClinicas()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.radioButtonsPerro = new List<RadioButton>();
            this.radioButtonsGato = new List<RadioButton>();
            this.radioButtonsExotico = new List<RadioButton>();
            this.perro = false;
            this.gato = false;
            this.mascota = new Perro();
        }

        /// <summary>
        /// Carga y muestra los elementos al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarMascota_Load(object sender, EventArgs e)
        {
            this.SepararBotones();
            this.HabilitacionBotones(this.radioButtonsExotico, false);
            this.HabilitacionBotones(this.radioButtonsGato, false);
            this.HabilitacionBotones(this.radioButtonsPerro, false);
        }

        /// <summary>
        /// Habilita o deshabilita una lista de botones RadioButton
        /// </summary>
        /// <param name="lista">Lista de botones RadioButton que se desea habilitar o deshabilitar</param>
        /// <param name="habilitacion">Booleano que determina si se deben habilitar (true) o deshabilitar (false)</param>
        private void HabilitacionBotones(List<RadioButton> lista, bool habilitacion)
        {
            if (habilitacion)
            {
                foreach (RadioButton boton in lista)
                {
                    boton.Enabled = true;
                }
            }
            else
            {
                foreach (RadioButton boton in lista)
                {
                    boton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Separa los botones segun la lista a la que pertenecen
        /// </summary>
        private void SepararBotones()
        {
            this.radioButtonsPerro.Add(this.radBtnSiMuerde);
            this.radioButtonsPerro.Add(this.radBtnNoMuerde);
            this.radioButtonsPerro.Add(this.radBtnMestizo);
            this.radioButtonsPerro.Add(this.radBtnLabrador);
            this.radioButtonsPerro.Add(this.radBtnBulldog);
            this.radioButtonsPerro.Add(this.radBtnCaniche);
            this.radioButtonsPerro.Add(this.radBtnGolden);

            this.radioButtonsGato.Add(this.radBtnSiRasguña);
            this.radioButtonsGato.Add(this.radBtnNoRasguña);
            this.radioButtonsGato.Add(this.radBtnEuropeo);
            this.radioButtonsGato.Add(this.radBtnPersa);
            this.radioButtonsGato.Add(this.radBtnSiames);
            this.radioButtonsGato.Add(this.radBtnSiberiano);

            this.radioButtonsExotico.Add(this.radBtnCobayo);
            this.radioButtonsExotico.Add(this.radBtnHamster);
            this.radioButtonsExotico.Add(this.radBtnHuron);
            this.radioButtonsExotico.Add(this.radBtnTortuga);
            this.radioButtonsExotico.Add(this.radBtnAlimEsp);
            this.radioButtonsExotico.Add(this.radBtnCereales);
            this.radioButtonsExotico.Add(this.radBtnVegetales);

        }

        /// <summary>
        /// SE activa cuando se selecciona un gato como tipo de mascota
        /// Habilita los botones relacionados con los gatos y deshabilita los
        /// botones relacionados con perros y mascotas exóticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnGato_CheckedChanged(object sender, EventArgs e)
        {
            this.perro = false;
            this.gato = true;
            this.HabilitacionBotones(this.radioButtonsExotico, false);
            this.HabilitacionBotones(this.radioButtonsGato, true);
            this.HabilitacionBotones(this.radioButtonsPerro, false);
        }

        /// <summary>
        /// Se activa cuando se selecciona un exotico como tipo de mascota
        /// Habilita los botones relacionados con los exoticos y deshabilita los
        /// botones relacionados con perros y gatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnExotico_CheckedChanged(object sender, EventArgs e)
        {
            this.perro = false;
            this.gato = false;
            this.HabilitacionBotones(this.radioButtonsExotico, true);
            this.HabilitacionBotones(this.radioButtonsGato, false);
            this.HabilitacionBotones(this.radioButtonsPerro, false);
        }

        /// <summary>
        /// Se activa cuando se selecciona un perro como tipo de mascota
        /// Habilita los botones relacionados con los perros y deshabilita los
        /// botones relacionados con gatos y exóticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnPerro_CheckedChanged(object sender, EventArgs e)
        {
            this.perro = true;
            this.gato = false;
            this.HabilitacionBotones(this.radioButtonsExotico, false);
            this.HabilitacionBotones(this.radioButtonsGato, false);
            this.HabilitacionBotones(this.radioButtonsPerro, true);
        }


        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar
        /// Crea una nueva instancia de una de las herencias de la clase Mascota con los
        /// datos ingresados por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool booleano = false;

            if (this.Verificar())
            {
                if (this.perro)
                {
                    if (this.radBtnSiMuerde.Checked)
                    {
                        booleano = true;
                    }
                    this.mascota = new Perro(this.txtNomMasc.Text, int.Parse(this.txtEdadMasc.Text),
                                        this.txtNomDueño.Text, this.txtApellDueño.Text, booleano, this.ParsearRazaPerro());
                }
                else if (this.gato)
                {
                    if (this.radBtnSiRasguña.Checked)
                    {
                        booleano = true;
                    }
                    this.mascota = new Gato(this.txtNomMasc.Text, int.Parse(this.txtEdadMasc.Text),
                                        this.txtNomDueño.Text, this.txtApellDueño.Text, this.ParsearRazaGato(), booleano);
                }
                else
                {
                    this.mascota = new Exotico(this.txtNomMasc.Text, int.Parse(this.txtEdadMasc.Text),
                                        this.txtNomDueño.Text, this.txtApellDueño.Text, this.ParsearExotico(),
                                        this.ParsearAlimentacion());
                }
            }
            else
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Parsea y deternima el valor de la raza de perro seleccionada por el usuario
        /// /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado ERazaPerro que representa la raza del perro</returns>
        public ERazaPerro ParsearRazaPerro()
        {
            ERazaPerro raza = ERazaPerro.Mestizo;
            if (this.radBtnBulldog.Checked)
            {
                raza = ERazaPerro.Bulldog;
            }
            else if (this.radBtnCaniche.Checked)
            {
                raza = ERazaPerro.Caniche;
            }
            else if (this.radBtnGolden.Checked)
            {
                raza = ERazaPerro.Golden;
            }
            else if (this.radBtnLabrador.Checked)
            {
                raza = ERazaPerro.Labrador;
            }
            return raza;
        }

        /// <summary>
        /// Parsea y deternima el valor de la raza de gato seleccionada por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado ERazaGato que representa la raza del gato</returns>
        public ERazaGato ParsearRazaGato()
        {
            ERazaGato raza = ERazaGato.Europeo;
            if (this.radBtnSiberiano.Checked)
            {
                raza = ERazaGato.Siberiano;
            }
            else if (this.radBtnSiames.Checked)
            {
                raza = ERazaGato.Siames;
            }
            else if (this.radBtnPersa.Checked)
            {
                raza = ERazaGato.Persa;
            }
            return raza;
        }

        /// <summary>
        /// Parsea y deternima el valor del animal seleccionado por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado EExotico que representa el animal exotico</returns>
        public EExotico ParsearExotico()
        {
            EExotico animal = EExotico.Hamster;
            if (this.radBtnHuron.Checked)
            {
                animal = EExotico.Huron;
            }
            else if (this.radBtnCobayo.Checked)
            {
                animal = EExotico.Cobayo;
            }
            else if (this.radBtnTortuga.Checked)
            {
                animal = EExotico.Tortuga;
            }
            return animal;
        }

        /// <summary>
        /// Parsea y deternima el valor de la alimentacion seleccionada por el usuario
        /// segun el boton seleccionado
        /// </summary>
        /// <returns>Un valor del enumerado EAlimento que representa la alimentacion</returns>
        public EAlimento ParsearAlimentacion()
        {
            EAlimento alimento = EAlimento.Especial;
            if (this.radBtnCereales.Checked)
            {
                alimento = EAlimento.Cereales;
            }
            else if (this.radBtnVegetales.Checked)
            {
                alimento = EAlimento.Vegetales;
            }
            return alimento;
        }

        /// <summary>
        /// Verifica que el usuario haya completado todos los campos necesarios
        /// </summary>
        /// <returns>Booleano que representa si todos los campos fueron rellenados (true) o no (false)</returns>
        private bool Verificar()
        {
            bool resp = false;
            if (this.txtNomDueño.Text != "" && this.txtApellDueño.Text != ""
                && this.txtEdadMasc.Text != "" && this.txtNomMasc.Text != "")
            {
                try
                {
                    float num = float.Parse(this.txtEdadMasc.Text);
                    if (num > 0)
                    {
                        resp = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese una edad correcto");
                    resp = false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correspondientes");
            }

            return resp;
        }

    }

}

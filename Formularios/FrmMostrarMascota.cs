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
    /// Clase que representa un formulario que muestra un objeto de tipo mascota
    /// </summary>
    public partial class FrmMostrarMascota : FrmMostrarObjeto
    {
        public Mascota mascota;
        private bool perro;
        private bool gato;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmMostrarMascota()
        {
            InitializeComponent();
            this.mascota = new Perro();
            base.CambiarTextBotonBase("Aceptar");
        }

        /// <summary>
        /// Constructor privado que recibe un objeto de tipo mascota
        /// </summary>
        /// <param name="masc">mascota que establecera algunos datos del formularios</param>
        /// <param name="boolean">booleano, solo se usa para diferenciar el constructor de la otras 
        ///                         sobrecargas que reciben herencias de Mascota</param>
        private FrmMostrarMascota(Mascota masc, bool boolean) : this()
        {
            if (boolean)
            {
                this.txtNombre.Text = masc.Nombre;
                this.txtEdad.Text = masc.Edad.ToString();
                this.txtNombreDueño.Text = masc.NombreDueño;
                this.txtApellidoDueño.Text = masc.ApellidoDueño;
                if (masc.TipoMascota == EMascota.Perro)
                {
                    this.radBtnGato.Enabled = false;
                    this.radBtnExotico.Enabled = false;
                    this.radBtnPerro_CheckedChanged(this, new EventArgs());
                }
                else if (masc.TipoMascota == EMascota.Gato)
                {
                    this.radBtnPerro.Enabled = false;
                    this.radBtnExotico.Enabled = false;
                    this.radBtnGato_CheckedChanged(this, new EventArgs());
                }
                else
                {
                    this.radBtnPerro.Enabled = false;
                    this.radBtnGato.Enabled = false;
                    this.radBtnExotico_CheckedChanged(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Constructor que recibe un objeto de tipo Perro
        /// </summary>
        /// <param name="perro">Objeto de tipo perro que establecera algunos datos del formularios</param>

        public FrmMostrarMascota(Perro perro) : this(perro, true)
        {
            this.perro = true;
            if (perro.Muerde)
            {
                this.radBtnSiMuerde.Checked = true;
            }
            else
            {
                this.radBtnNoMuerde.Checked = true;
            }
            this.ClickRazaPerro(perro);
        }

        /// <summary>
        /// Constructor que recibe un objeto de tipo Gato
        /// </summary>
        /// <param name="gato">Objeto de tipo gato que establecera algunos datos del formularios</param>

        public FrmMostrarMascota(Gato gato) : this(gato, true)
        {
            this.gato = true;
            if (gato.Rasguña)
            {
                this.radBtnSiRasguña.Checked = true;
            }
            else
            {
                this.radBtnNoRasguña.Checked = true;
            }
            this.ClickRazaGato(gato);
        }

        /// <summary>
        /// Constructor que recibe un objeto de tipo Exotico
        /// </summary>
        /// <param name="animal">Objeto de tipo Exotico que establecera algunos datos del formularios</param>

        public FrmMostrarMascota(Exotico animal) : this(animal, true)
        {
            this.ClickAlimentacion(animal);
            this.ClickExotico(animal);
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar
        /// Crea una nueva instancia de una de las herencias de la clase Mascota con los
        /// datos ingresados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            bool booleano = false;

            if (this.perro)
            {
                if (this.radBtnSiMuerde.Checked)
                {
                    booleano = true;
                }
                this.mascota = new Perro(this.txtNombre.Text, int.Parse(this.txtEdad.Text),
                                    this.txtNombreDueño.Text, this.txtApellidoDueño.Text, booleano, this.ParsearRazaPerro());
            }
            else if (this.gato)
            {
                if (this.radBtnSiRasguña.Checked)
                {
                    booleano = true;
                }
                this.mascota = new Gato(this.txtNombre.Text, int.Parse(this.txtEdad.Text),
                                    this.txtNombreDueño.Text, this.txtApellidoDueño.Text, this.ParsearRazaGato(), booleano);
            }
            else
            {
                this.mascota = new Exotico(this.txtNombre.Text, int.Parse(this.txtEdad.Text),
                                    this.txtNombreDueño.Text, this.txtApellidoDueño.Text, this.ParsearExotico(),
                                    this.ParsearAlimentacion());
            }

            this.DialogResult = DialogResult.OK;
        }

        // <summary>
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
        /// Metodo que relaciona un radioButton con el valor del enumerado de la raza del Perro ingresado
        /// </summary>
        /// <param name="p">objeto de tipo Perro, se utiliza para relacionar los botones con su raza</param>
        public void ClickRazaPerro(Perro p)
        {
            switch (p.Raza)
            {
                case ERazaPerro.Bulldog:
                    this.radBtnBulldog.Checked = true;
                    break;
                case ERazaPerro.Labrador:
                    this.radBtnLabrador.Checked = true;
                    break;
                case ERazaPerro.Mestizo:
                    this.radBtnMestizo.Checked = true;
                    break;
                case ERazaPerro.Caniche:
                    this.radBtnCaniche.Checked = true;
                    break;
                case ERazaPerro.Golden:
                    this.radBtnGolden.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Metodo que relaciona un radioButton con el valor del enumerado de la raza del Gato ingresado
        /// </summary>
        /// <param name="g">objeto de tipo Gato, se utiliza para relacionar los botones con su raza</param>
        public void ClickRazaGato(Gato g)
        {
            switch (g.Raza)
            {
                case ERazaGato.Siberiano:
                    this.radBtnSiberiano.Checked = true;
                    break;
                case ERazaGato.Siames:
                    this.radBtnSiames.Checked = true;
                    break;
                case ERazaGato.Persa:
                    this.radBtnPersa.Checked = true;
                    break;
                case ERazaGato.Europeo:
                    this.radBtnEuropeo.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Metodo que relaciona un radioButton con el valor del enumerado del tipo de animal ingresado
        /// </summary>
        /// <param name="ex">objeto de tipo Exotico, se utiliza para relacionar los botones con su tipo de anima</param>
        public void ClickExotico(Exotico ex)
        {
            switch (ex.Animal)
            {
                case EExotico.Huron:
                    this.radBtnHuron.Checked = true;
                    break;
                case EExotico.Cobayo:
                    this.radBtnCobayo.Checked = true;
                    break;
                case EExotico.Tortuga:
                    this.radBtnTortuga.Checked = true;
                    break;
                case EExotico.Hamster:
                    this.radBtnHamster.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Metodo que relaciona un radioButton con el valor del enumerado de la alimentacion
        /// del Exotico ingresado
        /// </summary>
        /// <param name="ex">objeto de tipo Exotico, se utiliza para relacionar los botones 
        ///                     con su tipo de alimentacion</param>
        public void ClickAlimentacion(Exotico ex)
        {
            switch (ex.Alimento)
            {
                case EAlimento.Especial:
                    this.radBtnAlimEsp.Checked = true;
                    break;
                case EAlimento.Cereales:
                    this.radBtnCereales.Checked = true;
                    break;
                case EAlimento.Vegetales:
                    this.radBtnVegetales.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Se activa cuando se selecciona un perro como tipo de mascota
        /// Habilita los botones relacionados con los perros y deshabilita los
        /// botones relacionados con gatos y exóticos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnPerro_CheckedChanged(object sender, EventArgs e)
        {
            this.radBtnPerro.Checked = true;
            this.grpBoxPerro.Visible = true;
            this.grpBoxMuerde.Visible = true;
            this.grpBoxGato.Visible = false;
            this.grpBoxRasguña.Visible = false;
            this.grpBoxAnimal.Visible = false;
            this.grpBoxAlimentacion.Visible = false;
        }

        /// <summary>
        /// Se activa cuando se selecciona un gato como tipo de mascota
        /// Habilita los botones relacionados con los gatos y deshabilita los
        /// botones relacionados con perros y exóticos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnGato_CheckedChanged(object sender, EventArgs e)
        {
            this.radBtnGato.Checked = true;
            this.grpBoxPerro.Visible = false;
            this.grpBoxMuerde.Visible = false;
            this.grpBoxGato.Visible = true;
            this.grpBoxRasguña.Visible = true;
            this.grpBoxAnimal.Visible = false;
            this.grpBoxAlimentacion.Visible = false;
        }

        /// <summary>
        /// Se activa cuando se selecciona un exotico como tipo de mascota
        /// Habilita los botones relacionados con los exoticos y deshabilita los
        /// botones relacionados con gatos y perros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtnExotico_CheckedChanged(object sender, EventArgs e)
        {
            this.radBtnExotico.Checked = true;
            this.grpBoxPerro.Visible = false;
            this.grpBoxMuerde.Visible = false;
            this.grpBoxGato.Visible = false;
            this.grpBoxRasguña.Visible = false;
            this.grpBoxAnimal.Visible = true;
            this.grpBoxAlimentacion.Visible = true;
        }
    }

}

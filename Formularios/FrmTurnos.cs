using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    /// <summary>
    /// Clase que representa un formulario para crear un turno
    /// </summary>
    public partial class FrmTurnos : Form
    {
        public Turno turno;
        private List<string> horas;
        private List<MedicoVeterinario> listaMedicos;
        private List<Mascota> listaMascotas;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FrmTurnos()
        {
            InitializeComponent();

            this.turno = new Turno();
            this.monthCalendarFecha.MinDate = DateTime.Now;
            this.monthCalendarFecha.MaxDate = DateTime.Today.AddMonths(2);
            this.horas = new List<string>();
            this.listaMascotas = new List<Mascota>();
            this.listaMedicos = new List<MedicoVeterinario>();
            #region horas
            this.horas.Add("8:00");
            this.horas.Add("8:30");
            this.horas.Add("9:00");
            this.horas.Add("9:30");
            this.horas.Add("10:00");
            this.horas.Add("10:30");
            this.horas.Add("11:00");
            this.horas.Add("11:30");
            this.horas.Add("12:00");
            this.horas.Add("12:30");
            this.horas.Add("13:00");
            this.horas.Add("13:30");
            this.horas.Add("14:00");
            this.horas.Add("14:30");
            this.horas.Add("15:00");
            this.horas.Add("15:30");
            this.horas.Add("16:00");
            this.horas.Add("16:30");
            this.horas.Add("17:00");
            this.horas.Add("17:30");
            this.horas.Add("18:00");
            this.horas.Add("18:30");
            this.horas.Add("19:00");
            this.horas.Add("19:30");
            #endregion
        }

        /// <summary>
        /// Constructor de la clase que recibe una lista de medicos y una de mascotas
        /// </summary>
        /// <param name="listaMedicos">lista de tipo MedicoVeterinario</param>
        /// <param name="listaMascotas">lista de tipo Mascota</param>
        public FrmTurnos(List<MedicoVeterinario> listaMedicos, List<Mascota> listaMascotas) : this()
        {
            this.listaMedicos = listaMedicos;
            this.listaMascotas = listaMascotas;
        }
        
        /// <summary>
        /// Cuando carga el formulario acualiza los listBox llamando a el metodo ActualizarVisor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTurnos_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor(this.horas);
            this.ActualizarVisor(this.listaMascotas);
            this.ActualizarVisor(this.listaMedicos);
        }

        /// <summary>
        /// Genera la lista con las horas de los turnos 
        /// </summary>
        /// <returns>lista de string</returns>
        public List<string> GenerarLIstaHoras()
        {
            List<string> horas = new List<string>();
            horas.Add("8:00");
            horas.Add("8:30");
            horas.Add("9:00");
            horas.Add("9:30");
            horas.Add("10:00");
            horas.Add("10:30");
            horas.Add("11:00");
            horas.Add("11:30");
            horas.Add("12:00");
            horas.Add("12:30");
            horas.Add("13:00");
            horas.Add("13:30");
            horas.Add("14:00");
            horas.Add("14:30");
            horas.Add("15:00");
            horas.Add("15:30");
            horas.Add("16:00");
            horas.Add("16:30");
            horas.Add("17:00");
            horas.Add("17:30");
            horas.Add("18:00");
            horas.Add("18:30");
            horas.Add("19:00");
            horas.Add("19:30");

            return horas;
        }

        /// <summary>
        /// Actualiza el listBox de horas con los string de la lista
        /// </summary>
        /// <param name="lista">lista de string</param>
        private void ActualizarVisor(List<string> lista)
        {
            this.lstHora.Items.Clear();

            foreach (string hora in lista)
            {
                this.lstHora.Items.Add(hora);
            }
        }

        /// <summary>
        /// Actualiza el listBox de mascotas con las mascotas de la lista
        /// </summary>
        /// <param name="lista">lista de string</param>
        private void ActualizarVisor(List<Mascota> lista)
        {
            this.lstMascota.Items.Clear();

            foreach (Mascota masc in lista)
            {
                this.lstMascota.Items.Add(masc.Mostrar());
            }
        }

        /// <summary>
        /// Actualiza el listBox de medicos con los MedicosVeterinarios de la lista
        /// </summary>
        /// <param name="lista">lista de string</param>
        private void ActualizarVisor(List<MedicoVeterinario> lista)
        {
            this.lstProfesionales.Items.Clear();

            foreach (MedicoVeterinario med in lista)
            {
                this.lstProfesionales.Items.Add(med.Mostrar());
            }
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Aceptar, le asigna el turno creado
        /// a la intancia de turno del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int indiceHora = this.lstHora.SelectedIndex;
            int indiceProfesionales = this.lstProfesionales.SelectedIndex;
            int indiceMascota = this.lstMascota.SelectedIndex;

            if (indiceHora == -1 || indiceProfesionales == -1 || indiceMascota == -1)
            {
                MessageBox.Show("Seleccione todos los campos requeridos");
                return;
            }
            else
            {


                this.turno = new Turno(this.listaMascotas[indiceMascota],this.listaMedicos[indiceProfesionales],
                    DateTime.Parse($"{this.monthCalendarFecha.SelectionStart.ToShortDateString()} {this.horas[indiceHora]}"));

            }
            this.DialogResult = MessageBox.Show($"Turno:\n{this.turno}", "Atención!",
                                                            MessageBoxButtons.OKCancel);
        }

        /// <summary>
        /// Se activa al hacer clic en el botón Cancelar y establece el resultado del dialogo en Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

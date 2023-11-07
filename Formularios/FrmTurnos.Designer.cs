namespace Formularios
{
    partial class FrmTurnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendarFecha = new MonthCalendar();
            lstHora = new ListBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lstProfesionales = new ListBox();
            lstMascota = new ListBox();
            SuspendLayout();
            // 
            // monthCalendarFecha
            // 
            monthCalendarFecha.BackColor = Color.FromArgb(192, 192, 255);
            monthCalendarFecha.Location = new Point(18, 18);
            monthCalendarFecha.Name = "monthCalendarFecha";
            monthCalendarFecha.TabIndex = 0;
            // 
            // lstHora
            // 
            lstHora.BackColor = SystemColors.Window;
            lstHora.FormattingEnabled = true;
            lstHora.ItemHeight = 15;
            lstHora.Location = new Point(288, 18);
            lstHora.Name = "lstHora";
            lstHora.Size = new Size(71, 154);
            lstHora.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(237, 344);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(122, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstProfesionales
            // 
            lstProfesionales.BackColor = SystemColors.Window;
            lstProfesionales.FormattingEnabled = true;
            lstProfesionales.ItemHeight = 15;
            lstProfesionales.Location = new Point(18, 205);
            lstProfesionales.Name = "lstProfesionales";
            lstProfesionales.Size = new Size(248, 49);
            lstProfesionales.TabIndex = 4;
            // 
            // lstMascota
            // 
            lstMascota.BackColor = SystemColors.Window;
            lstMascota.FormattingEnabled = true;
            lstMascota.ItemHeight = 15;
            lstMascota.Location = new Point(18, 278);
            lstMascota.Name = "lstMascota";
            lstMascota.Size = new Size(248, 49);
            lstMascota.TabIndex = 5;
            // 
            // FrmTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 379);
            Controls.Add(lstMascota);
            Controls.Add(lstProfesionales);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstHora);
            Controls.Add(monthCalendarFecha);
            Name = "FrmTurnos";
            Text = "FrmTurnos";
            Load += FrmTurnos_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendarFecha;
        private ListBox lstHora;
        private Button btnAceptar;
        private Button btnCancelar;
        private ListBox lstProfesionales;
        private ListBox lstMascota;
    }
}
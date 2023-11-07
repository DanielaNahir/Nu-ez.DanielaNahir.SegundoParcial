namespace Formularios
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblHora = new Label();
            btnHistorial = new Button();
            lblTitulo = new Label();
            lstVisor = new ListBox();
            groupBox1 = new GroupBox();
            btnHistorialClinico = new Button();
            groupBoxHistorias = new GroupBox();
            btnInternaciones = new Button();
            groupBoxTurnos = new GroupBox();
            btnHistorialTurnos = new Button();
            btnProfesionales = new Button();
            btnPrecios = new Button();
            groupBox2 = new GroupBox();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            groupBoxHistorias.SuspendLayout();
            groupBoxTurnos.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Apellido";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Location = new Point(434, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(53, 15);
            lblHora.TabIndex = 1;
            lblHora.Text = "00/00/00";
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Location = new Point(373, 312);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(84, 23);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Conexiones";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnConexiones_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(157, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 27);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Veterinaria Cuore";
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(6, 22);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(258, 214);
            lstVisor.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.Controls.Add(lstVisor);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 255);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Turnos del dia";
            // 
            // btnHistorialClinico
            // 
            btnHistorialClinico.Location = new Point(6, 22);
            btnHistorialClinico.Name = "btnHistorialClinico";
            btnHistorialClinico.Size = new Size(168, 23);
            btnHistorialClinico.TabIndex = 8;
            btnHistorialClinico.Text = "Historias clinicas";
            btnHistorialClinico.UseVisualStyleBackColor = true;
            btnHistorialClinico.Click += btnHistorialClinico_Click;
            // 
            // groupBoxHistorias
            // 
            groupBoxHistorias.Anchor = AnchorStyles.Right;
            groupBoxHistorias.Controls.Add(btnInternaciones);
            groupBoxHistorias.Controls.Add(btnHistorialClinico);
            groupBoxHistorias.Location = new Point(307, 49);
            groupBoxHistorias.Name = "groupBoxHistorias";
            groupBoxHistorias.Size = new Size(180, 91);
            groupBoxHistorias.TabIndex = 11;
            groupBoxHistorias.TabStop = false;
            groupBoxHistorias.Text = "Pacientes";
            // 
            // btnInternaciones
            // 
            btnInternaciones.Location = new Point(6, 51);
            btnInternaciones.Name = "btnInternaciones";
            btnInternaciones.Size = new Size(168, 23);
            btnInternaciones.TabIndex = 14;
            btnInternaciones.Text = "Internaciones";
            btnInternaciones.UseVisualStyleBackColor = true;
            btnInternaciones.Click += btnInternaciones_Click;
            // 
            // groupBoxTurnos
            // 
            groupBoxTurnos.Anchor = AnchorStyles.Right;
            groupBoxTurnos.Controls.Add(btnHistorialTurnos);
            groupBoxTurnos.Location = new Point(307, 146);
            groupBoxTurnos.Name = "groupBoxTurnos";
            groupBoxTurnos.Size = new Size(180, 52);
            groupBoxTurnos.TabIndex = 12;
            groupBoxTurnos.TabStop = false;
            groupBoxTurnos.Text = "Turnos";
            // 
            // btnHistorialTurnos
            // 
            btnHistorialTurnos.Location = new Point(6, 22);
            btnHistorialTurnos.Name = "btnHistorialTurnos";
            btnHistorialTurnos.Size = new Size(168, 23);
            btnHistorialTurnos.TabIndex = 8;
            btnHistorialTurnos.Text = "Historial de turnos";
            btnHistorialTurnos.UseVisualStyleBackColor = true;
            btnHistorialTurnos.Click += btnHistorialTurnos_Click;
            // 
            // btnProfesionales
            // 
            btnProfesionales.Location = new Point(6, 22);
            btnProfesionales.Name = "btnProfesionales";
            btnProfesionales.Size = new Size(168, 23);
            btnProfesionales.TabIndex = 11;
            btnProfesionales.Text = "Profesionales";
            btnProfesionales.UseVisualStyleBackColor = true;
            btnProfesionales.Click += btnProfesionales_Click;
            // 
            // btnPrecios
            // 
            btnPrecios.Location = new Point(6, 51);
            btnPrecios.Name = "btnPrecios";
            btnPrecios.Size = new Size(168, 23);
            btnPrecios.TabIndex = 13;
            btnPrecios.Text = "Precios";
            btnPrecios.UseVisualStyleBackColor = true;
            btnPrecios.Click += btnPrecios_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Right;
            groupBox2.Controls.Add(btnProfesionales);
            groupBox2.Controls.Add(btnPrecios);
            groupBox2.Location = new Point(307, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 88);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos veterinaria";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.pngwing_com;
            btnGuardar.Location = new Point(463, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(24, 30);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 347);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxTurnos);
            Controls.Add(groupBoxHistorias);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(btnHistorial);
            Controls.Add(lblHora);
            Controls.Add(lblNombre);
            Name = "FrmMain";
            Text = "Menu";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBoxHistorias.ResumeLayout(false);
            groupBoxTurnos.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblHora;
        private Button btnHistorial;
        private Label lblTitulo;
        private ListBox lstVisor;
        private GroupBox groupBox1;
        private Button btnHistorialClinico;
        private GroupBox groupBoxHistorias;
        private GroupBox groupBoxTurnos;
        private Button btnHistorialTurnos;
        private Button btnProfesionales;
        private Button btnPrecios;
        private Button btnInternaciones;
        private GroupBox groupBox2;
        private Button btnGuardar;
    }
}
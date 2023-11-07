namespace Formularios
{
    partial class FrmInternacion
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
            lstVisor = new ListBox();
            label1 = new Label();
            lblAclaracion = new Label();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 27);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(224, 259);
            lstVisor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Pacientes:";
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAclaracion.Location = new Point(3, 289);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(233, 26);
            lblAclaracion.TabIndex = 2;
            lblAclaracion.Text = "*Solo se permite la internacion de pacientes\r\n                  con historial clinico\r\n";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(242, 27);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 3;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FrmCRUDInternacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 321);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblAclaracion);
            Controls.Add(label1);
            Controls.Add(lstVisor);
            Name = "FrmCRUDInternacion";
            Text = "FrmCRUDInternacion";
            FormClosing += FrmCRUDInternacion_FormClosing;
            Load += FrmCRUDInternacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVisor;
        private Label label1;
        private Label lblAclaracion;
        private Button btnSeleccionar;
    }
}
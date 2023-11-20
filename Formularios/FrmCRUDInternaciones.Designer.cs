namespace Formularios
{
    partial class FrmCRUDInternaciones
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
            btnCapacidad = new Button();
            lblCapacidad = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Visible = false;
            // 
            // btnCapacidad
            // 
            btnCapacidad.Location = new Point(290, 245);
            btnCapacidad.Name = "btnCapacidad";
            btnCapacidad.Size = new Size(118, 23);
            btnCapacidad.TabIndex = 7;
            btnCapacidad.Text = "Cambiar capacidad";
            btnCapacidad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(12, 256);
            lblCapacidad.Name = "label1";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 8;
            lblCapacidad.Text = "Capacidad:";
            // 
            // FrmCRUDInternaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 280);
            Controls.Add(lblCapacidad);
            Controls.Add(btnCapacidad);
            Location = new Point(0, 0);
            Name = "FrmCRUDInternaciones";
            Text = "FrmInternaciones";
            FormClosing += FrmInternaciones_FormClosing;
            Load += FrmInternaciones_Load;
            Controls.SetChildIndex(lstVisor, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCapacidad, 0);
            Controls.SetChildIndex(lblCapacidad, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapacidad;
        private Label lblCapacidad;
    }
}
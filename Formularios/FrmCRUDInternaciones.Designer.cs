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
            // FrmInternaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 254);
            Location = new Point(0, 0);
            Name = "FrmInternaciones";
            Text = "FrmInternaciones";
            FormClosing += FrmInternaciones_FormClosing;
            Load += FrmInternaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
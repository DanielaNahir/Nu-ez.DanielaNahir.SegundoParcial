namespace Formularios
{
    partial class FrmCRUDTurnos
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
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.Location = new Point(12, 27);
            lstVisor.Size = new Size(304, 214);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(332, 89);
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(332, 47);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(332, 181);
            btnModificar.Visible = false;
            // 
            // FrmCRUDTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 261);
            Location = new Point(0, 0);
            Name = "FrmCRUDTurnos";
            FormClosing += FrmCRUDTurnos_FormClosing;
            Load += FrmCRUDTurnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
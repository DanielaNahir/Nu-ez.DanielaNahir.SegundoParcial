namespace Formularios
{
    partial class FrmCRUDPrecios
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
            // lstVisor
            // 
            lstVisor.Size = new Size(196, 244);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(214, 118);
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(214, 28);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(214, 73);
            btnModificar.Click += btnModificar_Click_1;
            // 
            // FrmCRUDPrecios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 283);
            Location = new Point(0, 0);
            Name = "FrmCRUDPrecios";
            Text = "FrmPrecios";
            FormClosing += FrmCRUDPrecios_FormClosing;
            Load += FrmCRUDPrecios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
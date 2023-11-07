namespace Formularios
{
    partial class FrmListadoDatos
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
            lstVisor = new ListBox();
            btnEliminar = new Button();
            lblTituloLista = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 28);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(228, 214);
            lstVisor.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(276, 92);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Location = new Point(12, 9);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(38, 15);
            lblTituloLista.TabIndex = 5;
            lblTituloLista.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(276, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(276, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmListadoDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 263);
            Controls.Add(btnAgregar);
            Controls.Add(lblTituloLista);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lstVisor);
            Name = "FrmListadoDatos";
            Text = "Form1";
            Load += FrmListadoDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTituloLista;
        protected ListBox lstVisor;
        protected Button btnEliminar;
        protected Button btnAgregar;
        protected Button btnModificar;
    }
}
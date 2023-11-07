namespace Formularios
{
    partial class FrmMostrarObjeto
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
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblNombre = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(314, 211);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "button1";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmMostrarObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 246);
            Controls.Add(btnCancelar);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Name = "FrmMostrarObjeto";
            Text = "FrmMostrarObjeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        protected TextBox txtNombre;
        protected Button btnAceptar;
        protected Label lblNombre;
    }
}
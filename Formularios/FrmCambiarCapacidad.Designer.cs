namespace Formularios
{
    partial class FrmCambiarCapacidad
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
            btnCambiar = new Button();
            btnCancelar = new Button();
            txtCapacidad = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(164, 87);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(75, 23);
            btnCambiar.TabIndex = 0;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 87);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(90, 31);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(149, 23);
            txtCapacidad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Capacidad: ";
            // 
            // FrmCambiarCapacidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 122);
            Controls.Add(label1);
            Controls.Add(txtCapacidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnCambiar);
            Name = "FrmCambiarCapacidad";
            Text = "FrmCambiarCapacidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar;
        private Button btnCancelar;
        private TextBox txtCapacidad;
        private Label label1;
    }
}
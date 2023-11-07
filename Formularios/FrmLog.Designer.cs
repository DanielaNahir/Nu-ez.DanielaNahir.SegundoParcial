namespace Formularios
{
    partial class FrmLog
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
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            lblMail = new Label();
            lblTitulo = new Label();
            btnIniciarSesion = new Button();
            lblContrIncorrecta = new Label();
            lblUsuIncorrecto = new Label();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(35, 119);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(175, 23);
            txtMail.TabIndex = 0;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(35, 176);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(175, 23);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(35, 156);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(77, 17);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(35, 99);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(105, 17);
            lblMail.TabIndex = 3;
            lblMail.Text = "Mail del usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(56, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 30);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Inicie sesion";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(70, 217);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(105, 23);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblContrIncorrecta
            // 
            lblContrIncorrecta.AutoSize = true;
            lblContrIncorrecta.ForeColor = Color.Red;
            lblContrIncorrecta.Location = new Point(35, 145);
            lblContrIncorrecta.Name = "lblContrIncorrecta";
            lblContrIncorrecta.Size = new Size(128, 15);
            lblContrIncorrecta.TabIndex = 6;
            lblContrIncorrecta.Text = "°Contraseña incorrecta";
            lblContrIncorrecta.Visible = false;
            // 
            // lblUsuIncorrecto
            // 
            lblUsuIncorrecto.AutoSize = true;
            lblUsuIncorrecto.ForeColor = Color.Red;
            lblUsuIncorrecto.Location = new Point(35, 84);
            lblUsuIncorrecto.Name = "lblUsuIncorrecto";
            lblUsuIncorrecto.Size = new Size(109, 15);
            lblUsuIncorrecto.TabIndex = 7;
            lblUsuIncorrecto.Text = "°Usuario incorrecto";
            lblUsuIncorrecto.Visible = false;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 264);
            Controls.Add(lblUsuIncorrecto);
            Controls.Add(lblContrIncorrecta);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblTitulo);
            Controls.Add(lblMail);
            Controls.Add(lblContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtMail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLog";
            Text = "Iniciar Sesión";
            Load += FrmLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Label lblMail;
        private Label lblTitulo;
        private Button btnIniciarSesion;
        private Label lblContrIncorrecta;
        private Label lblUsuIncorrecto;
    }
}
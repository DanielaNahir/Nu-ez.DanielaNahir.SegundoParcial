namespace Formularios
{
    partial class FrmProfesionales
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtSueldo = new TextBox();
            lblSueldo = new Label();
            grpBoxEspecialidad = new GroupBox();
            radBtnCirujano = new RadioButton();
            radBtnDermatologo = new RadioButton();
            radBtnCardiologo = new RadioButton();
            radBtnClinico = new RadioButton();
            grpBoxEspecialidad.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(140, 262);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(203, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(12, 136);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(203, 23);
            txtSueldo.TabIndex = 7;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(12, 118);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 6;
            lblSueldo.Text = "Sueldo";
            // 
            // grpBoxEspecialidad
            // 
            grpBoxEspecialidad.Controls.Add(radBtnCirujano);
            grpBoxEspecialidad.Controls.Add(radBtnDermatologo);
            grpBoxEspecialidad.Controls.Add(radBtnCardiologo);
            grpBoxEspecialidad.Controls.Add(radBtnClinico);
            grpBoxEspecialidad.Location = new Point(12, 165);
            grpBoxEspecialidad.Name = "grpBoxEspecialidad";
            grpBoxEspecialidad.Size = new Size(203, 80);
            grpBoxEspecialidad.TabIndex = 8;
            grpBoxEspecialidad.TabStop = false;
            grpBoxEspecialidad.Text = "Especialidad";
            // 
            // radBtnCirujano
            // 
            radBtnCirujano.AutoSize = true;
            radBtnCirujano.Location = new Point(103, 47);
            radBtnCirujano.Name = "radBtnCirujano";
            radBtnCirujano.Size = new Size(70, 19);
            radBtnCirujano.TabIndex = 3;
            radBtnCirujano.TabStop = true;
            radBtnCirujano.Text = "Cirujano";
            radBtnCirujano.UseVisualStyleBackColor = true;
            // 
            // radBtnDermatologo
            // 
            radBtnDermatologo.AutoSize = true;
            radBtnDermatologo.Location = new Point(103, 22);
            radBtnDermatologo.Name = "radBtnDermatologo";
            radBtnDermatologo.Size = new Size(95, 19);
            radBtnDermatologo.TabIndex = 2;
            radBtnDermatologo.TabStop = true;
            radBtnDermatologo.Text = "Dermatologo";
            radBtnDermatologo.UseVisualStyleBackColor = true;
            // 
            // radBtnCardiologo
            // 
            radBtnCardiologo.AutoSize = true;
            radBtnCardiologo.Location = new Point(13, 47);
            radBtnCardiologo.Name = "radBtnCardiologo";
            radBtnCardiologo.Size = new Size(84, 19);
            radBtnCardiologo.TabIndex = 1;
            radBtnCardiologo.TabStop = true;
            radBtnCardiologo.Text = "Cardiologo";
            radBtnCardiologo.UseVisualStyleBackColor = true;
            // 
            // radBtnClinico
            // 
            radBtnClinico.AutoSize = true;
            radBtnClinico.Location = new Point(13, 22);
            radBtnClinico.Name = "radBtnClinico";
            radBtnClinico.Size = new Size(62, 19);
            radBtnClinico.TabIndex = 0;
            radBtnClinico.TabStop = true;
            radBtnClinico.Text = "Clínico";
            radBtnClinico.UseVisualStyleBackColor = true;
            // 
            // FrmCRUDProfesionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 298);
            Controls.Add(grpBoxEspecialidad);
            Controls.Add(txtSueldo);
            Controls.Add(lblSueldo);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FrmCRUDProfesionales";
            Text = "FrmCRUDProfesionales";
            Load += FrmCRUDProfesionales_Load;
            grpBoxEspecialidad.ResumeLayout(false);
            grpBoxEspecialidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtSueldo;
        private Label lblSueldo;
        private GroupBox grpBoxEspecialidad;
        private RadioButton radBtnCardiologo;
        private RadioButton radBtnClinico;
        private RadioButton radBtnCirujano;
        private RadioButton radBtnDermatologo;
    }
}
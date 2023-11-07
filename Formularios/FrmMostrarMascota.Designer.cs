namespace Formularios
{
    partial class FrmMostrarMascota
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
            txtNombreDueño = new TextBox();
            lblNombreDueño = new Label();
            radBtnExotico = new RadioButton();
            radBtnGato = new RadioButton();
            radBtnPerro = new RadioButton();
            lblEdad = new Label();
            txtEdad = new TextBox();
            grpBoxPerro = new GroupBox();
            radBtnCaniche = new RadioButton();
            radBtnMestizo = new RadioButton();
            radBtnBulldog = new RadioButton();
            radBtnLabrador = new RadioButton();
            radBtnGolden = new RadioButton();
            grpBoxGato = new GroupBox();
            radBtnSiames = new RadioButton();
            radBtnPersa = new RadioButton();
            radBtnSiberiano = new RadioButton();
            radBtnEuropeo = new RadioButton();
            grpBoxAnimal = new GroupBox();
            radBtnCobayo = new RadioButton();
            radBtnHamster = new RadioButton();
            radBtnHuron = new RadioButton();
            radBtnTortuga = new RadioButton();
            grpBoxMuerde = new GroupBox();
            radBtnSiMuerde = new RadioButton();
            radBtnNoMuerde = new RadioButton();
            grpBoxRasguña = new GroupBox();
            radBtnNoRasguña = new RadioButton();
            radBtnSiRasguña = new RadioButton();
            grpBoxAlimentacion = new GroupBox();
            radBtnAlimEsp = new RadioButton();
            radBtnCereales = new RadioButton();
            radBtnVegetales = new RadioButton();
            txtApellidoDueño = new TextBox();
            grpBoxPerro.SuspendLayout();
            grpBoxGato.SuspendLayout();
            grpBoxAnimal.SuspendLayout();
            grpBoxMuerde.SuspendLayout();
            grpBoxRasguña.SuspendLayout();
            grpBoxAlimentacion.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreDueño
            // 
            txtNombreDueño.Location = new Point(186, 32);
            txtNombreDueño.Name = "txtNombreDueño";
            txtNombreDueño.Size = new Size(88, 23);
            txtNombreDueño.TabIndex = 4;
            // 
            // lblNombreDueño
            // 
            lblNombreDueño.AutoSize = true;
            lblNombreDueño.Location = new Point(186, 14);
            lblNombreDueño.Name = "lblNombreDueño";
            lblNombreDueño.Size = new Size(88, 15);
            lblNombreDueño.TabIndex = 5;
            lblNombreDueño.Text = "Nombre dueño";
            // 
            // radBtnExotico
            // 
            radBtnExotico.AutoSize = true;
            radBtnExotico.Location = new Point(301, 77);
            radBtnExotico.Name = "radBtnExotico";
            radBtnExotico.Size = new Size(64, 19);
            radBtnExotico.TabIndex = 9;
            radBtnExotico.TabStop = true;
            radBtnExotico.Text = "Exotico";
            radBtnExotico.UseVisualStyleBackColor = true;
            radBtnExotico.CheckedChanged += radBtnExotico_CheckedChanged;
            // 
            // radBtnGato
            // 
            radBtnGato.AutoSize = true;
            radBtnGato.Location = new Point(245, 77);
            radBtnGato.Name = "radBtnGato";
            radBtnGato.Size = new Size(50, 19);
            radBtnGato.TabIndex = 8;
            radBtnGato.TabStop = true;
            radBtnGato.Text = "Gato";
            radBtnGato.UseVisualStyleBackColor = true;
            radBtnGato.CheckedChanged += radBtnGato_CheckedChanged;
            // 
            // radBtnPerro
            // 
            radBtnPerro.AutoSize = true;
            radBtnPerro.Location = new Point(186, 77);
            radBtnPerro.Name = "radBtnPerro";
            radBtnPerro.Size = new Size(53, 19);
            radBtnPerro.TabIndex = 7;
            radBtnPerro.TabStop = true;
            radBtnPerro.Text = "Perro";
            radBtnPerro.UseVisualStyleBackColor = true;
            radBtnPerro.CheckedChanged += radBtnPerro_CheckedChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 58);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 11;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 76);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(75, 23);
            txtEdad.TabIndex = 10;
            // 
            // grpBoxPerro
            // 
            grpBoxPerro.Controls.Add(radBtnCaniche);
            grpBoxPerro.Controls.Add(radBtnMestizo);
            grpBoxPerro.Controls.Add(radBtnBulldog);
            grpBoxPerro.Controls.Add(radBtnLabrador);
            grpBoxPerro.Controls.Add(radBtnGolden);
            grpBoxPerro.Location = new Point(12, 116);
            grpBoxPerro.Name = "grpBoxPerro";
            grpBoxPerro.Size = new Size(191, 89);
            grpBoxPerro.TabIndex = 34;
            grpBoxPerro.TabStop = false;
            grpBoxPerro.Text = "Raza del perro:";
            // 
            // radBtnCaniche
            // 
            radBtnCaniche.AutoSize = true;
            radBtnCaniche.Enabled = false;
            radBtnCaniche.Location = new Point(9, 41);
            radBtnCaniche.Name = "radBtnCaniche";
            radBtnCaniche.Size = new Size(68, 19);
            radBtnCaniche.TabIndex = 9;
            radBtnCaniche.TabStop = true;
            radBtnCaniche.Text = "Caniche";
            radBtnCaniche.UseVisualStyleBackColor = true;
            // 
            // radBtnMestizo
            // 
            radBtnMestizo.AutoSize = true;
            radBtnMestizo.Enabled = false;
            radBtnMestizo.Location = new Point(9, 23);
            radBtnMestizo.Name = "radBtnMestizo";
            radBtnMestizo.Size = new Size(66, 19);
            radBtnMestizo.TabIndex = 8;
            radBtnMestizo.TabStop = true;
            radBtnMestizo.Text = "Mestizo";
            radBtnMestizo.UseVisualStyleBackColor = true;
            // 
            // radBtnBulldog
            // 
            radBtnBulldog.AutoSize = true;
            radBtnBulldog.Enabled = false;
            radBtnBulldog.Location = new Point(9, 59);
            radBtnBulldog.Name = "radBtnBulldog";
            radBtnBulldog.Size = new Size(66, 19);
            radBtnBulldog.TabIndex = 10;
            radBtnBulldog.TabStop = true;
            radBtnBulldog.Text = "Bulldog";
            radBtnBulldog.UseVisualStyleBackColor = true;
            // 
            // radBtnLabrador
            // 
            radBtnLabrador.AutoSize = true;
            radBtnLabrador.Enabled = false;
            radBtnLabrador.Location = new Point(111, 48);
            radBtnLabrador.Name = "radBtnLabrador";
            radBtnLabrador.Size = new Size(72, 19);
            radBtnLabrador.TabIndex = 11;
            radBtnLabrador.TabStop = true;
            radBtnLabrador.Text = "Labrador";
            radBtnLabrador.UseVisualStyleBackColor = true;
            // 
            // radBtnGolden
            // 
            radBtnGolden.AutoSize = true;
            radBtnGolden.Enabled = false;
            radBtnGolden.Location = new Point(111, 22);
            radBtnGolden.Name = "radBtnGolden";
            radBtnGolden.Size = new Size(63, 19);
            radBtnGolden.TabIndex = 12;
            radBtnGolden.TabStop = true;
            radBtnGolden.Text = "Golden";
            radBtnGolden.UseVisualStyleBackColor = true;
            // 
            // grpBoxGato
            // 
            grpBoxGato.Controls.Add(radBtnSiames);
            grpBoxGato.Controls.Add(radBtnPersa);
            grpBoxGato.Controls.Add(radBtnSiberiano);
            grpBoxGato.Controls.Add(radBtnEuropeo);
            grpBoxGato.Location = new Point(12, 116);
            grpBoxGato.Name = "grpBoxGato";
            grpBoxGato.Size = new Size(191, 78);
            grpBoxGato.TabIndex = 35;
            grpBoxGato.TabStop = false;
            grpBoxGato.Text = "Raza del gato:";
            // 
            // radBtnSiames
            // 
            radBtnSiames.AutoSize = true;
            radBtnSiames.Enabled = false;
            radBtnSiames.Location = new Point(120, 22);
            radBtnSiames.Name = "radBtnSiames";
            radBtnSiames.Size = new Size(62, 19);
            radBtnSiames.TabIndex = 15;
            radBtnSiames.TabStop = true;
            radBtnSiames.Text = "Siames";
            radBtnSiames.UseVisualStyleBackColor = true;
            // 
            // radBtnPersa
            // 
            radBtnPersa.AutoSize = true;
            radBtnPersa.Enabled = false;
            radBtnPersa.Location = new Point(120, 47);
            radBtnPersa.Name = "radBtnPersa";
            radBtnPersa.Size = new Size(53, 19);
            radBtnPersa.TabIndex = 14;
            radBtnPersa.TabStop = true;
            radBtnPersa.Text = "Persa";
            radBtnPersa.UseVisualStyleBackColor = true;
            // 
            // radBtnSiberiano
            // 
            radBtnSiberiano.AutoSize = true;
            radBtnSiberiano.Enabled = false;
            radBtnSiberiano.Location = new Point(6, 23);
            radBtnSiberiano.Name = "radBtnSiberiano";
            radBtnSiberiano.Size = new Size(74, 19);
            radBtnSiberiano.TabIndex = 16;
            radBtnSiberiano.TabStop = true;
            radBtnSiberiano.Text = "Siberiano";
            radBtnSiberiano.UseVisualStyleBackColor = true;
            // 
            // radBtnEuropeo
            // 
            radBtnEuropeo.AutoSize = true;
            radBtnEuropeo.Enabled = false;
            radBtnEuropeo.Location = new Point(6, 47);
            radBtnEuropeo.Name = "radBtnEuropeo";
            radBtnEuropeo.Size = new Size(112, 19);
            radBtnEuropeo.TabIndex = 17;
            radBtnEuropeo.TabStop = true;
            radBtnEuropeo.Text = "Común Europeo";
            radBtnEuropeo.UseVisualStyleBackColor = true;
            // 
            // grpBoxAnimal
            // 
            grpBoxAnimal.Controls.Add(radBtnCobayo);
            grpBoxAnimal.Controls.Add(radBtnHamster);
            grpBoxAnimal.Controls.Add(radBtnHuron);
            grpBoxAnimal.Controls.Add(radBtnTortuga);
            grpBoxAnimal.Enabled = false;
            grpBoxAnimal.Location = new Point(12, 116);
            grpBoxAnimal.Name = "grpBoxAnimal";
            grpBoxAnimal.Size = new Size(162, 69);
            grpBoxAnimal.TabIndex = 36;
            grpBoxAnimal.TabStop = false;
            grpBoxAnimal.Text = "Animal:";
            // 
            // radBtnCobayo
            // 
            radBtnCobayo.AutoSize = true;
            radBtnCobayo.Enabled = false;
            radBtnCobayo.Location = new Point(6, 22);
            radBtnCobayo.Name = "radBtnCobayo";
            radBtnCobayo.Size = new Size(66, 19);
            radBtnCobayo.TabIndex = 19;
            radBtnCobayo.TabStop = true;
            radBtnCobayo.Text = "Cobayo";
            radBtnCobayo.UseVisualStyleBackColor = true;
            // 
            // radBtnHamster
            // 
            radBtnHamster.AutoSize = true;
            radBtnHamster.Enabled = false;
            radBtnHamster.Location = new Point(6, 40);
            radBtnHamster.Name = "radBtnHamster";
            radBtnHamster.Size = new Size(70, 19);
            radBtnHamster.TabIndex = 20;
            radBtnHamster.TabStop = true;
            radBtnHamster.Text = "Hamster";
            radBtnHamster.UseVisualStyleBackColor = true;
            // 
            // radBtnHuron
            // 
            radBtnHuron.AutoSize = true;
            radBtnHuron.Enabled = false;
            radBtnHuron.Location = new Point(86, 22);
            radBtnHuron.Name = "radBtnHuron";
            radBtnHuron.Size = new Size(59, 19);
            radBtnHuron.TabIndex = 21;
            radBtnHuron.TabStop = true;
            radBtnHuron.Text = "Huron";
            radBtnHuron.UseVisualStyleBackColor = true;
            // 
            // radBtnTortuga
            // 
            radBtnTortuga.AutoSize = true;
            radBtnTortuga.Enabled = false;
            radBtnTortuga.Location = new Point(86, 40);
            radBtnTortuga.Name = "radBtnTortuga";
            radBtnTortuga.Size = new Size(65, 19);
            radBtnTortuga.TabIndex = 22;
            radBtnTortuga.TabStop = true;
            radBtnTortuga.Text = "Tortuga";
            radBtnTortuga.UseVisualStyleBackColor = true;
            // 
            // grpBoxMuerde
            // 
            grpBoxMuerde.Controls.Add(radBtnSiMuerde);
            grpBoxMuerde.Controls.Add(radBtnNoMuerde);
            grpBoxMuerde.Location = new Point(236, 116);
            grpBoxMuerde.Name = "grpBoxMuerde";
            grpBoxMuerde.Size = new Size(115, 48);
            grpBoxMuerde.TabIndex = 37;
            grpBoxMuerde.TabStop = false;
            grpBoxMuerde.Text = "Muerde?";
            // 
            // radBtnSiMuerde
            // 
            radBtnSiMuerde.AutoSize = true;
            radBtnSiMuerde.Enabled = false;
            radBtnSiMuerde.Location = new Point(23, 24);
            radBtnSiMuerde.Name = "radBtnSiMuerde";
            radBtnSiMuerde.Size = new Size(34, 19);
            radBtnSiMuerde.TabIndex = 29;
            radBtnSiMuerde.TabStop = true;
            radBtnSiMuerde.Text = "Sí";
            radBtnSiMuerde.UseVisualStyleBackColor = true;
            // 
            // radBtnNoMuerde
            // 
            radBtnNoMuerde.AutoSize = true;
            radBtnNoMuerde.Enabled = false;
            radBtnNoMuerde.Location = new Point(63, 24);
            radBtnNoMuerde.Name = "radBtnNoMuerde";
            radBtnNoMuerde.Size = new Size(41, 19);
            radBtnNoMuerde.TabIndex = 30;
            radBtnNoMuerde.TabStop = true;
            radBtnNoMuerde.Text = "No";
            radBtnNoMuerde.UseVisualStyleBackColor = true;
            // 
            // grpBoxRasguña
            // 
            grpBoxRasguña.Controls.Add(radBtnNoRasguña);
            grpBoxRasguña.Controls.Add(radBtnSiRasguña);
            grpBoxRasguña.Location = new Point(236, 118);
            grpBoxRasguña.Name = "grpBoxRasguña";
            grpBoxRasguña.Size = new Size(121, 46);
            grpBoxRasguña.TabIndex = 38;
            grpBoxRasguña.TabStop = false;
            grpBoxRasguña.Text = "Rasguña?";
            // 
            // radBtnNoRasguña
            // 
            radBtnNoRasguña.AutoSize = true;
            radBtnNoRasguña.Enabled = false;
            radBtnNoRasguña.Location = new Point(67, 22);
            radBtnNoRasguña.Name = "radBtnNoRasguña";
            radBtnNoRasguña.Size = new Size(41, 19);
            radBtnNoRasguña.TabIndex = 32;
            radBtnNoRasguña.TabStop = true;
            radBtnNoRasguña.Text = "No";
            radBtnNoRasguña.UseVisualStyleBackColor = true;
            // 
            // radBtnSiRasguña
            // 
            radBtnSiRasguña.AutoSize = true;
            radBtnSiRasguña.Enabled = false;
            radBtnSiRasguña.Location = new Point(22, 22);
            radBtnSiRasguña.Name = "radBtnSiRasguña";
            radBtnSiRasguña.Size = new Size(34, 19);
            radBtnSiRasguña.TabIndex = 31;
            radBtnSiRasguña.TabStop = true;
            radBtnSiRasguña.Text = "Sí";
            radBtnSiRasguña.UseVisualStyleBackColor = true;
            // 
            // grpBoxAlimentacion
            // 
            grpBoxAlimentacion.Controls.Add(radBtnAlimEsp);
            grpBoxAlimentacion.Controls.Add(radBtnCereales);
            grpBoxAlimentacion.Controls.Add(radBtnVegetales);
            grpBoxAlimentacion.Location = new Point(236, 119);
            grpBoxAlimentacion.Name = "grpBoxAlimentacion";
            grpBoxAlimentacion.Size = new Size(151, 57);
            grpBoxAlimentacion.TabIndex = 33;
            grpBoxAlimentacion.TabStop = false;
            grpBoxAlimentacion.Text = "Alimentación";
            // 
            // radBtnAlimEsp
            // 
            radBtnAlimEsp.AutoSize = true;
            radBtnAlimEsp.Enabled = false;
            radBtnAlimEsp.Location = new Point(13, 33);
            radBtnAlimEsp.Name = "radBtnAlimEsp";
            radBtnAlimEsp.Size = new Size(119, 19);
            radBtnAlimEsp.TabIndex = 28;
            radBtnAlimEsp.TabStop = true;
            radBtnAlimEsp.Text = "Alimento Especial";
            radBtnAlimEsp.UseVisualStyleBackColor = true;
            // 
            // radBtnCereales
            // 
            radBtnCereales.AutoSize = true;
            radBtnCereales.Enabled = false;
            radBtnCereales.Location = new Point(4, 13);
            radBtnCereales.Name = "radBtnCereales";
            radBtnCereales.Size = new Size(69, 19);
            radBtnCereales.TabIndex = 26;
            radBtnCereales.TabStop = true;
            radBtnCereales.Text = "Cereales";
            radBtnCereales.UseVisualStyleBackColor = true;
            // 
            // radBtnVegetales
            // 
            radBtnVegetales.AutoSize = true;
            radBtnVegetales.Enabled = false;
            radBtnVegetales.Location = new Point(73, 13);
            radBtnVegetales.Name = "radBtnVegetales";
            radBtnVegetales.Size = new Size(74, 19);
            radBtnVegetales.TabIndex = 27;
            radBtnVegetales.TabStop = true;
            radBtnVegetales.Text = "Vegetales";
            radBtnVegetales.UseVisualStyleBackColor = true;
            // 
            // txtApellidoDueño
            // 
            txtApellidoDueño.Location = new Point(295, 32);
            txtApellidoDueño.Name = "txtApellidoDueño";
            txtApellidoDueño.Size = new Size(88, 23);
            txtApellidoDueño.TabIndex = 39;
            // 
            // FrmMostrarMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 251);
            Controls.Add(txtApellidoDueño);
            Controls.Add(grpBoxRasguña);
            Controls.Add(grpBoxAlimentacion);
            Controls.Add(grpBoxMuerde);
            Controls.Add(grpBoxAnimal);
            Controls.Add(grpBoxGato);
            Controls.Add(grpBoxPerro);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(radBtnExotico);
            Controls.Add(radBtnGato);
            Controls.Add(radBtnPerro);
            Controls.Add(lblNombreDueño);
            Controls.Add(txtNombreDueño);
            Name = "FrmMostrarMascota";
            Text = "FrmMostrarMascota";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(txtNombreDueño, 0);
            Controls.SetChildIndex(lblNombreDueño, 0);
            Controls.SetChildIndex(radBtnPerro, 0);
            Controls.SetChildIndex(radBtnGato, 0);
            Controls.SetChildIndex(radBtnExotico, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(grpBoxPerro, 0);
            Controls.SetChildIndex(grpBoxGato, 0);
            Controls.SetChildIndex(grpBoxAnimal, 0);
            Controls.SetChildIndex(grpBoxMuerde, 0);
            Controls.SetChildIndex(grpBoxAlimentacion, 0);
            Controls.SetChildIndex(grpBoxRasguña, 0);
            Controls.SetChildIndex(txtApellidoDueño, 0);
            grpBoxPerro.ResumeLayout(false);
            grpBoxPerro.PerformLayout();
            grpBoxGato.ResumeLayout(false);
            grpBoxGato.PerformLayout();
            grpBoxAnimal.ResumeLayout(false);
            grpBoxAnimal.PerformLayout();
            grpBoxMuerde.ResumeLayout(false);
            grpBoxMuerde.PerformLayout();
            grpBoxRasguña.ResumeLayout(false);
            grpBoxRasguña.PerformLayout();
            grpBoxAlimentacion.ResumeLayout(false);
            grpBoxAlimentacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreDueño;
        private Label lblNombreDueño;
        private RadioButton radBtnExotico;
        private RadioButton radBtnGato;
        private RadioButton radBtnPerro;
        private Label lblEdad;
        private TextBox txtEdad;
        private GroupBox grpBoxPerro;
        private RadioButton radBtnCaniche;
        private RadioButton radBtnMestizo;
        private RadioButton radBtnBulldog;
        private RadioButton radBtnLabrador;
        private RadioButton radBtnGolden;
        private GroupBox grpBoxGato;
        private RadioButton radBtnSiames;
        private RadioButton radBtnPersa;
        private RadioButton radBtnSiberiano;
        private RadioButton radBtnEuropeo;
        private GroupBox grpBoxAnimal;
        private RadioButton radBtnCobayo;
        private RadioButton radBtnHamster;
        private RadioButton radBtnHuron;
        private RadioButton radBtnTortuga;
        private GroupBox grpBoxMuerde;
        private RadioButton radBtnSiMuerde;
        private RadioButton radBtnNoMuerde;
        private GroupBox grpBoxRasguña;
        private RadioButton radBtnNoRasguña;
        private RadioButton radBtnSiRasguña;
        private GroupBox grpBoxAlimentacion;
        private RadioButton radBtnAlimEsp;
        private RadioButton radBtnCereales;
        private RadioButton radBtnVegetales;
        private TextBox txtApellidoDueño;
    }
}
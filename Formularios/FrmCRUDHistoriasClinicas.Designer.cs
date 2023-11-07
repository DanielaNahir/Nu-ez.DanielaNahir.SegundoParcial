namespace Formularios
{
    partial class FrmCRUDHistoriasClinicas
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
            grpBoxOrdenar = new GroupBox();
            grpBoxManera = new GroupBox();
            radBtnAscen = new RadioButton();
            radBtnDesc = new RadioButton();
            radBtnNombre = new RadioButton();
            radBtnEdad = new RadioButton();
            grpBoxOrdenar.SuspendLayout();
            grpBoxManera.SuspendLayout();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.Location = new Point(12, 27);
            lstVisor.Size = new Size(228, 229);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(261, 91);
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 48);
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(261, 131);
            btnModificar.Click += btnModificar_Click_1;
            // 
            // grpBoxOrdenar
            // 
            grpBoxOrdenar.Controls.Add(grpBoxManera);
            grpBoxOrdenar.Controls.Add(radBtnNombre);
            grpBoxOrdenar.Controls.Add(radBtnEdad);
            grpBoxOrdenar.Location = new Point(12, 262);
            grpBoxOrdenar.Name = "grpBoxOrdenar";
            grpBoxOrdenar.Size = new Size(363, 75);
            grpBoxOrdenar.TabIndex = 7;
            grpBoxOrdenar.TabStop = false;
            grpBoxOrdenar.Text = "Ordenar";
            // 
            // grpBoxManera
            // 
            grpBoxManera.Controls.Add(radBtnAscen);
            grpBoxManera.Controls.Add(radBtnDesc);
            grpBoxManera.Location = new Point(186, 0);
            grpBoxManera.Name = "grpBoxManera";
            grpBoxManera.Size = new Size(177, 75);
            grpBoxManera.TabIndex = 4;
            grpBoxManera.TabStop = false;
            grpBoxManera.Text = "De manera:";
            // 
            // radBtnAscen
            // 
            radBtnAscen.AutoSize = true;
            radBtnAscen.Location = new Point(53, 46);
            radBtnAscen.Name = "radBtnAscen";
            radBtnAscen.Size = new Size(84, 19);
            radBtnAscen.TabIndex = 3;
            radBtnAscen.TabStop = true;
            radBtnAscen.Text = "Ascentente";
            radBtnAscen.UseVisualStyleBackColor = true;
            radBtnAscen.CheckedChanged += radBtnAscen_CheckedChanged;
            // 
            // radBtnDesc
            // 
            radBtnDesc.AutoSize = true;
            radBtnDesc.Location = new Point(53, 21);
            radBtnDesc.Name = "radBtnDesc";
            radBtnDesc.Size = new Size(93, 19);
            radBtnDesc.TabIndex = 2;
            radBtnDesc.TabStop = true;
            radBtnDesc.Text = "Descendente";
            radBtnDesc.UseVisualStyleBackColor = true;
            radBtnDesc.CheckedChanged += radBtnDesc_CheckedChanged;
            // 
            // radBtnNombre
            // 
            radBtnNombre.AutoSize = true;
            radBtnNombre.Location = new Point(6, 22);
            radBtnNombre.Name = "radBtnNombre";
            radBtnNombre.Size = new Size(69, 19);
            radBtnNombre.TabIndex = 1;
            radBtnNombre.TabStop = true;
            radBtnNombre.Text = "Nombre";
            radBtnNombre.UseVisualStyleBackColor = true;
            radBtnNombre.CheckedChanged += radBtnNombre_CheckedChanged;
            // 
            // radBtnEdad
            // 
            radBtnEdad.AutoSize = true;
            radBtnEdad.Location = new Point(129, 22);
            radBtnEdad.Name = "radBtnEdad";
            radBtnEdad.Size = new Size(51, 19);
            radBtnEdad.TabIndex = 0;
            radBtnEdad.TabStop = true;
            radBtnEdad.Text = "Edad";
            radBtnEdad.UseVisualStyleBackColor = true;
            radBtnEdad.CheckedChanged += radBtnEdad_CheckedChanged;
            // 
            // FrmCRUDHistoriasClinicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 345);
            Controls.Add(grpBoxOrdenar);
            Location = new Point(0, 0);
            Name = "FrmCRUDHistoriasClinicas";
            FormClosing += FrmHistoriasClinicasMascotas_FormClosing;
            Load += FrmHistoriasClinicasMascotas_Load;
            Controls.SetChildIndex(lstVisor, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(grpBoxOrdenar, 0);
            grpBoxOrdenar.ResumeLayout(false);
            grpBoxOrdenar.PerformLayout();
            grpBoxManera.ResumeLayout(false);
            grpBoxManera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBoxOrdenar;
        private RadioButton radBtnAscen;
        private RadioButton radBtnDesc;
        private RadioButton radBtnNombre;
        private RadioButton radBtnEdad;
        private GroupBox grpBoxManera;
    }
}
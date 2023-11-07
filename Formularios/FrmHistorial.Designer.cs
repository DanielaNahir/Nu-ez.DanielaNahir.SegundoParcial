namespace Formularios
{
    partial class FrmHistorial
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
            lstHistorial = new ListBox();
            SuspendLayout();
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(1, 3);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(203, 214);
            lstHistorial.TabIndex = 0;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 220);
            Controls.Add(lstHistorial);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHistorial";
            Text = "Form1";
            Load += FrmHistoria_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstHistorial;
    }
}
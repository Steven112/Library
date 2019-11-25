namespace LibraryServices.UI.Registros
{
    partial class Ayuda
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
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(12, 36);
            this.DireccionTextBox.Multiline = true;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(251, 120);
            this.DireccionTextBox.TabIndex = 38;
            this.DireccionTextBox.Text = "Puedes obtener informacion de como funciona este programa aqui: https://github.co" +
    "m/Steven112/ProyectoFinal/blob/master/LREADME.md";
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryServices.Properties.Resources.fdfe18cc8108550335a9117e297f2fa1_diseno_de_plantilla_de_logotipo_de_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(275, 196);
            this.Controls.Add(this.DireccionTextBox);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DireccionTextBox;
    }
}
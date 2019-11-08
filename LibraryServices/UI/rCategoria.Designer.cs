namespace LibraryServices.UI
{
    partial class rCategoria
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
            this.IntroduccionTextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IdcategorianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdcategorianumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IntroduccionTextBox
            // 
            this.IntroduccionTextBox.BackColor = System.Drawing.Color.White;
            this.IntroduccionTextBox.Location = new System.Drawing.Point(154, 102);
            this.IntroduccionTextBox.Multiline = true;
            this.IntroduccionTextBox.Name = "IntroduccionTextBox";
            this.IntroduccionTextBox.Size = new System.Drawing.Size(132, 23);
            this.IntroduccionTextBox.TabIndex = 38;
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.Color.White;
            this.NombretextBox.Location = new System.Drawing.Point(154, 76);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(132, 20);
            this.NombretextBox.TabIndex = 37;
            // 
            // IdcategorianumericUpDown
            // 
            this.IdcategorianumericUpDown.BackColor = System.Drawing.Color.White;
            this.IdcategorianumericUpDown.Location = new System.Drawing.Point(154, 50);
            this.IdcategorianumericUpDown.Name = "IdcategorianumericUpDown";
            this.IdcategorianumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.IdcategorianumericUpDown.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(62, 160);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 60);
            this.Nuevobutton.TabIndex = 40;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(143, 160);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 60);
            this.Guardarbutton.TabIndex = 41;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(224, 160);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 60);
            this.Eliminarbutton.TabIndex = 42;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Introduccion:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(235, 50);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(51, 23);
            this.Buscarbutton.TabIndex = 45;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // rCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 232);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntroduccionTextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdcategorianumericUpDown);
            this.Name = "rCategoria";
            this.Text = "rCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.IdcategorianumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IntroduccionTextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.NumericUpDown IdcategorianumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscarbutton;
    }
}
﻿namespace LibraryServices.UI
{
    partial class rLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditoracomboBox = new System.Windows.Forms.ComboBox();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.LibroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuvobutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.FeechaLibrodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarCategoriabutton = new System.Windows.Forms.Button();
            this.AgregarEditorialbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // EditoracomboBox
            // 
            this.EditoracomboBox.FormattingEnabled = true;
            this.EditoracomboBox.Location = new System.Drawing.Point(135, 172);
            this.EditoracomboBox.Name = "EditoracomboBox";
            this.EditoracomboBox.Size = new System.Drawing.Size(106, 21);
            this.EditoracomboBox.TabIndex = 45;
            this.EditoracomboBox.SelectedIndexChanged += new System.EventHandler(this.EditoracomboBox_SelectedIndexChanged);
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(135, 119);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(106, 21);
            this.CategoriacomboBox.TabIndex = 43;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(135, 93);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(145, 20);
            this.ISBNtextBox.TabIndex = 42;
            // 
            // LibroIdnumericUpDown
            // 
            this.LibroIdnumericUpDown.Location = new System.Drawing.Point(135, 41);
            this.LibroIdnumericUpDown.Name = "LibroIdnumericUpDown";
            this.LibroIdnumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.LibroIdnumericUpDown.TabIndex = 46;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(135, 67);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(145, 20);
            this.NombretextBox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Editorial:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(247, 38);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(33, 23);
            this.Buscarbutton.TabIndex = 51;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Nuvobutton
            // 
            this.Nuvobutton.Location = new System.Drawing.Point(37, 207);
            this.Nuvobutton.Name = "Nuvobutton";
            this.Nuvobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuvobutton.TabIndex = 52;
            this.Nuvobutton.Text = "Nuevo";
            this.Nuvobutton.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(118, 207);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 57);
            this.Agregarbutton.TabIndex = 53;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(199, 207);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 54;
            this.Eliminarbutton.Text = "Nuevo";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // FeechaLibrodateTimePicker
            // 
            this.FeechaLibrodateTimePicker.Location = new System.Drawing.Point(135, 146);
            this.FeechaLibrodateTimePicker.Name = "FeechaLibrodateTimePicker";
            this.FeechaLibrodateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.FeechaLibrodateTimePicker.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Impresion:";
            // 
            // AgregarCategoriabutton
            // 
            this.AgregarCategoriabutton.Location = new System.Drawing.Point(247, 119);
            this.AgregarCategoriabutton.Name = "AgregarCategoriabutton";
            this.AgregarCategoriabutton.Size = new System.Drawing.Size(33, 23);
            this.AgregarCategoriabutton.TabIndex = 57;
            this.AgregarCategoriabutton.UseVisualStyleBackColor = true;
            // 
            // AgregarEditorialbutton
            // 
            this.AgregarEditorialbutton.Location = new System.Drawing.Point(247, 172);
            this.AgregarEditorialbutton.Name = "AgregarEditorialbutton";
            this.AgregarEditorialbutton.Size = new System.Drawing.Size(33, 23);
            this.AgregarEditorialbutton.TabIndex = 58;
            this.AgregarEditorialbutton.UseVisualStyleBackColor = true;
            // 
            // rLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 276);
            this.Controls.Add(this.AgregarEditorialbutton);
            this.Controls.Add(this.AgregarCategoriabutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FeechaLibrodateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Nuvobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditoracomboBox);
            this.Controls.Add(this.CategoriacomboBox);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.LibroIdnumericUpDown);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label1);
            this.Name = "rLibro";
            this.Text = "Registro Libro";
            this.Load += new System.EventHandler(this.RLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EditoracomboBox;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.NumericUpDown LibroIdnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuvobutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DateTimePicker FeechaLibrodateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarCategoriabutton;
        private System.Windows.Forms.Button AgregarEditorialbutton;
    }
}
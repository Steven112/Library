﻿namespace LibraryServices.UI
{
    partial class rPrestamoLibro
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
            this.MatriculatextBox = new System.Windows.Forms.MaskedTextBox();
            this.IdprestamoidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaPrestamodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LibrocomboBox = new System.Windows.Forms.ComboBox();
            this.LectorcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaDevoluciondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdprestamoidnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatriculatextBox
            // 
            this.MatriculatextBox.Location = new System.Drawing.Point(127, 91);
            this.MatriculatextBox.Mask = "0000-0000";
            this.MatriculatextBox.Name = "MatriculatextBox";
            this.MatriculatextBox.Size = new System.Drawing.Size(96, 20);
            this.MatriculatextBox.TabIndex = 124;
            this.MatriculatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdprestamoidnumericUpDown
            // 
            this.IdprestamoidnumericUpDown.Location = new System.Drawing.Point(127, 38);
            this.IdprestamoidnumericUpDown.Name = "IdprestamoidnumericUpDown";
            this.IdprestamoidnumericUpDown.Size = new System.Drawing.Size(96, 20);
            this.IdprestamoidnumericUpDown.TabIndex = 121;
            // 
            // FechaPrestamodateTimePicker
            // 
            this.FechaPrestamodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaPrestamodateTimePicker.Location = new System.Drawing.Point(127, 142);
            this.FechaPrestamodateTimePicker.Name = "FechaPrestamodateTimePicker";
            this.FechaPrestamodateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaPrestamodateTimePicker.TabIndex = 120;
            // 
            // LibrocomboBox
            // 
            this.LibrocomboBox.FormattingEnabled = true;
            this.LibrocomboBox.Location = new System.Drawing.Point(127, 117);
            this.LibrocomboBox.Name = "LibrocomboBox";
            this.LibrocomboBox.Size = new System.Drawing.Size(214, 21);
            this.LibrocomboBox.TabIndex = 119;
            // 
            // LectorcomboBox
            // 
            this.LectorcomboBox.FormattingEnabled = true;
            this.LectorcomboBox.Location = new System.Drawing.Point(127, 64);
            this.LectorcomboBox.Name = "LectorcomboBox";
            this.LectorcomboBox.Size = new System.Drawing.Size(214, 21);
            this.LectorcomboBox.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Fecha Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Titulo Libro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Fecha Prestamo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Nombre Estudiante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Matricula Estudiante:";
            // 
            // FechaDevoluciondateTimePicker
            // 
            this.FechaDevoluciondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDevoluciondateTimePicker.Location = new System.Drawing.Point(127, 168);
            this.FechaDevoluciondateTimePicker.Name = "FechaDevoluciondateTimePicker";
            this.FechaDevoluciondateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaDevoluciondateTimePicker.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AñadirButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 227);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Image = global::LibraryServices.Properties.Resources.icons8_eliminar_propiedad_35;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(328, 427);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 55);
            this.EliminarButton.TabIndex = 134;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Image = global::LibraryServices.Properties.Resources.icons8_guardar_35;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(237, 427);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(85, 55);
            this.GuardarButton.TabIndex = 133;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Image = global::LibraryServices.Properties.Resources.icons8_agregar_propiedad_35;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(146, 427);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(85, 55);
            this.NuevoButton.TabIndex = 132;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(248, 38);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(93, 23);
            this.Buscarbutton.TabIndex = 131;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::LibraryServices.Properties.Resources.icons8_remover_etiqueta_20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover Fila";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AñadirButton
            // 
            this.AñadirButton.Image = global::LibraryServices.Properties.Resources.icons8_añadir_subnodo_20;
            this.AñadirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirButton.Location = new System.Drawing.Point(450, 6);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(80, 26);
            this.AñadirButton.TabIndex = 1;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirButton.UseVisualStyleBackColor = true;
            // 
            // rPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 494);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaDevoluciondateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatriculatextBox);
            this.Controls.Add(this.IdprestamoidnumericUpDown);
            this.Controls.Add(this.FechaPrestamodateTimePicker);
            this.Controls.Add(this.LibrocomboBox);
            this.Controls.Add(this.LectorcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "rPrestamoLibro";
            this.Text = "rPrestamoLibro";
            ((System.ComponentModel.ISupportInitialize)(this.IdprestamoidnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MatriculatextBox;
        private System.Windows.Forms.NumericUpDown IdprestamoidnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaPrestamodateTimePicker;
        private System.Windows.Forms.ComboBox LibrocomboBox;
        private System.Windows.Forms.ComboBox LectorcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaDevoluciondateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}
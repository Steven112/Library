namespace LibraryServices.UI.Registros
{
    partial class rDevlucion
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
            this.components = new System.ComponentModel.Container();
            this.DisponiblecheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.FechaEntregadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PrestamogroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.DevoluciondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.LibrocomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrestamoIdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BuscarPrestamobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            this.PrestamogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisponiblecheckBox
            // 
            this.DisponiblecheckBox.AutoSize = true;
            this.DisponiblecheckBox.Location = new System.Drawing.Point(16, 65);
            this.DisponiblecheckBox.Name = "DisponiblecheckBox";
            this.DisponiblecheckBox.Size = new System.Drawing.Size(75, 17);
            this.DisponiblecheckBox.TabIndex = 170;
            this.DisponiblecheckBox.Text = "Disponible";
            this.DisponiblecheckBox.UseVisualStyleBackColor = true;
            this.DisponiblecheckBox.CheckedChanged += new System.EventHandler(this.DisponiblecheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "Id:";
            // 
            // IdnumericUpDown1
            // 
            this.IdnumericUpDown1.Location = new System.Drawing.Point(176, 23);
            this.IdnumericUpDown1.Name = "IdnumericUpDown1";
            this.IdnumericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.IdnumericUpDown1.TabIndex = 166;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(this.AñadirButton);
            this.groupBox1.Controls.Add(this.MydataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 227);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // MydataGridView
            // 
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Location = new System.Drawing.Point(16, 38);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.Size = new System.Drawing.Size(433, 153);
            this.MydataGridView.TabIndex = 0;
            // 
            // FechaEntregadateTimePicker
            // 
            this.FechaEntregadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaEntregadateTimePicker.Location = new System.Drawing.Point(176, 49);
            this.FechaEntregadateTimePicker.Name = "FechaEntregadateTimePicker";
            this.FechaEntregadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaEntregadateTimePicker.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 176;
            this.label5.Text = "Fecha En que se Devolvio Libro:";
            // 
            // PrestamogroupBox
            // 
            this.PrestamogroupBox.Controls.Add(this.label2);
            this.PrestamogroupBox.Controls.Add(this.BuscarPrestamobutton);
            this.PrestamogroupBox.Controls.Add(this.PrestamoIdnumericUpDown1);
            this.PrestamogroupBox.Controls.Add(this.label1);
            this.PrestamogroupBox.Controls.Add(this.EstudiantecomboBox);
            this.PrestamogroupBox.Controls.Add(this.DevoluciondateTimePicker);
            this.PrestamogroupBox.Controls.Add(this.label6);
            this.PrestamogroupBox.Controls.Add(this.LibrocomboBox);
            this.PrestamogroupBox.Controls.Add(this.label9);
            this.PrestamogroupBox.Location = new System.Drawing.Point(14, 105);
            this.PrestamogroupBox.Name = "PrestamogroupBox";
            this.PrestamogroupBox.Size = new System.Drawing.Size(462, 151);
            this.PrestamogroupBox.TabIndex = 177;
            this.PrestamogroupBox.TabStop = false;
            this.PrestamogroupBox.Text = "Datos Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 174;
            this.label1.Text = "Fecha Devolucion Establecida:";
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(174, 70);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(214, 21);
            this.EstudiantecomboBox.TabIndex = 145;
            // 
            // DevoluciondateTimePicker
            // 
            this.DevoluciondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DevoluciondateTimePicker.Location = new System.Drawing.Point(174, 124);
            this.DevoluciondateTimePicker.Name = "DevoluciondateTimePicker";
            this.DevoluciondateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.DevoluciondateTimePicker.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 142;
            this.label6.Text = "Nombre Estudiante:";
            // 
            // LibrocomboBox
            // 
            this.LibrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LibrocomboBox.FormattingEnabled = true;
            this.LibrocomboBox.Location = new System.Drawing.Point(174, 97);
            this.LibrocomboBox.Name = "LibrocomboBox";
            this.LibrocomboBox.Size = new System.Drawing.Size(214, 21);
            this.LibrocomboBox.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 137;
            this.label9.Text = "Titulo Libro:";
            // 
            // PrestamoIdnumericUpDown1
            // 
            this.PrestamoIdnumericUpDown1.Location = new System.Drawing.Point(174, 44);
            this.PrestamoIdnumericUpDown1.Name = "PrestamoIdnumericUpDown1";
            this.PrestamoIdnumericUpDown1.Size = new System.Drawing.Size(108, 20);
            this.PrestamoIdnumericUpDown1.TabIndex = 175;
            // 
            // BuscarPrestamobutton
            // 
            this.BuscarPrestamobutton.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.BuscarPrestamobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarPrestamobutton.Location = new System.Drawing.Point(288, 44);
            this.BuscarPrestamobutton.Name = "BuscarPrestamobutton";
            this.BuscarPrestamobutton.Size = new System.Drawing.Size(100, 23);
            this.BuscarPrestamobutton.TabIndex = 176;
            this.BuscarPrestamobutton.Text = "Buscar";
            this.BuscarPrestamobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarPrestamobutton.UseVisualStyleBackColor = true;
            this.BuscarPrestamobutton.Click += new System.EventHandler(this.BuscarPrestamobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(227, 23);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(69, 23);
            this.Buscarbutton.TabIndex = 174;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::LibraryServices.Properties.Resources.icons8_remover_etiqueta_20;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(16, 197);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(107, 30);
            this.Removerbutton.TabIndex = 2;
            this.Removerbutton.Text = "Remover Fila";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // AñadirButton
            // 
            this.AñadirButton.Image = global::LibraryServices.Properties.Resources.icons8_añadir_subnodo_20;
            this.AñadirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirButton.Location = new System.Drawing.Point(353, 6);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(96, 26);
            this.AñadirButton.TabIndex = 1;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Image = global::LibraryServices.Properties.Resources.icons8_eliminar_propiedad_35;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(295, 516);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 55);
            this.EliminarButton.TabIndex = 162;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Image = global::LibraryServices.Properties.Resources.icons8_guardar_35;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(204, 516);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(85, 55);
            this.GuardarButton.TabIndex = 161;
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
            this.NuevoButton.Location = new System.Drawing.Point(113, 516);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(85, 55);
            this.NuevoButton.TabIndex = 160;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 177;
            this.label2.Text = "PrestamoId:";
            // 
            // rDevlucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 583);
            this.Controls.Add(this.PrestamogroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaEntregadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DisponiblecheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdnumericUpDown1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "rDevlucion";
            this.Text = "rDevlucion";
            this.Load += new System.EventHandler(this.RDevlucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            this.PrestamogroupBox.ResumeLayout(false);
            this.PrestamogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DisponiblecheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaEntregadateTimePicker;
        private System.Windows.Forms.GroupBox PrestamogroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.DateTimePicker DevoluciondateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LibrocomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PrestamoIdnumericUpDown1;
        private System.Windows.Forms.Button BuscarPrestamobutton;
        private System.Windows.Forms.Label label2;
    }
}
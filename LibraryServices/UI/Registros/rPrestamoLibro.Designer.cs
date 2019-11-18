namespace LibraryServices.UI
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
            this.components = new System.ComponentModel.Container();
            this.PrestamoidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaPrestamodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LibrocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaDevoluciondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoidnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PrestamoidnumericUpDown
            // 
            this.PrestamoidnumericUpDown.Location = new System.Drawing.Point(127, 38);
            this.PrestamoidnumericUpDown.Name = "PrestamoidnumericUpDown";
            this.PrestamoidnumericUpDown.Size = new System.Drawing.Size(96, 20);
            this.PrestamoidnumericUpDown.TabIndex = 121;
            // 
            // FechaPrestamodateTimePicker
            // 
            this.FechaPrestamodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaPrestamodateTimePicker.Location = new System.Drawing.Point(440, 38);
            this.FechaPrestamodateTimePicker.Name = "FechaPrestamodateTimePicker";
            this.FechaPrestamodateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaPrestamodateTimePicker.TabIndex = 120;
            // 
            // LibrocomboBox
            // 
            this.LibrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LibrocomboBox.FormattingEnabled = true;
            this.LibrocomboBox.Location = new System.Drawing.Point(127, 111);
            this.LibrocomboBox.Name = "LibrocomboBox";
            this.LibrocomboBox.Size = new System.Drawing.Size(214, 21);
            this.LibrocomboBox.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Fecha Devolucion";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
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
            this.label4.Location = new System.Drawing.Point(347, 38);
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
            // FechaDevoluciondateTimePicker
            // 
            this.FechaDevoluciondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDevoluciondateTimePicker.Location = new System.Drawing.Point(127, 139);
            this.FechaDevoluciondateTimePicker.Name = "FechaDevoluciondateTimePicker";
            this.FechaDevoluciondateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaDevoluciondateTimePicker.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(this.AñadirButton);
            this.groupBox1.Controls.Add(this.MydataGridView);
            this.groupBox1.Location = new System.Drawing.Point(49, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 227);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
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
            this.AñadirButton.Location = new System.Drawing.Point(344, 6);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(88, 26);
            this.AñadirButton.TabIndex = 1;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // MydataGridView
            // 
            this.MydataGridView.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Location = new System.Drawing.Point(16, 38);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.Size = new System.Drawing.Size(400, 153);
            this.MydataGridView.TabIndex = 0;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::LibraryServices.Properties.Resources.icons8_imprimir_35;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(358, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 135;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Image = global::LibraryServices.Properties.Resources.icons8_eliminar_propiedad_35;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(267, 427);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 55);
            this.EliminarButton.TabIndex = 134;
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
            this.GuardarButton.Location = new System.Drawing.Point(176, 427);
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
            this.NuevoButton.Location = new System.Drawing.Point(85, 427);
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
            this.Buscarbutton.Location = new System.Drawing.Point(229, 38);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(112, 23);
            this.Buscarbutton.TabIndex = 131;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(127, 65);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(214, 21);
            this.EstudiantecomboBox.TabIndex = 136;
            // 
            // rPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryServices.Properties.Resources.fdfe18cc8108550335a9117e297f2fa1_diseno_de_plantilla_de_logotipo_de_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 494);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaDevoluciondateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrestamoidnumericUpDown);
            this.Controls.Add(this.FechaPrestamodateTimePicker);
            this.Controls.Add(this.LibrocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "rPrestamoLibro";
            this.Text = "rPrestamoLibro";
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoidnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown PrestamoidnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaPrestamodateTimePicker;
        private System.Windows.Forms.ComboBox LibrocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaDevoluciondateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
    }
}
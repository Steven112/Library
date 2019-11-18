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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.LibrocomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.FechaDevoluciondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechaEntregadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisponiblecheckBox
            // 
            this.DisponiblecheckBox.AutoSize = true;
            this.DisponiblecheckBox.Location = new System.Drawing.Point(380, 75);
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
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Estudiante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Titulo Libro:";
            // 
            // IdnumericUpDown1
            // 
            this.IdnumericUpDown1.Location = new System.Drawing.Point(76, 23);
            this.IdnumericUpDown1.Name = "IdnumericUpDown1";
            this.IdnumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.IdnumericUpDown1.TabIndex = 166;
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(76, 76);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudiantecomboBox.TabIndex = 165;
            this.EstudiantecomboBox.SelectedIndexChanged += new System.EventHandler(this.EstudiantecomboBox_SelectedIndexChanged);
            // 
            // LibrocomboBox
            // 
            this.LibrocomboBox.FormattingEnabled = true;
            this.LibrocomboBox.Location = new System.Drawing.Point(76, 49);
            this.LibrocomboBox.Name = "LibrocomboBox";
            this.LibrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.LibrocomboBox.TabIndex = 164;
            this.LibrocomboBox.SelectedIndexChanged += new System.EventHandler(this.LibrocomboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::LibraryServices.Properties.Resources.icons8_imprimir_35;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(329, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 163;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Image = global::LibraryServices.Properties.Resources.icons8_eliminar_propiedad_35;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(238, 362);
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
            this.GuardarButton.Location = new System.Drawing.Point(147, 362);
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
            this.NuevoButton.Location = new System.Drawing.Point(56, 362);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(85, 55);
            this.NuevoButton.TabIndex = 160;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 227);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
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
            // MydataGridView
            // 
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Location = new System.Drawing.Point(16, 38);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.Size = new System.Drawing.Size(433, 153);
            this.MydataGridView.TabIndex = 0;
            // 
            // FechaDevoluciondateTimePicker
            // 
            this.FechaDevoluciondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDevoluciondateTimePicker.Location = new System.Drawing.Point(380, 24);
            this.FechaDevoluciondateTimePicker.Name = "FechaDevoluciondateTimePicker";
            this.FechaDevoluciondateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaDevoluciondateTimePicker.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 173;
            this.label4.Text = "Fecha Devolucion Establecida:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(380, 98);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(96, 23);
            this.Buscarbutton.TabIndex = 174;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechaEntregadateTimePicker
            // 
            this.FechaEntregadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaEntregadateTimePicker.Location = new System.Drawing.Point(380, 50);
            this.FechaEntregadateTimePicker.Name = "FechaEntregadateTimePicker";
            this.FechaEntregadateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaEntregadateTimePicker.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 176;
            this.label5.Text = "Fecha En que se Devolvio Libro:";
            // 
            // rDevlucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaEntregadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaDevoluciondateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DisponiblecheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdnumericUpDown1);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.LibrocomboBox);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DisponiblecheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown1;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.ComboBox LibrocomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaDevoluciondateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaEntregadateTimePicker;
    }
}
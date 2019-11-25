namespace LibraryServices.UI
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
            this.components = new System.ComponentModel.Container();
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
            this.FeechaLibrodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarEditorialbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.AgregarCategoriabutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Nuvobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // EditoracomboBox
            // 
            this.EditoracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditoracomboBox.FormattingEnabled = true;
            this.EditoracomboBox.Location = new System.Drawing.Point(135, 172);
            this.EditoracomboBox.Name = "EditoracomboBox";
            this.EditoracomboBox.Size = new System.Drawing.Size(106, 21);
            this.EditoracomboBox.TabIndex = 45;
            this.EditoracomboBox.SelectedIndexChanged += new System.EventHandler(this.EditoracomboBox_SelectedIndexChanged);
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Editorial:";
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
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Impresion:";
            // 
            // AgregarEditorialbutton
            // 
            this.AgregarEditorialbutton.Image = global::LibraryServices.Properties.Resources.icons8_crear_nuevo_16;
            this.AgregarEditorialbutton.Location = new System.Drawing.Point(247, 172);
            this.AgregarEditorialbutton.Name = "AgregarEditorialbutton";
            this.AgregarEditorialbutton.Size = new System.Drawing.Size(33, 23);
            this.AgregarEditorialbutton.TabIndex = 58;
            this.AgregarEditorialbutton.UseVisualStyleBackColor = true;
            this.AgregarEditorialbutton.Click += new System.EventHandler(this.AgregarEditorialbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.Buscarbutton.Location = new System.Drawing.Point(247, 41);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(33, 23);
            this.Buscarbutton.TabIndex = 59;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // AgregarCategoriabutton
            // 
            this.AgregarCategoriabutton.Image = global::LibraryServices.Properties.Resources.icons8_crear_nuevo_16;
            this.AgregarCategoriabutton.Location = new System.Drawing.Point(247, 119);
            this.AgregarCategoriabutton.Name = "AgregarCategoriabutton";
            this.AgregarCategoriabutton.Size = new System.Drawing.Size(33, 23);
            this.AgregarCategoriabutton.TabIndex = 57;
            this.AgregarCategoriabutton.UseVisualStyleBackColor = true;
            this.AgregarCategoriabutton.Click += new System.EventHandler(this.AgregarCategoriabutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::LibraryServices.Properties.Resources.icons8_eliminar_propiedad_35;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(205, 249);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 54;
            this.Eliminarbutton.Text = "Nuevo";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::LibraryServices.Properties.Resources.icons8_guardar_35;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(124, 249);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 57);
            this.Agregarbutton.TabIndex = 53;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Nuvobutton
            // 
            this.Nuvobutton.Image = global::LibraryServices.Properties.Resources.icons8_agregar_propiedad_351;
            this.Nuvobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuvobutton.Location = new System.Drawing.Point(43, 249);
            this.Nuvobutton.Name = "Nuvobutton";
            this.Nuvobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuvobutton.TabIndex = 52;
            this.Nuvobutton.Text = "Nuevo";
            this.Nuvobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuvobutton.UseVisualStyleBackColor = true;
            this.Nuvobutton.Click += new System.EventHandler(this.Nuvobutton_Click);
            // 
            // rLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryServices.Properties.Resources.fdfe18cc8108550335a9117e297f2fa1_diseno_de_plantilla_de_logotipo_de_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 314);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.AgregarEditorialbutton);
            this.Controls.Add(this.AgregarCategoriabutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FeechaLibrodateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Nuvobutton);
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
            this.Text = "Registros Libros";
            this.Load += new System.EventHandler(this.RLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
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
        private System.Windows.Forms.Button Nuvobutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DateTimePicker FeechaLibrodateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarCategoriabutton;
        private System.Windows.Forms.Button AgregarEditorialbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
    }
}
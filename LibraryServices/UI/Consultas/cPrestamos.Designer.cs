namespace LibraryServices.UI.Consultas
{
    partial class cPrestamos
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
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(651, 9);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 20);
            this.Imprimirbutton.TabIndex = 25;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(570, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(179, 9);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.Hasta_dateTimePicker.TabIndex = 22;
            this.Hasta_dateTimePicker.ValueChanged += new System.EventHandler(this.Hasta_dateTimePicker_ValueChanged);
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(50, 9);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.Desde_dateTimePicker.TabIndex = 21;
            this.Desde_dateTimePicker.ValueChanged += new System.EventHandler(this.Desde_dateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hasta:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desde:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(475, 9);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(89, 20);
            this.Criterio_textBox.TabIndex = 18;
            this.Criterio_textBox.TextChanged += new System.EventHandler(this.Criterio_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Criterio:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "todo",
            "ID",
            "Fecha",
            "Libros Vencidos"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(325, 8);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(96, 21);
            this.Filtro_comboBox.TabIndex = 16;
            this.Filtro_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filtro_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtrar Por :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 35);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(714, 234);
            this.ConsultadataGridView.TabIndex = 14;
            this.ConsultadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultadataGridView_CellContentClick);
            // 
            // cPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 279);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hasta_dateTimePicker);
            this.Controls.Add(this.Desde_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtro_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "cPrestamos";
            this.Text = "cPrestamos";
            this.Load += new System.EventHandler(this.CPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}
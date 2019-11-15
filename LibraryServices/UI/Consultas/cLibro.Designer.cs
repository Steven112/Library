namespace LibraryServices.UI.Consultas
{
    partial class cLibro
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
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.ConsultanumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(380, 301);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(75, 35);
            this.Consultarbutton.TabIndex = 61;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(227, 12);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.Hasta_dateTimePicker.TabIndex = 59;
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(63, 12);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.Desde_dateTimePicker.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Hasta";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Desde";
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(591, 13);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(139, 20);
            this.Criterio_textBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Criterio:";
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombre",
            "Fecha",
            "ISBN",
            "Categoria"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(418, 12);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Filtro_comboBox.TabIndex = 53;
            this.Filtro_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filtro_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Filtrar Por :";
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(12, 39);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.Size = new System.Drawing.Size(718, 256);
            this.Consulta_dataGridView.TabIndex = 51;
            this.Consulta_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Consulta_dataGridView_CellContentClick);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(276, 301);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 35);
            this.Imprimirbutton.TabIndex = 63;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // ConsultanumericUpDown
            // 
            this.ConsultanumericUpDown.Location = new System.Drawing.Point(591, 12);
            this.ConsultanumericUpDown.Name = "ConsultanumericUpDown";
            this.ConsultanumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.ConsultanumericUpDown.TabIndex = 62;
            this.ConsultanumericUpDown.Visible = false;
            this.ConsultanumericUpDown.ValueChanged += new System.EventHandler(this.ConsultanumericUpDown_ValueChanged);
            // 
            // cLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 348);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultanumericUpDown);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.Hasta_dateTimePicker);
            this.Controls.Add(this.Desde_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtro_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Name = "cLibro";
            this.Text = "cLibro";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.NumericUpDown ConsultanumericUpDown;
    }
}
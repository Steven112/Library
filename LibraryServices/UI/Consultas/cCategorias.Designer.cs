namespace LibraryServices.UI.Consultas
{
    partial class cCategorias
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
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MydataGridView
            // 
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Location = new System.Drawing.Point(12, 36);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.Size = new System.Drawing.Size(428, 150);
            this.MydataGridView.TabIndex = 0;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(243, 10);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(117, 20);
            this.CriteriotextBox.TabIndex = 1;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Descripcion"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(68, 9);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criterio:";
            // 
            // button1
            // 
            this.button1.Image = global::LibraryServices.Properties.Resources.icons8_búsqueda_de_propiedad_18;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(366, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.MydataGridView);
            this.Name = "cCategorias";
            this.Text = "cCategorias";
            this.Load += new System.EventHandler(this.CCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
namespace LibraryServices.UI.Registros
{
    partial class Logins
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
            this.label2 = new System.Windows.Forms.Label();
            this.UsercomboBox = new System.Windows.Forms.ComboBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // UsercomboBox
            // 
            this.UsercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsercomboBox.FormattingEnabled = true;
            this.UsercomboBox.Location = new System.Drawing.Point(119, 37);
            this.UsercomboBox.Name = "UsercomboBox";
            this.UsercomboBox.Size = new System.Drawing.Size(121, 21);
            this.UsercomboBox.TabIndex = 2;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Image = global::LibraryServices.Properties.Resources.icons8_entrar_35;
            this.Loginbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loginbutton.Location = new System.Drawing.Point(119, 141);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(121, 23);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Entrar";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(119, 76);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(121, 20);
            this.ContrasenatextBox.TabIndex = 3;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryServices.Properties.Resources.fdfe18cc8108550335a9117e297f2fa1_diseno_de_plantilla_de_logotipo_de_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 176);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.UsercomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logins";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UsercomboBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox ContrasenatextBox;
    }
}
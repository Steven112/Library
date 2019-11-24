namespace LibraryServices
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosVencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.editorialToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.devolucionToolStripMenuItem});
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.PrestamosToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.LibrosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.EditorialToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.DevolucionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem1,
            this.editorialToolStripMenuItem1,
            this.libroToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.prestamosToolStripMenuItem1,
            this.librosVencidosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // categoriasToolStripMenuItem1
            // 
            this.categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            this.categoriasToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.categoriasToolStripMenuItem1.Text = "Categorias";
            this.categoriasToolStripMenuItem1.Click += new System.EventHandler(this.CategoriasToolStripMenuItem1_Click);
            // 
            // editorialToolStripMenuItem1
            // 
            this.editorialToolStripMenuItem1.Name = "editorialToolStripMenuItem1";
            this.editorialToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.editorialToolStripMenuItem1.Text = "Editoriales";
            this.editorialToolStripMenuItem1.Click += new System.EventHandler(this.EditorialToolStripMenuItem1_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.libroToolStripMenuItem.Text = "Libros";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.LibroToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiantes";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.EstudianteToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            this.prestamosToolStripMenuItem1.Click += new System.EventHandler(this.PrestamosToolStripMenuItem1_Click);
            // 
            // librosVencidosToolStripMenuItem
            // 
            this.librosVencidosToolStripMenuItem.Name = "librosVencidosToolStripMenuItem";
            this.librosVencidosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.librosVencidosToolStripMenuItem.Text = "Libros Vencidos";
            this.librosVencidosToolStripMenuItem.Click += new System.EventHandler(this.LibrosVencidosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.BackColor = System.Drawing.Color.Transparent;
            this.Usuariolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Usuariolabel.Location = new System.Drawing.Point(13, 406);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(0, 13);
            this.Usuariolabel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryServices.Properties.Resources.fdfe18cc8108550335a9117e297f2fa1_diseno_de_plantilla_de_logotipo_de_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 447);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosVencidosToolStripMenuItem;
        private System.Windows.Forms.Label Usuariolabel;
    }
}


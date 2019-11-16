using LibraryServices.UI;
using LibraryServices.UI.Consultas;
using LibraryServices.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryServices
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamoLibro RP = new rPrestamoLibro();
            RP.Show();
        }

        private void LibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibro RL = new rLibro();
            RL.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoria RC = new rCategoria();
            RC.Show();
        }

        private void EditorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEditorial RE = new rEditorial();
            RE.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante RS = new rEstudiante();
            RS.Show();
        }

        private void CategoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCategorias CC = new cCategorias();
            CC.Show();
        }

        private void EditorialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEditorial CE = new cEditorial();
            CE.Show();
        }

        private void LibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLibro CL = new cLibro();
            CL.Show();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiante Ce = new cEstudiante();
            Ce.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

       


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rDevlucion dev = new rDevlucion();
            dev.Show();
        }
    }
}

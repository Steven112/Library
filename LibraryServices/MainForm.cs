using LibraryServices.UI;
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
    }
}

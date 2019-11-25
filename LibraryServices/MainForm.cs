using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
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
        public MainForm(int Usuario)
        {
            InitializeComponent();
        }

        private void BuscarUsuario(int Id)
        {
           RepositorioBase<Usuarios> generic = new RepositorioBase<Usuarios>(new Contexto());
            Usuarios usuario = generic.Buscar(Id);
            Usuariolabel.Text = usuario.Nombres;
        }

        private void PrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamoLibro RP = new rPrestamoLibro();
            RP.MdiParent = this;
            RP.Show();
        }

        private void LibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibro RL = new rLibro();
            RL.MdiParent = this;
            RL.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoria RC = new rCategoria();
            RC.MdiParent = this;
            RC.Show();
        }

        private void EditorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEditorial RE = new rEditorial();
            RE.MdiParent = this;
            RE.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante RS = new rEstudiante();
            RS.MdiParent = this;
            RS.Show();
        }

        private void CategoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCategorias CC = new cCategorias();
            CC.MdiParent = this;
            CC.Show();
        }

        private void EditorialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEditorial CE = new cEditorial();
            CE.MdiParent = this;
            CE.Show();
        }

        private void LibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLibro CL = new cLibro();
            CL.MdiParent = this;
            CL.Show();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiante Ce = new cEstudiante();
            Ce.MdiParent = this;
            Ce.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario user = new rUsuario();
            user.MdiParent = this;
            user.Show();
        }

       


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rDevlucion dev = new rDevlucion();
            dev.MdiParent = this;
            dev.Show();
        }

        private void PrestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPrestamos prestamos= new cPrestamos();
            prestamos.MdiParent = this;
            prestamos.Show();
        }

        private void LibrosVencidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDevoluciones vencido = new cDevoluciones();
            vencido.MdiParent = this;
            vencido.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda help = new Ayuda();
            help.MdiParent = this;
            help.Show();
        }
    }
}

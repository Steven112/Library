using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
using LibraryServices.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryServices.UI.Consultas
{
    public partial class cEditorial : Form
    {
        private RepositorioBase<Editorial> repository;
        private List<Editorial> editorials = new List<Editorial>();
        public cEditorial()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            repository = new RepositorioBase<Editorial>(new Contexto());
            Expression<Func<Editorial, bool>> filtro = a => true;
            int id;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:

                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.EditorialId == id;
                    break;
                case 2:
                    filtro = a => a.Nombre.Contains(CriteriotextBox.Text);

                    break;
                case 3:
                    filtro = a => a.Dirrecion.Contains(CriteriotextBox.Text);
                    break;




            }
            editorials = repository.GetList(filtro);
            MydataGridView.DataSource = repository.GetList(filtro);
        }

        private void MydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (editorials.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            EditorialR Report = new EditorialR(editorials);
            Report.ShowDialog();
        }
    }
}

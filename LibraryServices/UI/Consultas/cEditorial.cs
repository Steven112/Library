using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
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
                case 0: /// todos
                    break;
                case 1://por Id

                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.EditorialId == id;
                    break;
                case 2:// por nombre
                    filtro = a => a.Nombre.Contains(CriteriotextBox.Text);

                    break;
                case 3:
                    filtro = a => a.Dirrecion.Contains(CriteriotextBox.Text);
                    break;




            }
            MydataGridView.DataSource = repository.GetList(filtro);
        }

        private void MydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

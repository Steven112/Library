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
    public partial class cCategorias : Form
    {
        private RepositorioBase<Categoria> repository;
        public cCategorias()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            repository = new RepositorioBase<Categoria>(new Contexto());
            Expression<Func<Categoria, bool>> filtro = a => true;
            int id;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1://por Id

                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.CategoriaId == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.Descripcion.Contains(CriteriotextBox.Text);
                    break;

              


            }
            MydataGridView.DataSource = repository.GetList(filtro);
        }

        private void CCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}

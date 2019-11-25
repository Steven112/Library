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
    public partial class cUsuarios : Form
    {
        private List<Usuarios> User = new List<Usuarios>();
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void CUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:

                    id = Convert.ToInt32(CriteriotextBox.Text);

                    filtro = a => a.UsuarioId == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.Nombres.Contains(CriteriotextBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.FechaInsercion >= Desde_dateTimePicker.Value.Date && a.FechaInsercion <= Hasta_dateTimePicker.Value.Date;

                    break;
                case 4:// por ISBN

                    filtro = a => a.Celular.Contains(CriteriotextBox.Text);
                    break;


            }
            User = BLL.UsuariosBLL.GetList(filtro);
            Consulta_dataGridView.DataSource = User;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (User.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            UsuarioRP usuarioRP = new UsuarioRP(User);
            usuarioRP.ShowDialog();
        }
    }
}

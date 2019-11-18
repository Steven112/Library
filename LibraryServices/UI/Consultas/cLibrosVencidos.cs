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
    public partial class cLibrosVencidos : Form
    {
        private List<Devoluciones> prestamo = new List<Devoluciones>();
        public cLibrosVencidos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Expression<Func<Devoluciones, bool>> filtro = a => true;
            
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0:
                    filtro = c => c.FechaDevueltaLibro > c.FechaDevolucion;
                    break;

            }
            prestamo = BLL.DevolucionesBLL.GetList(filtro);
            ConsultadataGridView.DataSource = null;
           
            ConsultadataGridView.DataSource = prestamo;
        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

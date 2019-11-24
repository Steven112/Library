using LibraryServices.BLL;
using LibraryServices.Entdades;
using LibraryServices.UI.Reportes;
using LibraryServices.UI.Reportes.RPTConsutas;
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
    public partial class cPrestamos : Form
    {
       
        private List<Prestamo> prestamo = new List<Prestamo>();
        public cPrestamos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Expression<Func<Prestamo, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = c => c.PrestamoId == id;
                    break;
                case 2:
                    filtro = c => c.FechaPrestamo >= Desde_dateTimePicker.Value.Date && c.FechaPrestamo <= Hasta_dateTimePicker.Value.Date;
                    break;
                case 3:
                    filtro = c => c.FechaDevolucion < Desde_dateTimePicker.Value.Date;
                    break;

            }
            prestamo = BLL.PrestamoBLL.GetList(filtro);
            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = prestamo;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (prestamo.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            PrestamoRP Report = new PrestamoRP(prestamo);
            Report.ShowDialog();
        }

        private void Hasta_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Desde_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

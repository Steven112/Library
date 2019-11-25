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
    public partial class cDevoluciones : Form
    {
        private List<Devoluciones> prestamo = new List<Devoluciones>();
        public cDevoluciones()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Expression<Func<Devoluciones, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.DevolucionId == id;
                    break;
                case 2:
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LibroId == id;
                    break;
                case 3:
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.EstudianteId == id;
                    break;
                case 4:
                    filtro = a => a.FechaDevueltaLibro >= Desde_dateTimePicker.Value.Date && a.FechaDevueltaLibro <= Hasta_dateTimePicker.Value.Date;
                    break;
                case 5:
                    filtro = c => c.FechaDevueltaLibro > c.FechaDevolucion;
                    break;

            }

            prestamo = DevolucionesBLL.GetList(filtro);
            ConsultadataGridView.DataSource = DevolucionesBLL.GetList(filtro);
        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            
            if (prestamo.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            DevolucionesR Report = new DevolucionesR(prestamo);
            Report.ShowDialog();
        }

        private void CDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}

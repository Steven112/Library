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
    public partial class cLibro : Form
    {
        private List<Libro> Lib = new List<Libro>();
        public cLibro()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Libro, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:


                    id = Convert.ToInt32(ConsultanumericUpDown.Value);

                    filtro = a => a.LibroId == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.NombreLibro.Contains(Criterio_textBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.FechaImpresion >= Desde_dateTimePicker.Value.Date && a.FechaImpresion <= Hasta_dateTimePicker.Value.Date;

                    break;
                case 4:// por ISBN

                    filtro = a => a.ISBN.Contains(Criterio_textBox.Text);
                    break;
                case 5:// por CATEGORIA
                    id = Convert.ToInt32(ConsultanumericUpDown.Value);
                    filtro = a => a.CategoriaID == id;
                    break;

            }
            Lib = BLL.LibroBLL.GetList(filtro);
            Consulta_dataGridView.DataSource = Lib;


        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultanumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

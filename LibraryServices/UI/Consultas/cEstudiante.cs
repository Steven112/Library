using LibraryServices.BLL;
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
    public partial class cEstudiante : Form
    {
        private List<Estudiante> Est = new List<Estudiante>();
       
        public cEstudiante()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Estudiante, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:// por id
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.EstudianteId == id;
                    break;
                case 2:// por nombre
                    
                    filtro = a => a.Nombres.Contains(CriteriotextBox.Text);
                    break;
                case 3:// por Apellidos
                    
                    filtro = a => a.Apellidos.Contains(CriteriotextBox.Text);
                    break;
                case 4:// por matricula
                   
                    filtro = a => a.Matricula.Contains(CriteriotextBox.Text);
                    break;
                case 5:// por Telefono
                    
                    filtro = a => a.Celular.Contains(CriteriotextBox.Text);
                    break;
                case 6:// por Email
                   
                    filtro = a => a.Email.Contains(CriteriotextBox.Text);
                    break;
                case 7:// por direccion
                    
                    filtro = a => a.Direccion.Contains(CriteriotextBox.Text);
                    break;

                ///FECHA          
                case 8:
                    filtro = a => a.FechaInsercion >= Desde_dateTimePicker.Value.Date && a.FechaInsercion <= Hasta_dateTimePicker.Value.Date;

                    break;

            }

            Est =EstudianteBLL.GetList(filtro);
            Consulta_dataGridView.DataSource = Est;
            Consulta_dataGridView.ReadOnly = true;
        }


        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (Est.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            EstudianteReport estudianteReport = new EstudianteReport(Est);
            estudianteReport.ShowDialog();
        }
    }
}

using LibraryServices.Entdades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryServices.UI.Reportes
{
    public partial class EstudianteReport : Form
    {
        List<Estudiante> reporte;
        public EstudianteReport(List<Estudiante> estudiantes)
        {
            InitializeComponent();
            this.reporte = new List<Estudiante>();
        }

        private void EstudiantescrystalReportViewer1_Load(object sender, EventArgs e)
        {
           // reporte RP = new reporte();
        }
    }
}

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
        List<Estudiante> reporte = new List<Estudiante>();
        public EstudianteReport(List<Estudiante> estudiantes)
        {
            this.reporte = estudiantes;
            InitializeComponent();
            EstudentReport reporteEstudiantes = new EstudentReport();
            reporteEstudiantes.SetDataSource(reporte);

            EstudiantescrystalReportViewer1.ReportSource = reporteEstudiantes;
            EstudiantescrystalReportViewer1.Refresh();

        }

        private void EstudiantescrystalReportViewer1_Load(object sender, EventArgs e)
        {


            EstudentReport reporteEstudiantes = new EstudentReport();
            reporteEstudiantes.SetDataSource(reporte);

            EstudiantescrystalReportViewer1.ReportSource = reporteEstudiantes;
            EstudiantescrystalReportViewer1.Refresh();
        }
    }
}

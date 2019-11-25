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

namespace LibraryServices.UI.Reportes.RPTConsutas
{
    public partial class PrestamoRP : Form
    {
        List<Prestamo> reporte = new List<Prestamo>();
        public PrestamoRP(List<Prestamo> prestamos)
        {
            this.reporte = prestamos;
            InitializeComponent();
            cReportePrestamo report = new cReportePrestamo();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {
            cReportePrestamo report = new cReportePrestamo();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }
    }
}

using LibraryServices.Entdades;
using LibraryServices.UI.Reportes.RPT;
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
    public partial class PrestamoReportes : Form
    {
        List<PrestamosDetalle> reporte = new List<PrestamosDetalle>();
        public PrestamoReportes(List<PrestamosDetalle> prestamos)
        {
            InitializeComponent();
            Detalle detalle = new Detalle();
            detalle.SetDataSource(reporte);
            MycrystalReportViewer1.ReportSource = detalle;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle();
           detalle.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = detalle;
            MycrystalReportViewer1.Refresh();
        }
    }
}

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
    public partial class RPPrestamos : Form
    {
        List<PrestamosDetalle> reporte = new List<PrestamosDetalle>();
        public RPPrestamos(List<PrestamosDetalle> prestamos)
        {
            this.reporte = prestamos;
            InitializeComponent();
           PrestamosRP prestamosRP = new PrestamosRP();
            prestamosRP.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = prestamosRP;
            MycrystalReportViewer1.Refresh();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            PrestamosRP prestamosRP = new PrestamosRP();
            prestamosRP.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = prestamosRP;
            MycrystalReportViewer1.Refresh();
        }
    }
}

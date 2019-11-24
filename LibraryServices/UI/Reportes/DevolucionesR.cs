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
    public partial class DevolucionesR : Form
    {
        List<Devoluciones> reporte = new List<Devoluciones>();
        public DevolucionesR(List<Devoluciones> devoluciones)
        {
            this.reporte = devoluciones;
            InitializeComponent();
            DevolucionesRP report =new DevolucionesRP();
            report.SetDataSource(reporte);

            MyrystalReportViewer1.ReportSource = report;
            MyrystalReportViewer1.Refresh();

        }

        private void MyrystalReportViewer1_Load(object sender, EventArgs e)
        {
            DevolucionesRP report = new DevolucionesRP();
            report.SetDataSource(reporte);

            MyrystalReportViewer1.ReportSource = report;
            MyrystalReportViewer1.Refresh();
        }
    }
}

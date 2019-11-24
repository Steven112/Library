using LibraryServices.Entdades;
using LibraryServices.UI.Reportes.RPTConsutas;
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
    public partial class EditorialR : Form
    {
        List<Editorial> reporte = new List<Editorial>();
        public EditorialR(List<Editorial> editorials)
        {
            this.reporte = editorials;
            InitializeComponent();
            EditorialRP report = new EditorialRP();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {
            EditorialRP report = new EditorialRP();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }
    }
}

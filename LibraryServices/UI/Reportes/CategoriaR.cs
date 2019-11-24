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
    public partial class CategoriaR : Form
    {
        List<Categoria> reporte = new List<Categoria>();
        public CategoriaR(List<Categoria> categorias)
        {
            this.reporte = categorias;
            InitializeComponent();
            RPCategorias report = new RPCategorias();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {
            RPCategorias report = new RPCategorias();
            report.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = report;
            MycrystalReportViewer1.Refresh();
        }
    }
}

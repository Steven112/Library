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
    public partial class RPLibros : Form
    {
        List<Libro> reportes = new List<Libro>();
        public RPLibros(List<Libro> libros)
        {
            this.reportes = libros;
            InitializeComponent();
            LibrosRP reporte = new LibrosRP();
            reporte.SetDataSource(reportes);

            MycrystalReportViewer1.ReportSource = reporte;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibrosRP reporte = new LibrosRP();
            reporte.SetDataSource(reportes);

            MycrystalReportViewer1.ReportSource = reporte;
            MycrystalReportViewer1.Refresh();
        }
    }
}

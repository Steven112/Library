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
    public partial class UsuarioRP : Form
    {
        List<Usuarios> reporte = new List<Usuarios>();
        public UsuarioRP(List<Usuarios> usuarios)
        {
            this.reporte = usuarios;
            InitializeComponent();
            RPUsuarios rPUsuarios = new RPUsuarios();
            rPUsuarios.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = rPUsuarios;
            MycrystalReportViewer1.Refresh();
        }

        private void MycrystalReportViewer1_Load(object sender, EventArgs e)
        {

            RPUsuarios rPUsuarios = new RPUsuarios();
            rPUsuarios.SetDataSource(reporte);

            MycrystalReportViewer1.ReportSource = rPUsuarios;
            MycrystalReportViewer1.Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNorthwind.Reportes
{
    public partial class ReporteFactura : Form
    {
        public ReporteFactura()
        {
            InitializeComponent();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataReporte.Reporte_Factura' table. You can move, or remove it, as needed.
            this.Reporte_FacturaTableAdapter.Fill(this.DataReporte.Reporte_Factura, int.Parse(this.txtIdorden.Text));
            // TODO: This line of code loads data into the 'DataReporte.Reporte_Detalle_Factura' table. You can move, or remove it, as needed.
            this.Reporte_Detalle_FacturaTableAdapter.Fill(this.DataReporte.Reporte_Detalle_Factura, int.Parse(this.txtIdorden.Text));

            this.reportViewer1.RefreshReport();

          
        }
    }
}

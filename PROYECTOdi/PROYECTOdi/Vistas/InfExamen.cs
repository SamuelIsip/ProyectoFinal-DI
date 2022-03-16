using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOdi.Vistas
{
    public partial class InfExamen : Form
    {

        public DataTable tabla;

        public InfExamen()
        {
            InitializeComponent();
            tabla = new DataTable("DataTable2");
            tabla.Columns.Add("Num");
            tabla.Columns.Add("Enunciado");

        }
        public void crearExamen()
        {
            CrystalReport2 report = new CrystalReport2();
            report.Database.Tables["DataTable2"].SetDataSource(tabla);
            crystalReportViewer2.ReportSource = report;
        }
    }
}

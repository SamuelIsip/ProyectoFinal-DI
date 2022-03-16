using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOdi.Vistas
{
    public partial class Informe : Form
    {
        DataTable tabla;

        public Informe(OracleDataReader lector)
        {
            InitializeComponent();
            tabla = new DataTable("DataTable1");
            tabla.Columns.Add("Codigo Pregunta");
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Enunciado");
            tabla.Columns.Add("Respuesta");
            tabla.Columns.Add("Observaciones");

            while (lector.Read())
            {
                DataRow row = tabla.NewRow();
                row["Codigo Pregunta"] = lector["cod_p"].ToString();
                row["Tipo"] = lector["tipo"].ToString();
                row["Enunciado"] = lector["enunciado"].ToString();
                row["Respuesta"] = lector["respuesta"].ToString();
                row["Observaciones"] = lector["observ"].ToString();
                tabla.Rows.Add(row);
            }
            CrystalReport1 report = new CrystalReport1();
            report.Database.Tables["DataTable1"].SetDataSource(tabla);
            crystalReportViewer1.ReportSource = report;

        }
    }
}

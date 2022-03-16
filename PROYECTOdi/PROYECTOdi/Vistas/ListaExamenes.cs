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
    public partial class ListaExamenes : Form
    {
        Controlador.Conexiones c = new Controlador.Conexiones();
        public ListaExamenes()
        {
            InitializeComponent();
            rellenarDataGrid();
        }
        private void rellenarDataGrid()
        {
            //Creamos un Adaptador para el select, el resultado guardamos en DataTable y rellenamos el DataGrid con los datos del DataTable
            OracleDataAdapter dtas = new OracleDataAdapter("select * from examen", c.hacerConexion());
            DataTable dt = new DataTable();
            dtas.Fill(dt);
            dataGridExamenes.DataSource = dt;
            c.objConexion.Close();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vExamen_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                OracleDataAdapter dtas = new OracleDataAdapter("select enunciado from preguntas where cod_p in (select cod_pr from pr_ex where cod_ex = "+dataGridExamenes.CurrentRow.Cells[0].Value.ToString()+")", c.hacerConexion());

                dtas.Fill(dt);
                int numFilas = dt.Rows.Count;
                c.objConexion.Close();
                //Creamos objeto de la clase InfExamen
                InfExamen infEx = new InfExamen();
                for (int i = 0; i < numFilas; i++)
                {
                    DataRow row = infEx.tabla.NewRow();
                    row["Num"] = i + 1;
                    row["Enunciado"] = dt.Rows[i][0].ToString();
                    infEx.tabla.Rows.Add(row);

                }

                infEx.Show();
                infEx.crearExamen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay ningún examen seleccionado!");
                c.objConexion.Close();
            }
           
           
        }
    }
}

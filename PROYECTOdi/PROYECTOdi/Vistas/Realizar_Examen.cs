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
    public partial class Realizar_Examen : Form
    {
        Controlador.Conexiones c = new Controlador.Conexiones();
        String[] cev;
        public Realizar_Examen()
        {
            InitializeComponent();
            rellenarRA();
        }
        public void rellenarRA()
        {
            OracleDataReader datosRA;

            datosRA = c.selectRA();

            while (datosRA.Read())
            {
                rAprendizaje.Items.Add(datosRA[0]);
            }

            c.objConexion.Close();
        }
        private void lExamenes_Click(object sender, EventArgs e)
        {
            ListaExamenes lex = new ListaExamenes();
            lex.ShowDialog();
        }
        private int cuentaChecked()
        {
            int contador = 0;
            for (int i = 0; i < cEvaluacion.Items.Count; i++)
            {
                if (cEvaluacion.GetItemChecked(i)) contador++;
            }
            return contador;
        }

        private void rAprendizaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEvaluacion.Items.Clear();
            cEvaluacion.Text = "";
            string nombre = rAprendizaje.Text;
            OracleDataReader datosRA;

            datosRA = c.selectCEV(nombre);

            while (datosRA.Read())
            {
                cEvaluacion.Items.Add(datosRA[0]);
            }

            c.objConexion.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            cev = new String[cuentaChecked()];
            for (int i = 0; i < cEvaluacion.Items.Count; i++)
            {
                if (cEvaluacion.GetItemChecked(i))
                {
                    cev[x] = cEvaluacion.Items[i].ToString();
                    x++;
                }
                   
            }
            Examen ex = new Examen(cev);
            ex.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }
    }
}

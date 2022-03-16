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
using PROYECTOdi.Controlador;


namespace PROYECTOdi.Vistas
{
    public partial class Examen : Form
    {
        Conexiones c = new Conexiones();
        public Examen(String[] c)
        {
            InitializeComponent();
                rellenarDataGrid(c);
        }

        
        private void rellenarDataGrid(String[] cEv)
        {
            DataTable dt2 = new DataTable();

            for (int i = 0; i < cEv.Length; i++)
            {
                
                DataTable dt = new DataTable();
                OracleDataAdapter dtas = new OracleDataAdapter("select cod_p, cod_cev, tipo, enunciado from preguntas where cod_cev = (select cod_cev from cev where nombre = '" + cEv[i] + "')", c.hacerConexion());
                dtas.Fill(dt);
                dt2.Merge(dt);
                c.objConexion.Close();
            }

            preguntasExamen.DataSource = dt2;
           
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < preguntasExamen.Rows.Count;i++) {
                if (preguntasExamen.Rows[i].Selected)
                {
                    //Creamos un diálogo para preguntar si/no
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres quitar esa pregunta del examen?", "Borrar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        preguntasExamen.Rows.RemoveAt(i);
                    }
                }
            }
           /* if (i == preguntasExamen.Rows.Count) 
                MessageBox.Show("No has seleccionado ninguna pregunta.", "Atención!"); */
        }
        private void generarExamen()
        {
            string SQLInsert = "INSERT INTO EXAMEN(COD_EX, FECHA) VALUES(:cod_ex, :fecha)";
            

            OracleCommand objComando = c.hacerConexion().CreateCommand();

            objComando.CommandText = SQLInsert;
            objComando.CommandType = System.Data.CommandType.Text;


            objComando.Parameters.Add("cod_ex", OracleType.Number).Value = cExamen.Text;
            objComando.Parameters.Add("fecha", OracleType.VarChar).Value = DateTime.Now.ToString();

                objComando.ExecuteNonQuery();
                c.objConexion.Close();

                for (int i = 0; i < preguntasExamen.RowCount; i++)
                {
                    SQLInsert = "INSERT INTO PR_EX(COD_PR, COD_EX) VALUES(:cod_p, :cod_ex)";
                    objComando = c.hacerConexion().CreateCommand();

                    objComando.CommandText = SQLInsert;
                    objComando.CommandType = System.Data.CommandType.Text;

                    objComando.Parameters.Add("cod_p", OracleType.Number).Value = preguntasExamen.Rows[i].Cells[0].Value.ToString();
                    objComando.Parameters.Add("cod_ex", OracleType.Number).Value = cExamen.Text;
                    try
                    {
                        objComando.ExecuteNonQuery();
                        c.objConexion.Close();
                    }
                    catch (OracleException)
                    {
                        MessageBox.Show("No se ha podido generar el examen! Vuelve a intentarlo.2", "¡Vaya!");
                        c.objConexion.Close();
                    }
                }

              
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                generarExamen();

                //Codigo para el informe del exame.
                int numFilas = preguntasExamen.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;
                //Creamos objeto de la clase InfExamen
                InfExamen infEx = new InfExamen();

                OracleDataReader lector;
                for (int i = 0; i < numFilas; i++)
                {
                    lector = c.select("select enunciado from preguntas where cod_p=" + preguntasExamen.Rows[i].Cells[0].Value.ToString());
                    lector.Read();
                    DataRow row = infEx.tabla.NewRow();
                    row["Num"] = i + 1;
                    row["Enunciado"] = lector["enunciado"].ToString();


                    infEx.tabla.Rows.Add(row);
                    c.objConexion.Close();
                }

                infEx.Show();
                infEx.crearExamen();

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Debe introducir un Código de Examen!", "Vaya!");
                c.objConexion.Close();
            }
            catch (OracleException)
            {
                MessageBox.Show("Debe itroducir un Código de Examen distinto a los ya existentes (Visualice los examenes existentes)", "¡Vaya!");
                c.objConexion.Close();
            }
           
        }
    }
}

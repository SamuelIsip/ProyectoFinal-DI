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
using PROYECTOdi.Vistas;

namespace PROYECTOdi
{
    public partial class Gestionar_Preguntas : Form
    {

        private Preguntas pregunt;

        private Conexiones conx = new Conexiones();

 
        public Gestionar_Preguntas()
        {
            InitializeComponent();

            rellenarCombos();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        //Método para rellenar el DataGrid
        private void rellenarDataGrid(string nombre)
        {
            //Creamos un Adaptador para el select, el resultado guardamos en DataTable y rellenamos el DataGrid con los datos del DataTable
            OracleDataAdapter dtas = new OracleDataAdapter("select * from preguntas where cod_cev = (select cod_cev from cev where nombre = '"+ nombre + "')", conx.hacerConexion());
            DataTable dt = new DataTable();
            dtas.Fill(dt);
            dataGridPreguntas.DataSource = dt;
            conx.objConexion.Close();
        }

        //Método para rellenar los ComboBox con los RA y CE
        private void rellenarCombos()
        {
           
            OracleDataReader datosRA;

            datosRA = conx.selectRA();

            while (datosRA.Read())
            {
                combRA.Items.Add(datosRA[0]);
            }

            conx.objConexion.Close();
            

        }

        //Botón Salir
        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }

        //Botón Añadir, abrimos nuevo formulario sin pasarle datos
        private void button3_Click(object sender, EventArgs e)
        {
            int cod_cev = int.Parse(dataGridPreguntas.CurrentRow.Cells[1].Value.ToString());
            pregunt = new Preguntas(cod_cev,combCE.Text);
            pregunt.ShowDialog();
            combCE_SelectedIndexChanged(sender, e);
        }

        //Botón modificar, abrimos nuevo formulario pasando datos
        private void button2_Click(object sender, EventArgs e)
        {
            //Se comprueba que se haya seleccionado una fila de Grid
            if (dataGridPreguntas.Rows.Count != 0)
            {
                //Recogemos los datos de la fila seleccionada
                int cod_cev = int.Parse(dataGridPreguntas.CurrentRow.Cells[1].Value.ToString());
                string cod_cevNombre = combCE.Text;
                string tipo = dataGridPreguntas.CurrentRow.Cells[2].Value.ToString();
                string enunciado = dataGridPreguntas.CurrentRow.Cells[3].Value.ToString();
                string respuesta = dataGridPreguntas.CurrentRow.Cells[4].Value.ToString();
                string observ = dataGridPreguntas.CurrentRow.Cells[5].Value.ToString();

                //Pasamos los datos al nuevo form
                pregunt = new Preguntas(cod_cev, cod_cevNombre, tipo, enunciado, respuesta, observ);

                pregunt.ShowDialog(); //El código se pausa aquí hasta que se cierre ese Form

                //Actualizamos el Grid
                combCE_SelectedIndexChanged( sender,  e);

            }
            else
                MessageBox.Show("Debe seleccionar R. Aprendizaje y C.Evaluación", "Atención!");

        }

        //Seleccionar el RA y añadir los CE según éste
        private void combRA_SelectedIndexChanged(object sender, EventArgs e)
        {
            combCE.Items.Clear();
            combCE.Text = "";
            string nombre  = combRA.Text;
            OracleDataReader datosRA;

            datosRA = conx.selectCEV(nombre);

            while (datosRA.Read())
            {
                combCE.Items.Add(datosRA[0]);
            }

            conx.objConexion.Close();

            
        }

        //Tras seleccionar CE se actualiza el Grid
        private void combCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarDataGrid(combCE.Text.ToString());
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        //Botón Eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            //Comprobamos que se ha seleccionado una fila
            if (dataGridPreguntas.Rows.Count != 0)
            {
                //Creamos un diálogo para preguntar si/no
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar ese registro?", "Eliminar", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int cod_p = int.Parse(dataGridPreguntas.CurrentRow.Cells[0].Value.ToString());
                    int cod_cev = int.Parse(dataGridPreguntas.CurrentRow.Cells[1].Value.ToString());

                    OracleCommand eliminar = new OracleCommand("delete from preguntas where cod_p=" + cod_p + " and cod_cev=" + cod_cev, conx.hacerConexion());

                    try
                    {
                        //Eliminamos de la BD
                        eliminar.ExecuteNonQuery();
                        //Eliminamos del Grid
                        dataGridPreguntas.Rows.RemoveAt(dataGridPreguntas.CurrentRow.Index);
                        MessageBox.Show("¡Registro eliminado con éxito!", "Eliminar");
                    }
                    catch (OracleException)
                    {
                        MessageBox.Show("No se puede eliminar! Vuelva a intentarlo.", "¡Vaya!");
                        conx.objConexion.Close();
                    }
                    conx.objConexion.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //no hacer nada
                }
            }
            else
                MessageBox.Show("Debe seleccionar R. Aprendizaje y C.Evaluación", "Atención!");
        }
    }

}

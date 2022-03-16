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
    public partial class Generar_Informes : Form
    {

        //Creamos un objeto para poder hacer select de la base de datos
        Controlador.Conexiones c;
        //Creamos un lector de Oracle para poder leer los datos.
        OracleDataReader lector;
        public Generar_Informes()
        {
            InitializeComponent();
            //Al iniciar la ventana inicializamos la conexión
            c = new Controlador.Conexiones();
            //También rellenamos el ComboBox de los resultados de aprendizaje            
            rellenarRA(lector);
        }
        //Método que rellena el ComboBox de Resultados de Aprendizaje
        public void rellenarRA(OracleDataReader lector)
        {
            lector = c.selectRA();
            while (lector.Read())
            {
                cbRA.Items.Add(lector["nombre"].ToString());
            }
            c.objConexion.Close();
        }
        //Este método se activa cuando seleccionamos un valor del ComboBox de Resultados de Aprendizaje
        private void cbRA_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reseteamos el DataGrid y los label con los datos de las preguntas
            cbCEV.Enabled = true;
            cbCEV.Items.Clear();
            cbCEV.Text = "";
            lblTipo.Text = "Tipo de pregunta ";
            lblEnunciado.Text = "Enunciado ";
            lblRespuesta.Text = "Respuesta ";
            lblObservaciones.Text = "Observaciones ";
            dgPreguntas.DataSource = null;
            //Recogemos el RA seleccionado y hacemos la select.
            string ra = cbRA.Text;
            lector = c.selectCEV(ra);
            //Con los datos que devuelve la select rellenamos el ComboBox de Criterios de Evaluación.
            while (lector.Read())
            {
                cbCEV.Items.Add(lector["nombre"].ToString());
            }
            c.objConexion.Close();
            btnInforme.Enabled = false;

        }
        //Método que al seleccinar un CEV rellena el DataGrigView
        private void cbCEV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reseteamos los label al cambiar de CEV
            lblTipo.Text = "Tipo de pregunta ";
            lblEnunciado.Text = "Enunciado ";
            lblRespuesta.Text = "Respuesta ";
            lblObservaciones.Text = "Observaciones ";
            string cev = cbCEV.Text;
            lector = c.select("select cod_p,observ from preguntas where cod_cev=(select cod_cev from CEV where nombre='" + cev + "')");
            
            DataTable tabla = new DataTable();
            tabla.Load(lector);
            
            dgPreguntas.DataSource = tabla;
            
            c.objConexion.Close();
            btnInforme.Enabled = true;

            dgPreguntas.Rows[0].Selected = false;
            dgPreguntas.Columns[0].Width = 100;
        }
        //Método que se activa cuando pulsamos en un valor del DataGridView
        private void dgPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Reseteamos los label al cambiar de pregunta
            lblTipo.Text = "Tipo de pregunta ";
            lblEnunciado.Text = "Enunciado ";
            lblRespuesta.Text = "Respuesta ";
            lblObservaciones.Text = "Observaciones ";

            //Si la celda seleccionada no es null rellenamos los label con los datos de la pregunta.
            if (dgPreguntas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgPreguntas.CurrentRow.Selected = true;
                
                lector = c.select("select tipo,enunciado,respuesta,observ from preguntas where cod_p="+ dgPreguntas.Rows[e.RowIndex].Cells["COD_P"].FormattedValue.ToString());
                if (lector.Read())
                {
                    lblTipo.Text = lblTipo.Text + "\n"+lector["tipo"].ToString();
                    lblEnunciado.Text=lblEnunciado.Text + "\n" + lector["enunciado"].ToString();
                    lblRespuesta.Text= lblRespuesta.Text + "\n" + lector["respuesta"].ToString();
                    lblObservaciones.Text= lblObservaciones.Text + "\n" + lector["observ"].ToString();
                }
            }

            c.objConexion.Close();
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            lector = c.select("select cod_p,tipo,enunciado,respuesta,observ " +
                "from preguntas where cod_cev=(select cod_cev from cev where" +
                " nombre='"+cbCEV.Text+"')");
            Informe inf = new Informe(lector);
            c.objConexion.Close();
            inf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }
    }
}

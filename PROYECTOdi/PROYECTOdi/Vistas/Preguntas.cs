using PROYECTOdi.Controlador;
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

namespace PROYECTOdi
{
    public partial class Preguntas : Form
    {
        private Conexiones conx = new Conexiones();
  
        private Boolean modificar;
        private string enunci;
        private int cod_cev;
        
        public Preguntas(int cod_cev, string cod_cevNombre)
        {
            InitializeComponent();

            modificar = false;

            this.cod_cev = cod_cev;

            txtBoxCEV.Text = cod_cevNombre;

            button2.Text = "Insertar";

        }


        public void recorta(String prueba)
        {
            String enun, ra, rb, rc;
            int posA = 0, posB = 0, posC = 0;

            for (int i = 1; i < prueba.Length; i++)
            {
                if (prueba[i] == 'A')
                {
                    posA = i;
                }
                else if (prueba[i] == 'B')
                {
                    posB = i;
                }
                else if (prueba[i] == 'C')
                {
                    posC = i;
                }
            }

            enun = prueba.Substring(0, posA);
            ra = prueba.Substring(posA+2, posB - posA-2);
            rb = prueba.Substring(posB+2, posC - posB-2);
            rc = prueba.Substring(posC+2);

            txtBenunciado.Text = enun;
            txtBpA.Text = ra;
            txtBpB.Text = rb;
            txtBpC.Text = rc;

           

        }


        public Preguntas(int cod_cev, string cod_cevNombre, string tipo, string enunciado, string respuesta, string observ)
        {
            InitializeComponent();
            
            modificar = true;

            button2.Text = "Actualizar";

            enunci = enunciado;

            this.cod_cev = cod_cev;

            txtBoxCEV.Enabled = false;

            txtBoxCEV.Text = cod_cevNombre;

            txtBoxEnunciado.Text = enunciado;

            txtBoxRespuestas.Text = respuesta;
            txtBoxRespuesta.Text = respuesta;
            txtBoxObservac.Text = observ;

            

            if (tipo == "DESARROLLO")
            {
                txtBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                rbRLarga.Checked = true;
            }
            else if (tipo == "CORTA")
            {
                txtBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                groupBox4.Visible = false;
                rbRCorta.Checked = true;
            }
            else
            {
                recorta(enunciado);
                rbTtest.Checked = true;
                txtBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox5.Visible = true;
                groupBox4.Visible = true;

                txtBO.Text = observ;



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modificar == true)
            {
                hacer_update();
            }
            else
            {
                hacer_insert();
            }
        }


        private void hacer_insert()
        {

            string tipo;

            if (rbRLarga.Checked)
            {
                tipo = "DESARROLLO";
            }
            else if (rbRCorta.Checked)
            {
                tipo = "CORTA";
            }
            else
            {
                tipo = "TEST";
            }

            string SQLInsert = "INSERT INTO PREGUNTAS(COD_CEV, TIPO, ENUNCIADO, RESPUESTA, OBSERV) VALUES(:cod_cev, :tipo, :enunciado , :respuesta , :observ)";

            OracleCommand objComando = conx.hacerConexion().CreateCommand();

            objComando.CommandText = SQLInsert;
            objComando.CommandType = System.Data.CommandType.Text;

            objComando.Parameters.Add("cod_cev", OracleType.Number).Value = cod_cev;
            objComando.Parameters.Add("tipo", OracleType.VarChar).Value = tipo;

            if (tipo == "TEST")
            {
                objComando.Parameters.Add("enunciado", OracleType.VarChar).Value = txtBenunciado.Text + "A)" + txtBpA.Text.ToLower() + " B)" + txtBpB.Text.ToLower() + " C)" + txtBpC.Text.ToLower();
                objComando.Parameters.Add("respuesta", OracleType.VarChar).Value = txtBoxRespuestas.Text.ToLower().ToString();
                objComando.Parameters.Add("observ", OracleType.VarChar).Value = txtBO.Text;
            }
            else
            {
                objComando.Parameters.Add("enunciado", OracleType.VarChar).Value = txtBoxEnunciado.Text;
                objComando.Parameters.Add("respuesta", OracleType.VarChar).Value = txtBoxRespuesta.Text;
                objComando.Parameters.Add("observ", OracleType.VarChar).Value = txtBoxObservac.Text;
            }

            

            try
            {
                objComando.ExecuteNonQuery();
                MessageBox.Show("Pregunta Insertada", "Añadido");

            }
            catch (OracleException)
            {
                MessageBox.Show("No se puede insertar! Vuelva a intentarlo.", "¡Vaya!");
                conx.objConexion.Close();
            }

            conx.objConexion.Close();

        }

        private void hacer_update()
        {

            string tipo;

            if (rbRLarga.Checked)
            {
                tipo = "DESARROLLO";
            }
            else if (rbRCorta.Checked)
            {
                tipo = "CORTA";
            }
            else
            {
                tipo = "TEST";
            }

            string SQLUpdate = "UPDATE PREGUNTAS SET TIPO = :tipo, ENUNCIADO = :enunciado1 , RESPUESTA = :respuesta , OBSERV = :observ WHERE COD_CEV = :cod_cev  AND ENUNCIADO = :enunciado2";

            OracleCommand objComando = conx.hacerConexion().CreateCommand();

            objComando.CommandText = SQLUpdate;
            objComando.CommandType = System.Data.CommandType.Text;

            objComando.Parameters.Add("cod_cev", OracleType.Number).Value = cod_cev;
            objComando.Parameters.Add("tipo", OracleType.VarChar).Value = tipo;

            if (tipo == "TEST")
            {
                objComando.Parameters.Add("enunciado1", OracleType.VarChar).Value = txtBenunciado.Text + "A)" + txtBpA.Text.ToLower() + " B)" + txtBpB.Text.ToLower() + " C)" + txtBpC.Text.ToLower();
                objComando.Parameters.Add("respuesta", OracleType.VarChar).Value = txtBoxRespuestas.Text.ToLower().ToString();
                objComando.Parameters.Add("observ", OracleType.VarChar).Value = txtBO.Text;
            }
            else
            {
                objComando.Parameters.Add("enunciado1", OracleType.VarChar).Value = txtBoxEnunciado.Text;
                objComando.Parameters.Add("respuesta", OracleType.VarChar).Value = txtBoxRespuesta.Text;
                objComando.Parameters.Add("observ", OracleType.VarChar).Value = txtBoxObservac.Text;
            }

            objComando.Parameters.Add("enunciado2", OracleType.VarChar).Value = enunci;
           

            try
            {
                objComando.ExecuteNonQuery();
                MessageBox.Show("Pregunta Actualizada", "Actualizado");

            }
            catch (OracleException)
            {
                MessageBox.Show("No se puede actualizar! Vuelva a intentarlo.", "¡Vaya!");
                conx.objConexion.Close();
            }

            conx.objConexion.Close();

        }

        private void rbTtest_CheckedChanged(object sender, EventArgs e)
        {
            txtBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
        }

        private void rbRCorta_CheckedChanged(object sender, EventArgs e)
        {
            txtBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }


        private void rbRLarga_CheckedChanged(object sender, EventArgs e)
        {
            txtBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

       

      
    }
}

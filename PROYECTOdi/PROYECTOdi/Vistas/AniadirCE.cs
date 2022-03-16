using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using PROYECTOdi.Controlador;


namespace PROYECTOdi.Vistas
{
    public partial class AniadirCE : Form
    {
        private Conexiones conx = new Conexiones();
        private Boolean modificar;
        private int cod_ra2;
        private string nombre2;
        public AniadirCE(int cod_cev,int cod_ra)
        {
            InitializeComponent();
            modificar = false;

            textBox1.Text = cod_cev.ToString();
            textBox2.Text = cod_ra.ToString();
            button1.Text = "INSERTAR";
        }

        public AniadirCE(int cod_cev, int cod_ra, string nombre, float nota)
        {
            InitializeComponent();
            modificar = true;

            button1.Text = "ACTUALIZAR";

            cod_ra2 = cod_ra;
            nombre2 = nombre;
            textBox1.Text = cod_cev.ToString();
            textBox2.Text = cod_ra.ToString();
            textBox3.Text = nombre;
            textBox4.Text = nota.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modificar == true)
            {
                modificarCEV();
            }
            else
            {
                insertarCEV();
            }
            this.Close();
        }

        private void modificarCEV()
        {
            string SQLUpdate = "UPDATE CEV SET cod_ra = :cod_ra , nombre = :nombre , nota = :nota WHERE cod_ra = :cod_ra2 AND nombre= :nombre2";

            OracleCommand objComando = conx.hacerConexion().CreateCommand();

            objComando.CommandText = SQLUpdate;
            objComando.CommandType = System.Data.CommandType.Text;

            
            objComando.Parameters.Add("cod_ra", OracleType.Number).Value = textBox2.Text;
            objComando.Parameters.Add("nombre", OracleType.VarChar).Value = textBox3.Text;
            objComando.Parameters.Add("nota", OracleType.Number).Value = textBox4.Text;
            objComando.Parameters.Add("nombre2", OracleType.VarChar).Value = nombre2;
            objComando.Parameters.Add("cod_ra2", OracleType.Number).Value = cod_ra2;
            try
            {
                objComando.ExecuteNonQuery();
                MessageBox.Show("Pregunta Modificada", "Añadido");

            }
            catch (OracleException)
            {
                MessageBox.Show("No se puede modificar! Vuelva a intentarlo.", "¡Vaya!");
                conx.objConexion.Close();
            }

            conx.objConexion.Close();

        }
        private void insertarCEV()
        {

           

            string SQLInsert = "INSERT INTO CEV( cod_ra, nombre, nota) VALUES(:cod_ra, :nombre , :nota)";

            OracleCommand objComando = conx.hacerConexion().CreateCommand();

            objComando.CommandText = SQLInsert;
            objComando.CommandType = System.Data.CommandType.Text;

            objComando.Parameters.Add("cod_ra", OracleType.Number).Value = textBox2.Text;
            objComando.Parameters.Add("nombre", OracleType.VarChar).Value = textBox3.Text;
            objComando.Parameters.Add("nota", OracleType.Number).Value = textBox4.Text;



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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

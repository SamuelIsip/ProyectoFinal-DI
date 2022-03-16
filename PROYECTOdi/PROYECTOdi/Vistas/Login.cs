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
    public partial class Login : Form
    {

        private Conexiones conx = new Conexiones();

        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            int resultado = conx.comprobarLogin(txtUsuario.Text, txtPass.Text);

            if (resultado == 1)
            {
                MENU menu = new MENU();
                this.Hide();
                menu.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario / Contraseña incorrectos!", "Login");
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string SQLInsert = "INSERT INTO PROFESORES VALUES(:usuario, :contra)";

            OracleCommand objComando = conx.hacerConexion().CreateCommand();

            objComando.CommandText = SQLInsert;
            objComando.CommandType = System.Data.CommandType.Text;

            objComando.Parameters.Add("usuario", OracleType.VarChar).Value = txtUsuario.Text;
            objComando.Parameters.Add("contra", OracleType.VarChar).Value = txtPass.Text;

            try
            {
                objComando.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado", "Registro");

            }
            catch (OracleException)
            {
                MessageBox.Show("El usuario ya existe!", "¡Vaya!");
                conx.objConexion.Close();
            }

            conx.objConexion.Close();
        }
    }
}

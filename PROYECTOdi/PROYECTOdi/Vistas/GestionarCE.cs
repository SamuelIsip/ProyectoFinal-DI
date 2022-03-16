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
    public partial class GestionarCE : Form
    {
        private Conexiones conx = new Conexiones();

        String stringConexion = "User Id=di2;Password=di2;Data Source=xe;";
        private OracleConnection objConexion = new OracleConnection();
        OracleDataReader lector;
        
        public GestionarCE()
        {
            
            InitializeComponent();
            rellenarRA(lector);
            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }
        private void rellenarDataGrid()
        {
            objConexion.ConnectionString = stringConexion;
            objConexion.Open();
            OracleDataAdapter dtas = new OracleDataAdapter("SELECT * FROM CEV", objConexion);
            DataSet ds = new DataSet();
            dtas.Fill(ds, "CEV");
            dgCEV.DataSource = ds;
            dgCEV.DataMember = "CEV";
            objConexion.Close();
        }
        public void rellenarRA(OracleDataReader lector)
        {
            lector = conx.selectRA();
            while (lector.Read())
            {
                cbRA2.Items.Add(lector["nombre"].ToString());
            }
            conx.objConexion.Close();
        }

        private void cbRA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            objConexion.ConnectionString = stringConexion;
            objConexion.Open();
            OracleDataAdapter dtas = new OracleDataAdapter("select * from cev where cod_ra=(select cod_ra from RA where nombre='" + cbRA2.Text + "')", objConexion);
            DataSet ds = new DataSet();
            dtas.Fill(ds, "CEV");
            dgCEV.DataSource = ds;
            dgCEV.DataMember = "CEV";
            objConexion.Close();
            dgCEV.Rows[0].Selected = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cod_cev = int.Parse(dgCEV.CurrentRow.Cells[0].Value.ToString());
            int cod_ra = int.Parse(dgCEV.CurrentRow.Cells[1].Value.ToString());
            Vistas.AniadirCE aniadirCE = new Vistas.AniadirCE(cod_cev,cod_ra);
            
            aniadirCE.ShowDialog();

            cbRA2_SelectedIndexChanged(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod_cev = int.Parse(dgCEV.CurrentRow.Cells[0].Value.ToString());
            int cod_ra = int.Parse(dgCEV.CurrentRow.Cells[1].Value.ToString());
            String nombre = dgCEV.CurrentRow.Cells[2].Value.ToString();
            float nota = float.Parse(dgCEV.CurrentRow.Cells[3].Value.ToString());
            Vistas.AniadirCE aniadirCE = new Vistas.AniadirCE(cod_cev,cod_ra,nombre,nota);
            aniadirCE.ShowDialog();

            cbRA2_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgCEV.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar ese registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int cod_r = int.Parse(dgCEV.CurrentRow.Cells[1].Value.ToString());
                    int cod_cev = int.Parse(dgCEV.CurrentRow.Cells[0].Value.ToString());


                    OracleCommand eliminar = new OracleCommand("delete from cev where cod_ra=" + cod_r + " and cod_cev=" + cod_cev, conx.hacerConexion());


                    try
                    {
                        eliminar.ExecuteNonQuery();

                        dgCEV.Rows.RemoveAt(dgCEV.CurrentRow.Index);
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
            }
    }
}

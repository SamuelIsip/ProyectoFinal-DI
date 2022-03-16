using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOdi.Vistas
{
    public partial class AniadirRA : Form
    {
        Controlador.Conexiones cco = new Controlador.Conexiones();
        String nomOld;
        double notOld;
        public AniadirRA()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
        }

        public AniadirRA(String nombre, double nota)
        {
            InitializeComponent();
            
            nomOld = nombre;
            tbNom.Text = nomOld;
            
            notOld = nota;
            tbNot.Text = notOld.ToString();
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String nombre = "";
            double nota = 0;
            try
            {
                nombre = tbNom.Text.ToString();
                nota = Convert.ToDouble(tbNot.Text.ToString());
                cco.anadeRA(nombre, nota);
                cco.objConexion.Close();
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ambos campos deben tener datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nombre;
            double nota;
            try
            {
                nombre = tbNom.Text.ToString();
                nota = Convert.ToDouble(tbNot.Text);
                cco.modificaRA(nombre, nomOld);
                cco.objConexion.Close();
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ambos campos deben tener datos");
            }
        }
    }
}

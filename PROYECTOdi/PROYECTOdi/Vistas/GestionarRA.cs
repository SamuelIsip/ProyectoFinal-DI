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
    public partial class GestionarRA : Form
    {
        Controlador.Conexiones ccon = new Controlador.Conexiones();
        AniadirRA anadir = new AniadirRA();
        String nombre;
        double nota;

        public GestionarRA()
        {
            InitializeComponent();
            ccon.verDatosRA(dgra);
            dgra.ReadOnly = true;

            nombre = dgra.Rows[0].Cells[0].Value.ToString();
            nota = Convert.ToDouble(dgra.Rows[0].Cells[1].Value.ToString());
        }

        private void dgra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dgra.CurrentRow.Cells[0].Value.ToString();
            nota = Convert.ToDouble(dgra.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            anadir.ShowDialog();
            ccon.verDatosRA(dgra);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AniadirRA anad = new AniadirRA(nombre, nota);
            anad.ShowDialog();
            ccon.verDatosRA(dgra);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ccon.eliminaRA(nombre, nota);
            ccon.verDatosRA(dgra);
        }
    }
}

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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestRa_Click(object sender, EventArgs e)
        {
            GestionarRA gRA = new GestionarRA();

            this.Hide();
            gRA.ShowDialog();
            this.Dispose();
        }

        private void btnGestCev_Click(object sender, EventArgs e)
        {
            GestionarCE gCE = new GestionarCE();

            this.Hide();
            gCE.ShowDialog();
            this.Dispose();
        }

        private void btnGestPr_Click(object sender, EventArgs e)
        {
            Gestionar_Preguntas gPR = new Gestionar_Preguntas();

            this.Hide();
            gPR.ShowDialog();
            this.Dispose();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            Realizar_Examen rE = new Realizar_Examen();

            this.Hide();
            rE.ShowDialog();
            this.Dispose();
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            Generar_Informes gI = new Generar_Informes();

            this.Hide();
            gI.ShowDialog();
            this.Dispose();
        }


    }

}

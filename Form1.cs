using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Nómina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informaciónDelEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form informaciónDelEmpleadoToolStripMenuItem = new frm2 ();
            informaciónDelEmpleadoToolStripMenuItem.Show();
        }

        private void registroDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registroDeEmpleadoToolStripMenuItem = new frm4();
            registroDeEmpleadoToolStripMenuItem.Show();
        }

        private void registroDeProfesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registroDeProfesiónToolStripMenuItem = new frm5();
            registroDeProfesiónToolStripMenuItem.Show();
        }


        private void calculoDePlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculoDePlanillaToolStripMenuItem = new frm7();
            calculoDePlanillaToolStripMenuItem.Show();
        }

        private void ingresoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresoDeEmpleadosToolStripMenuItem = new frm6();
            ingresoDeEmpleadosToolStripMenuItem.Show();
        }

    }
}

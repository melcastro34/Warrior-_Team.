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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void txtcedula_ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnaceptar_ingreso_cedula_Click(object sender, EventArgs e)
        {
            Form btnaceptar_ingreso_cedula = new frm3();
            btnaceptar_ingreso_cedula.Show();

        }

        private void btn_SalirConsultaPorCedula_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

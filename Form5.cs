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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

   

        private void btn_Salir_ResultadodelRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIngresoProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void txtIngresoHora_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm5_Load(object sender, EventArgs e)
        {
            btn_Guardar_DatosProfesion.Enabled = false;
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtIngresoCodigo.Text) &&
                !string.IsNullOrEmpty(txtIngresoProfesion.Text) &&
                !string.IsNullOrEmpty(txtIngresoHora.Text);
            btn_Guardar_DatosProfesion.Enabled = vr;
        }

        private void txtIngresoCodigo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtIngresoProfesion_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtIngresoHora_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btn_Limpiar_DatosProfesion_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            txtIngresoCodigo.Clear();
            txtIngresoProfesion.Clear();
            txtIngresoHora.Clear();
        }
    }
}

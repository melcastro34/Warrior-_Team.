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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_DatosEmpleado_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtMantenimientoCédula.Clear();
            txtMantenimientoNombre.Clear();
            txtMantenimientoPrimerApellido.Clear();
            txtMantenimientoSegundoApellido.Clear();
            dtp_ResultadoFechaNacimiento.ResetText();
            txtMantenimientoEdad.Clear();
            cmbMantenimientoGenero.SelectedItem = null;
            cmbMantenimientoProfesión.SelectedItem = null;
        }

        private void btn_Salir_ResultadodelRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMantenimientoCédula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantenimientoNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantenimientoPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantenimientoSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantenimientoEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm4_Load(object sender, EventArgs e)
        {
            btn_Guardar_DatosEmpleado.Enabled = false;
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtMantenimientoCédula.Text) &&
                !String.IsNullOrEmpty(txtMantenimientoNombre.Text) &&
                !String.IsNullOrEmpty(txtMantenimientoPrimerApellido.Text) &&
                !String.IsNullOrEmpty(txtMantenimientoSegundoApellido.Text) &&
                !String.IsNullOrEmpty(dtp_ResultadoFechaNacimiento.Text) &&
                !String.IsNullOrEmpty(txtMantenimientoEdad.Text) &&
                !String.IsNullOrEmpty(cmbMantenimientoGenero.Text) &&
                !String.IsNullOrEmpty(cmbMantenimientoProfesión.Text);
            btn_Guardar_DatosEmpleado.Enabled = vr;
        }

        private void txtMantenimientoCédula_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtMantenimientoNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtMantenimientoPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtMantenimientoSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void dtp_ResultadoFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtMantenimientoEdad_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmbMantenimientoGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmbMantenimientoProfesión_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btn_RegistroProfesion_Click(object sender, EventArgs e)
        {
            Form btn_RegistroProfesion = new frm5();
            btn_RegistroProfesion.Show();
        }
    }
}

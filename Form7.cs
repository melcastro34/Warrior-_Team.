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
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void btnSiguiente_CalculoPlanilla_Click(object sender, EventArgs e)
        {
            Form btnSiguiente_CalculoPlanilla = new frm8();
            btnSiguiente_CalculoPlanilla.Show();

        }

        private void btn_Salir_CalculoPlanilla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_CalculoPlanilla_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtResultadoComprobanteConsecutivo.Clear();
            dtpResultadoFechaIngresoPlanilla.ResetText();
            txtResultadoHoraIngresoPlanilla.Clear();
            cmbResultadoHorasOrdinarias.SelectedItem = null;
            cmbResultadoHorasExtras.SelectedItem = null;
            txtResultadoCostoPorHora.Clear();
        }

        private void txtResultadoComprobanteConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtResultadoCostoPorHora_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtResultadoHoraIngresoPlanilla_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm7_Load(object sender, EventArgs e)
        {
            btn_Guardar_CalculoPlanilla.Enabled = false;
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtResultadoComprobanteConsecutivo.Text) &&
                !string.IsNullOrEmpty(dtpResultadoFechaIngresoPlanilla.Text) &&
                !string.IsNullOrEmpty(txtResultadoHoraIngresoPlanilla.Text) &&
                !string.IsNullOrEmpty(cmbResultadoHorasOrdinarias.Text) &&
                !string.IsNullOrEmpty(cmbResultadoHorasExtras.Text);
            btn_Guardar_CalculoPlanilla.Enabled = vr;
        }

        private void txtResultadoComprobanteConsecutivo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void dtpResultadoFechaIngresoPlanilla_ValueChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtResultadoHoraIngresoPlanilla_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmbResultadoHorasOrdinarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmbResultadoHorasExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
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
    public partial class frm8 : Form
    {
        public frm8()
        {
            InitializeComponent();
        }

        private void btn_Siguiente_Bono_Click(object sender, EventArgs e)
        {
            Form btn_Siguiente_Bono = new frm9();
            btn_Siguiente_Bono.Show ();
        }

        private void btn_Salir_Bono_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Bono_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            dtpResultadoAñoIngreso.ResetText();
            cmbBonoOpciones.SelectedItem = null;
        }

        private void frm8_Load(object sender, EventArgs e)
        {
            btn_Guardar_Bono.Enabled = false;   
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(dtpResultadoAñoIngreso.Text) &&
                !string.IsNullOrEmpty(cmbBonoOpciones.Text);
            btn_Guardar_Bono.Enabled = vr;
        }

        private void dtpResultadoAñoIngreso_ValueChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmbBonoOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}


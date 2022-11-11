namespace Calculo_Nómina
{
    partial class frm7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCalculoPlanilla = new System.Windows.Forms.GroupBox();
            this.cmbResultadoHorasOrdinarias = new System.Windows.Forms.ComboBox();
            this.dtpResultadoFechaIngresoPlanilla = new System.Windows.Forms.DateTimePicker();
            this.cmbResultadoHorasExtras = new System.Windows.Forms.ComboBox();
            this.btn_Guardar_CalculoPlanilla = new System.Windows.Forms.Button();
            this.btn_Limpiar_CalculoPlanilla = new System.Windows.Forms.Button();
            this.btn_Salir_CalculoPlanilla = new System.Windows.Forms.Button();
            this.btn_Siguiente_CalculoPlanilla = new System.Windows.Forms.Button();
            this.txtResultadoCostoPorHora = new System.Windows.Forms.TextBox();
            this.lbl_CostoPorHora = new System.Windows.Forms.Label();
            this.lbl_HorasExtras = new System.Windows.Forms.Label();
            this.lbl_HorasOrdinarias = new System.Windows.Forms.Label();
            this.txtResultadoHoraIngresoPlanilla = new System.Windows.Forms.TextBox();
            this.lbl_HoraIngreso = new System.Windows.Forms.Label();
            this.lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.txtResultadoComprobanteConsecutivo = new System.Windows.Forms.TextBox();
            this.lbl_ComprobanteConsecutivo = new System.Windows.Forms.Label();
            this.grpCalculoPlanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCalculoPlanilla
            // 
            this.grpCalculoPlanilla.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpCalculoPlanilla.Controls.Add(this.cmbResultadoHorasOrdinarias);
            this.grpCalculoPlanilla.Controls.Add(this.dtpResultadoFechaIngresoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.cmbResultadoHorasExtras);
            this.grpCalculoPlanilla.Controls.Add(this.btn_Guardar_CalculoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.btn_Limpiar_CalculoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.btn_Salir_CalculoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.btn_Siguiente_CalculoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.txtResultadoCostoPorHora);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_CostoPorHora);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_HorasExtras);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_HorasOrdinarias);
            this.grpCalculoPlanilla.Controls.Add(this.txtResultadoHoraIngresoPlanilla);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_HoraIngreso);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_FechaIngreso);
            this.grpCalculoPlanilla.Controls.Add(this.txtResultadoComprobanteConsecutivo);
            this.grpCalculoPlanilla.Controls.Add(this.lbl_ComprobanteConsecutivo);
            this.grpCalculoPlanilla.Location = new System.Drawing.Point(47, 34);
            this.grpCalculoPlanilla.Margin = new System.Windows.Forms.Padding(4);
            this.grpCalculoPlanilla.Name = "grpCalculoPlanilla";
            this.grpCalculoPlanilla.Padding = new System.Windows.Forms.Padding(4);
            this.grpCalculoPlanilla.Size = new System.Drawing.Size(560, 446);
            this.grpCalculoPlanilla.TabIndex = 0;
            this.grpCalculoPlanilla.TabStop = false;
            this.grpCalculoPlanilla.Text = "Calculo Planilla";
            // 
            // cmbResultadoHorasOrdinarias
            // 
            this.cmbResultadoHorasOrdinarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultadoHorasOrdinarias.FormattingEnabled = true;
            this.cmbResultadoHorasOrdinarias.Items.AddRange(new object[] {
            "40 hr",
            "48 hr"});
            this.cmbResultadoHorasOrdinarias.Location = new System.Drawing.Point(337, 197);
            this.cmbResultadoHorasOrdinarias.Name = "cmbResultadoHorasOrdinarias";
            this.cmbResultadoHorasOrdinarias.Size = new System.Drawing.Size(134, 28);
            this.cmbResultadoHorasOrdinarias.TabIndex = 18;
            this.cmbResultadoHorasOrdinarias.SelectedIndexChanged += new System.EventHandler(this.cmbResultadoHorasOrdinarias_SelectedIndexChanged);
            // 
            // dtpResultadoFechaIngresoPlanilla
            // 
            this.dtpResultadoFechaIngresoPlanilla.Location = new System.Drawing.Point(337, 104);
            this.dtpResultadoFechaIngresoPlanilla.Name = "dtpResultadoFechaIngresoPlanilla";
            this.dtpResultadoFechaIngresoPlanilla.Size = new System.Drawing.Size(200, 27);
            this.dtpResultadoFechaIngresoPlanilla.TabIndex = 17;
            this.dtpResultadoFechaIngresoPlanilla.ValueChanged += new System.EventHandler(this.dtpResultadoFechaIngresoPlanilla_ValueChanged);
            // 
            // cmbResultadoHorasExtras
            // 
            this.cmbResultadoHorasExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultadoHorasExtras.FormattingEnabled = true;
            this.cmbResultadoHorasExtras.Items.AddRange(new object[] {
            "0 hr",
            "1 hr",
            "2 hr",
            "3 hr",
            "4 hr",
            "5 hr"});
            this.cmbResultadoHorasExtras.Location = new System.Drawing.Point(337, 242);
            this.cmbResultadoHorasExtras.Name = "cmbResultadoHorasExtras";
            this.cmbResultadoHorasExtras.Size = new System.Drawing.Size(134, 28);
            this.cmbResultadoHorasExtras.TabIndex = 16;
            this.cmbResultadoHorasExtras.SelectedIndexChanged += new System.EventHandler(this.cmbResultadoHorasExtras_SelectedIndexChanged);
            // 
            // btn_Guardar_CalculoPlanilla
            // 
            this.btn_Guardar_CalculoPlanilla.Location = new System.Drawing.Point(389, 342);
            this.btn_Guardar_CalculoPlanilla.Name = "btn_Guardar_CalculoPlanilla";
            this.btn_Guardar_CalculoPlanilla.Size = new System.Drawing.Size(101, 28);
            this.btn_Guardar_CalculoPlanilla.TabIndex = 15;
            this.btn_Guardar_CalculoPlanilla.Text = "Guardar";
            this.btn_Guardar_CalculoPlanilla.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar_CalculoPlanilla
            // 
            this.btn_Limpiar_CalculoPlanilla.Location = new System.Drawing.Point(272, 342);
            this.btn_Limpiar_CalculoPlanilla.Name = "btn_Limpiar_CalculoPlanilla";
            this.btn_Limpiar_CalculoPlanilla.Size = new System.Drawing.Size(101, 28);
            this.btn_Limpiar_CalculoPlanilla.TabIndex = 14;
            this.btn_Limpiar_CalculoPlanilla.Text = "Limpiar";
            this.btn_Limpiar_CalculoPlanilla.UseVisualStyleBackColor = true;
            this.btn_Limpiar_CalculoPlanilla.Click += new System.EventHandler(this.btn_Limpiar_CalculoPlanilla_Click);
            // 
            // btn_Salir_CalculoPlanilla
            // 
            this.btn_Salir_CalculoPlanilla.Location = new System.Drawing.Point(7, 411);
            this.btn_Salir_CalculoPlanilla.Name = "btn_Salir_CalculoPlanilla";
            this.btn_Salir_CalculoPlanilla.Size = new System.Drawing.Size(101, 28);
            this.btn_Salir_CalculoPlanilla.TabIndex = 13;
            this.btn_Salir_CalculoPlanilla.Text = "Salir";
            this.btn_Salir_CalculoPlanilla.UseVisualStyleBackColor = true;
            this.btn_Salir_CalculoPlanilla.Click += new System.EventHandler(this.btn_Salir_CalculoPlanilla_Click);
            // 
            // btn_Siguiente_CalculoPlanilla
            // 
            this.btn_Siguiente_CalculoPlanilla.Location = new System.Drawing.Point(367, 411);
            this.btn_Siguiente_CalculoPlanilla.Name = "btn_Siguiente_CalculoPlanilla";
            this.btn_Siguiente_CalculoPlanilla.Size = new System.Drawing.Size(170, 28);
            this.btn_Siguiente_CalculoPlanilla.TabIndex = 12;
            this.btn_Siguiente_CalculoPlanilla.Text = "Siguiente Bono";
            this.btn_Siguiente_CalculoPlanilla.UseVisualStyleBackColor = true;
            this.btn_Siguiente_CalculoPlanilla.Click += new System.EventHandler(this.btnSiguiente_CalculoPlanilla_Click);
            // 
            // txtResultadoCostoPorHora
            // 
            this.txtResultadoCostoPorHora.Enabled = false;
            this.txtResultadoCostoPorHora.Location = new System.Drawing.Point(337, 284);
            this.txtResultadoCostoPorHora.Name = "txtResultadoCostoPorHora";
            this.txtResultadoCostoPorHora.Size = new System.Drawing.Size(134, 27);
            this.txtResultadoCostoPorHora.TabIndex = 11;
            this.txtResultadoCostoPorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultadoCostoPorHora_KeyPress);
            // 
            // lbl_CostoPorHora
            // 
            this.lbl_CostoPorHora.AutoSize = true;
            this.lbl_CostoPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostoPorHora.Location = new System.Drawing.Point(41, 284);
            this.lbl_CostoPorHora.Name = "lbl_CostoPorHora";
            this.lbl_CostoPorHora.Size = new System.Drawing.Size(279, 20);
            this.lbl_CostoPorHora.TabIndex = 10;
            this.lbl_CostoPorHora.Text = "Costo de la hora según la profesión:";
            // 
            // lbl_HorasExtras
            // 
            this.lbl_HorasExtras.AutoSize = true;
            this.lbl_HorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HorasExtras.Location = new System.Drawing.Point(209, 242);
            this.lbl_HorasExtras.Name = "lbl_HorasExtras";
            this.lbl_HorasExtras.Size = new System.Drawing.Size(111, 20);
            this.lbl_HorasExtras.TabIndex = 8;
            this.lbl_HorasExtras.Text = "Horas extras:";
            // 
            // lbl_HorasOrdinarias
            // 
            this.lbl_HorasOrdinarias.AutoSize = true;
            this.lbl_HorasOrdinarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HorasOrdinarias.Location = new System.Drawing.Point(181, 197);
            this.lbl_HorasOrdinarias.Name = "lbl_HorasOrdinarias";
            this.lbl_HorasOrdinarias.Size = new System.Drawing.Size(139, 20);
            this.lbl_HorasOrdinarias.TabIndex = 6;
            this.lbl_HorasOrdinarias.Text = "Horas ordinarias:";
            // 
            // txtResultadoHoraIngresoPlanilla
            // 
            this.txtResultadoHoraIngresoPlanilla.Location = new System.Drawing.Point(337, 152);
            this.txtResultadoHoraIngresoPlanilla.Name = "txtResultadoHoraIngresoPlanilla";
            this.txtResultadoHoraIngresoPlanilla.Size = new System.Drawing.Size(134, 27);
            this.txtResultadoHoraIngresoPlanilla.TabIndex = 5;
            this.txtResultadoHoraIngresoPlanilla.TextChanged += new System.EventHandler(this.txtResultadoHoraIngresoPlanilla_TextChanged);
            this.txtResultadoHoraIngresoPlanilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultadoHoraIngresoPlanilla_KeyPress);
            // 
            // lbl_HoraIngreso
            // 
            this.lbl_HoraIngreso.AutoSize = true;
            this.lbl_HoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraIngreso.Location = new System.Drawing.Point(115, 152);
            this.lbl_HoraIngreso.Name = "lbl_HoraIngreso";
            this.lbl_HoraIngreso.Size = new System.Drawing.Size(205, 20);
            this.lbl_HoraIngreso.TabIndex = 4;
            this.lbl_HoraIngreso.Text = "Hora de ingreso a planilla:";
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(101, 104);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(219, 20);
            this.lbl_FechaIngreso.TabIndex = 2;
            this.lbl_FechaIngreso.Text = " Fecha de ingreso a planilla:";
            // 
            // txtResultadoComprobanteConsecutivo
            // 
            this.txtResultadoComprobanteConsecutivo.Location = new System.Drawing.Point(337, 54);
            this.txtResultadoComprobanteConsecutivo.Name = "txtResultadoComprobanteConsecutivo";
            this.txtResultadoComprobanteConsecutivo.Size = new System.Drawing.Size(134, 27);
            this.txtResultadoComprobanteConsecutivo.TabIndex = 1;
            this.txtResultadoComprobanteConsecutivo.TextChanged += new System.EventHandler(this.txtResultadoComprobanteConsecutivo_TextChanged);
            this.txtResultadoComprobanteConsecutivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultadoComprobanteConsecutivo_KeyPress);
            // 
            // lbl_ComprobanteConsecutivo
            // 
            this.lbl_ComprobanteConsecutivo.AutoSize = true;
            this.lbl_ComprobanteConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComprobanteConsecutivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ComprobanteConsecutivo.Location = new System.Drawing.Point(28, 57);
            this.lbl_ComprobanteConsecutivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ComprobanteConsecutivo.Name = "lbl_ComprobanteConsecutivo";
            this.lbl_ComprobanteConsecutivo.Size = new System.Drawing.Size(292, 20);
            this.lbl_ComprobanteConsecutivo.TabIndex = 0;
            this.lbl_ComprobanteConsecutivo.Text = "Número de comprobante consecutivo:";
            // 
            // frm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 507);
            this.ControlBox = false;
            this.Controls.Add(this.grpCalculoPlanilla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Planilla";
            this.Load += new System.EventHandler(this.frm7_Load);
            this.grpCalculoPlanilla.ResumeLayout(false);
            this.grpCalculoPlanilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCalculoPlanilla;
        private System.Windows.Forms.Label lbl_ComprobanteConsecutivo;
        private System.Windows.Forms.Label lbl_FechaIngreso;
        private System.Windows.Forms.TextBox txtResultadoComprobanteConsecutivo;
        private System.Windows.Forms.TextBox txtResultadoHoraIngresoPlanilla;
        private System.Windows.Forms.Label lbl_HoraIngreso;
        private System.Windows.Forms.TextBox txtResultadoCostoPorHora;
        private System.Windows.Forms.Label lbl_CostoPorHora;
        private System.Windows.Forms.Label lbl_HorasExtras;
        private System.Windows.Forms.Label lbl_HorasOrdinarias;
        private System.Windows.Forms.Button btn_Siguiente_CalculoPlanilla;
        private System.Windows.Forms.Button btn_Limpiar_CalculoPlanilla;
        private System.Windows.Forms.Button btn_Salir_CalculoPlanilla;
        private System.Windows.Forms.Button btn_Guardar_CalculoPlanilla;
        private System.Windows.Forms.ComboBox cmbResultadoHorasExtras;
        private System.Windows.Forms.DateTimePicker dtpResultadoFechaIngresoPlanilla;
        private System.Windows.Forms.ComboBox cmbResultadoHorasOrdinarias;
    }
}
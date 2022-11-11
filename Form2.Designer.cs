namespace Calculo_Nómina
{
    partial class frm2
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
            this.lblcedula_ingreso = new System.Windows.Forms.Label();
            this.txtcedula_ingreso = new System.Windows.Forms.TextBox();
            this.btnaceptar_ingreso_cedula = new System.Windows.Forms.Button();
            this.grpInformacioEmpleadoCedula = new System.Windows.Forms.GroupBox();
            this.btn_SalirConsultaPorCedula = new System.Windows.Forms.Button();
            this.grpInformacioEmpleadoCedula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcedula_ingreso
            // 
            this.lblcedula_ingreso.AutoSize = true;
            this.lblcedula_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcedula_ingreso.Location = new System.Drawing.Point(117, 46);
            this.lblcedula_ingreso.Name = "lblcedula_ingreso";
            this.lblcedula_ingreso.Size = new System.Drawing.Size(201, 29);
            this.lblcedula_ingreso.TabIndex = 0;
            this.lblcedula_ingreso.Text = "Digita tu cédula:";
            // 
            // txtcedula_ingreso
            // 
            this.txtcedula_ingreso.Location = new System.Drawing.Point(122, 93);
            this.txtcedula_ingreso.Name = "txtcedula_ingreso";
            this.txtcedula_ingreso.Size = new System.Drawing.Size(196, 27);
            this.txtcedula_ingreso.TabIndex = 1;
            this.txtcedula_ingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_ingreso_KeyPress);
            // 
            // btnaceptar_ingreso_cedula
            // 
            this.btnaceptar_ingreso_cedula.BackColor = System.Drawing.Color.Green;
            this.btnaceptar_ingreso_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar_ingreso_cedula.Location = new System.Drawing.Point(169, 137);
            this.btnaceptar_ingreso_cedula.Name = "btnaceptar_ingreso_cedula";
            this.btnaceptar_ingreso_cedula.Size = new System.Drawing.Size(102, 29);
            this.btnaceptar_ingreso_cedula.TabIndex = 2;
            this.btnaceptar_ingreso_cedula.Text = "Aceptar";
            this.btnaceptar_ingreso_cedula.UseVisualStyleBackColor = false;
            this.btnaceptar_ingreso_cedula.Click += new System.EventHandler(this.btnaceptar_ingreso_cedula_Click);
            // 
            // grpInformacioEmpleadoCedula
            // 
            this.grpInformacioEmpleadoCedula.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpInformacioEmpleadoCedula.Controls.Add(this.btn_SalirConsultaPorCedula);
            this.grpInformacioEmpleadoCedula.Controls.Add(this.lblcedula_ingreso);
            this.grpInformacioEmpleadoCedula.Controls.Add(this.btnaceptar_ingreso_cedula);
            this.grpInformacioEmpleadoCedula.Controls.Add(this.txtcedula_ingreso);
            this.grpInformacioEmpleadoCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacioEmpleadoCedula.Location = new System.Drawing.Point(12, 12);
            this.grpInformacioEmpleadoCedula.Name = "grpInformacioEmpleadoCedula";
            this.grpInformacioEmpleadoCedula.Size = new System.Drawing.Size(432, 236);
            this.grpInformacioEmpleadoCedula.TabIndex = 3;
            this.grpInformacioEmpleadoCedula.TabStop = false;
            this.grpInformacioEmpleadoCedula.Text = "Ingreso por Cedúla";
            // 
            // btn_SalirConsultaPorCedula
            // 
            this.btn_SalirConsultaPorCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirConsultaPorCedula.Location = new System.Drawing.Point(6, 203);
            this.btn_SalirConsultaPorCedula.Name = "btn_SalirConsultaPorCedula";
            this.btn_SalirConsultaPorCedula.Size = new System.Drawing.Size(102, 27);
            this.btn_SalirConsultaPorCedula.TabIndex = 3;
            this.btn_SalirConsultaPorCedula.Text = "Salir";
            this.btn_SalirConsultaPorCedula.UseVisualStyleBackColor = true;
            this.btn_SalirConsultaPorCedula.Click += new System.EventHandler(this.btn_SalirConsultaPorCedula_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(456, 260);
            this.ControlBox = false;
            this.Controls.Add(this.grpInformacioEmpleadoCedula);
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del empleado";
            this.grpInformacioEmpleadoCedula.ResumeLayout(false);
            this.grpInformacioEmpleadoCedula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcedula_ingreso;
        private System.Windows.Forms.TextBox txtcedula_ingreso;
        private System.Windows.Forms.Button btnaceptar_ingreso_cedula;
        private System.Windows.Forms.GroupBox grpInformacioEmpleadoCedula;
        private System.Windows.Forms.Button btn_SalirConsultaPorCedula;
    }
}
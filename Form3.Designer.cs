namespace Calculo_Nómina
{
    partial class frm3
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
            this.lbl_RegistroNombre = new System.Windows.Forms.Label();
            this.lbl_RegistroEdad = new System.Windows.Forms.Label();
            this.lbl_RegistroProfesión = new System.Windows.Forms.Label();
            this.lbl_RegistroGenero = new System.Windows.Forms.Label();
            this.txtRegistroNombre = new System.Windows.Forms.TextBox();
            this.txtRegistroEdad = new System.Windows.Forms.TextBox();
            this.txtRegistroProfesion = new System.Windows.Forms.TextBox();
            this.txtRegistroGenero = new System.Windows.Forms.TextBox();
            this.grpInformación_Empleado = new System.Windows.Forms.GroupBox();
            this.btn_Salir_InformacioEmpleado = new System.Windows.Forms.Button();
            this.grpInformación_Empleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RegistroNombre
            // 
            this.lbl_RegistroNombre.AutoSize = true;
            this.lbl_RegistroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroNombre.Location = new System.Drawing.Point(123, 45);
            this.lbl_RegistroNombre.Name = "lbl_RegistroNombre";
            this.lbl_RegistroNombre.Size = new System.Drawing.Size(78, 20);
            this.lbl_RegistroNombre.TabIndex = 0;
            this.lbl_RegistroNombre.Text = "Nombre: ";
            // 
            // lbl_RegistroEdad
            // 
            this.lbl_RegistroEdad.AutoSize = true;
            this.lbl_RegistroEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroEdad.Location = new System.Drawing.Point(140, 87);
            this.lbl_RegistroEdad.Name = "lbl_RegistroEdad";
            this.lbl_RegistroEdad.Size = new System.Drawing.Size(52, 20);
            this.lbl_RegistroEdad.TabIndex = 1;
            this.lbl_RegistroEdad.Text = "Edad:";
            // 
            // lbl_RegistroProfesión
            // 
            this.lbl_RegistroProfesión.AutoSize = true;
            this.lbl_RegistroProfesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroProfesión.Location = new System.Drawing.Point(107, 137);
            this.lbl_RegistroProfesión.Name = "lbl_RegistroProfesión";
            this.lbl_RegistroProfesión.Size = new System.Drawing.Size(85, 20);
            this.lbl_RegistroProfesión.TabIndex = 2;
            this.lbl_RegistroProfesión.Text = "Profesión:";
            // 
            // lbl_RegistroGenero
            // 
            this.lbl_RegistroGenero.AutoSize = true;
            this.lbl_RegistroGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroGenero.Location = new System.Drawing.Point(123, 188);
            this.lbl_RegistroGenero.Name = "lbl_RegistroGenero";
            this.lbl_RegistroGenero.Size = new System.Drawing.Size(69, 20);
            this.lbl_RegistroGenero.TabIndex = 3;
            this.lbl_RegistroGenero.Text = "Genero:";
            // 
            // txtRegistroNombre
            // 
            this.txtRegistroNombre.Enabled = false;
            this.txtRegistroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroNombre.Location = new System.Drawing.Point(226, 38);
            this.txtRegistroNombre.Name = "txtRegistroNombre";
            this.txtRegistroNombre.Size = new System.Drawing.Size(136, 27);
            this.txtRegistroNombre.TabIndex = 12;
            // 
            // txtRegistroEdad
            // 
            this.txtRegistroEdad.Enabled = false;
            this.txtRegistroEdad.Location = new System.Drawing.Point(226, 87);
            this.txtRegistroEdad.Name = "txtRegistroEdad";
            this.txtRegistroEdad.Size = new System.Drawing.Size(136, 27);
            this.txtRegistroEdad.TabIndex = 13;
            // 
            // txtRegistroProfesion
            // 
            this.txtRegistroProfesion.Enabled = false;
            this.txtRegistroProfesion.Location = new System.Drawing.Point(226, 137);
            this.txtRegistroProfesion.Name = "txtRegistroProfesion";
            this.txtRegistroProfesion.Size = new System.Drawing.Size(136, 27);
            this.txtRegistroProfesion.TabIndex = 14;
            // 
            // txtRegistroGenero
            // 
            this.txtRegistroGenero.Enabled = false;
            this.txtRegistroGenero.Location = new System.Drawing.Point(226, 188);
            this.txtRegistroGenero.Name = "txtRegistroGenero";
            this.txtRegistroGenero.Size = new System.Drawing.Size(136, 27);
            this.txtRegistroGenero.TabIndex = 15;
            // 
            // grpInformación_Empleado
            // 
            this.grpInformación_Empleado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpInformación_Empleado.Controls.Add(this.btn_Salir_InformacioEmpleado);
            this.grpInformación_Empleado.Controls.Add(this.txtRegistroNombre);
            this.grpInformación_Empleado.Controls.Add(this.txtRegistroGenero);
            this.grpInformación_Empleado.Controls.Add(this.txtRegistroEdad);
            this.grpInformación_Empleado.Controls.Add(this.txtRegistroProfesion);
            this.grpInformación_Empleado.Controls.Add(this.lbl_RegistroNombre);
            this.grpInformación_Empleado.Controls.Add(this.lbl_RegistroGenero);
            this.grpInformación_Empleado.Controls.Add(this.lbl_RegistroEdad);
            this.grpInformación_Empleado.Controls.Add(this.lbl_RegistroProfesión);
            this.grpInformación_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformación_Empleado.Location = new System.Drawing.Point(12, 12);
            this.grpInformación_Empleado.Name = "grpInformación_Empleado";
            this.grpInformación_Empleado.Size = new System.Drawing.Size(457, 278);
            this.grpInformación_Empleado.TabIndex = 16;
            this.grpInformación_Empleado.TabStop = false;
            this.grpInformación_Empleado.Text = "Información del Empleado";
            // 
            // btn_Salir_InformacioEmpleado
            // 
            this.btn_Salir_InformacioEmpleado.Location = new System.Drawing.Point(6, 244);
            this.btn_Salir_InformacioEmpleado.Name = "btn_Salir_InformacioEmpleado";
            this.btn_Salir_InformacioEmpleado.Size = new System.Drawing.Size(101, 28);
            this.btn_Salir_InformacioEmpleado.TabIndex = 16;
            this.btn_Salir_InformacioEmpleado.Text = "Salir";
            this.btn_Salir_InformacioEmpleado.UseVisualStyleBackColor = true;
            this.btn_Salir_InformacioEmpleado.Click += new System.EventHandler(this.btn_Salir_InformacioEmpleado_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(481, 304);
            this.ControlBox = false;
            this.Controls.Add(this.grpInformación_Empleado);
            this.Name = "frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Empleado";
            this.grpInformación_Empleado.ResumeLayout(false);
            this.grpInformación_Empleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistroNombre;
        private System.Windows.Forms.Label lbl_RegistroEdad;
        private System.Windows.Forms.Label lbl_RegistroProfesión;
        private System.Windows.Forms.Label lbl_RegistroGenero;
        private System.Windows.Forms.TextBox txtRegistroNombre;
        private System.Windows.Forms.TextBox txtRegistroEdad;
        private System.Windows.Forms.TextBox txtRegistroProfesion;
        private System.Windows.Forms.TextBox txtRegistroGenero;
        private System.Windows.Forms.GroupBox grpInformación_Empleado;
        private System.Windows.Forms.Button btn_Salir_InformacioEmpleado;
    }
}
namespace Calculo_Nómina
{
    partial class frm8
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
            this.grpBono = new System.Windows.Forms.GroupBox();
            this.dtpResultadoAñoIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbBonoOpciones = new System.Windows.Forms.ComboBox();
            this.btn_Salir_Bono = new System.Windows.Forms.Button();
            this.btn_Finalizar_Bono = new System.Windows.Forms.Button();
            this.btn_Guardar_Bono = new System.Windows.Forms.Button();
            this.btn_Limpiar_Bono = new System.Windows.Forms.Button();
            this.lbl_OpcionBono = new System.Windows.Forms.Label();
            this.lbl_AñoDeIngreso = new System.Windows.Forms.Label();
            this.grpBono.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBono
            // 
            this.grpBono.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpBono.Controls.Add(this.dtpResultadoAñoIngreso);
            this.grpBono.Controls.Add(this.cmbBonoOpciones);
            this.grpBono.Controls.Add(this.btn_Salir_Bono);
            this.grpBono.Controls.Add(this.btn_Finalizar_Bono);
            this.grpBono.Controls.Add(this.btn_Guardar_Bono);
            this.grpBono.Controls.Add(this.btn_Limpiar_Bono);
            this.grpBono.Controls.Add(this.lbl_OpcionBono);
            this.grpBono.Controls.Add(this.lbl_AñoDeIngreso);
            this.grpBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBono.Location = new System.Drawing.Point(12, 12);
            this.grpBono.Name = "grpBono";
            this.grpBono.Size = new System.Drawing.Size(657, 209);
            this.grpBono.TabIndex = 2;
            this.grpBono.TabStop = false;
            this.grpBono.Text = "Bono";
            // 
            // dtpResultadoAñoIngreso
            // 
            this.dtpResultadoAñoIngreso.Location = new System.Drawing.Point(335, 42);
            this.dtpResultadoAñoIngreso.Name = "dtpResultadoAñoIngreso";
            this.dtpResultadoAñoIngreso.Size = new System.Drawing.Size(200, 27);
            this.dtpResultadoAñoIngreso.TabIndex = 19;
            this.dtpResultadoAñoIngreso.ValueChanged += new System.EventHandler(this.dtpResultadoAñoIngreso_ValueChanged);
            // 
            // cmbBonoOpciones
            // 
            this.cmbBonoOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBonoOpciones.FormattingEnabled = true;
            this.cmbBonoOpciones.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbBonoOpciones.Location = new System.Drawing.Point(335, 90);
            this.cmbBonoOpciones.Name = "cmbBonoOpciones";
            this.cmbBonoOpciones.Size = new System.Drawing.Size(134, 28);
            this.cmbBonoOpciones.TabIndex = 18;
            this.cmbBonoOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbBonoOpciones_SelectedIndexChanged);
            // 
            // btn_Salir_Bono
            // 
            this.btn_Salir_Bono.Location = new System.Drawing.Point(6, 175);
            this.btn_Salir_Bono.Name = "btn_Salir_Bono";
            this.btn_Salir_Bono.Size = new System.Drawing.Size(101, 28);
            this.btn_Salir_Bono.TabIndex = 16;
            this.btn_Salir_Bono.Text = "Salir";
            this.btn_Salir_Bono.UseVisualStyleBackColor = true;
            this.btn_Salir_Bono.Click += new System.EventHandler(this.btn_Salir_Bono_Click);
            // 
            // btn_Finalizar_Bono
            // 
            this.btn_Finalizar_Bono.Location = new System.Drawing.Point(524, 175);
            this.btn_Finalizar_Bono.Name = "btn_Finalizar_Bono";
            this.btn_Finalizar_Bono.Size = new System.Drawing.Size(114, 28);
            this.btn_Finalizar_Bono.TabIndex = 17;
            this.btn_Finalizar_Bono.Text = "Finalizar";
            this.btn_Finalizar_Bono.UseVisualStyleBackColor = true;
            this.btn_Finalizar_Bono.Click += new System.EventHandler(this.btn_Siguiente_Bono_Click);
            // 
            // btn_Guardar_Bono
            // 
            this.btn_Guardar_Bono.Location = new System.Drawing.Point(204, 138);
            this.btn_Guardar_Bono.Name = "btn_Guardar_Bono";
            this.btn_Guardar_Bono.Size = new System.Drawing.Size(101, 28);
            this.btn_Guardar_Bono.TabIndex = 16;
            this.btn_Guardar_Bono.Text = "Guardar";
            this.btn_Guardar_Bono.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar_Bono
            // 
            this.btn_Limpiar_Bono.Location = new System.Drawing.Point(335, 138);
            this.btn_Limpiar_Bono.Name = "btn_Limpiar_Bono";
            this.btn_Limpiar_Bono.Size = new System.Drawing.Size(101, 28);
            this.btn_Limpiar_Bono.TabIndex = 15;
            this.btn_Limpiar_Bono.Text = "Limpiar";
            this.btn_Limpiar_Bono.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Bono.Click += new System.EventHandler(this.btn_Limpiar_Bono_Click);
            // 
            // lbl_OpcionBono
            // 
            this.lbl_OpcionBono.AutoSize = true;
            this.lbl_OpcionBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpcionBono.Location = new System.Drawing.Point(183, 90);
            this.lbl_OpcionBono.Name = "lbl_OpcionBono";
            this.lbl_OpcionBono.Size = new System.Drawing.Size(122, 20);
            this.lbl_OpcionBono.TabIndex = 2;
            this.lbl_OpcionBono.Text = "Desea el bono:";
            // 
            // lbl_AñoDeIngreso
            // 
            this.lbl_AñoDeIngreso.AutoSize = true;
            this.lbl_AñoDeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AñoDeIngreso.Location = new System.Drawing.Point(60, 42);
            this.lbl_AñoDeIngreso.Name = "lbl_AñoDeIngreso";
            this.lbl_AñoDeIngreso.Size = new System.Drawing.Size(245, 20);
            this.lbl_AñoDeIngreso.TabIndex = 0;
            this.lbl_AñoDeIngreso.Text = "Fecha de ingreso a la empresa:";
            // 
            // frm8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(699, 242);
            this.ControlBox = false;
            this.Controls.Add(this.grpBono);
            this.Name = "frm8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opción de Bono";
            this.Load += new System.EventHandler(this.frm8_Load);
            this.grpBono.ResumeLayout(false);
            this.grpBono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBono;
        private System.Windows.Forms.Label lbl_OpcionBono;
        private System.Windows.Forms.Label lbl_AñoDeIngreso;
        private System.Windows.Forms.Button btn_Limpiar_Bono;
        private System.Windows.Forms.Button btn_Guardar_Bono;
        private System.Windows.Forms.Button btn_Salir_Bono;
        private System.Windows.Forms.Button btn_Finalizar_Bono;
        private System.Windows.Forms.ComboBox cmbBonoOpciones;
        private System.Windows.Forms.DateTimePicker dtpResultadoAñoIngreso;
    }
}
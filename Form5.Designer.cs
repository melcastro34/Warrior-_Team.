namespace Calculo_Nómina
{
    partial class frm5
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
            this.lbl_IngresoCodigo = new System.Windows.Forms.Label();
            this.txtIngresoHora = new System.Windows.Forms.TextBox();
            this.lbl_IngresoProfesion = new System.Windows.Forms.Label();
            this.txtIngresoProfesion = new System.Windows.Forms.TextBox();
            this.lbl_IngresoHora = new System.Windows.Forms.Label();
            this.txtIngresoCodigo = new System.Windows.Forms.TextBox();
            this.txtResultadoProfesión = new System.Windows.Forms.TextBox();
            this.lbl_ResultadoCodigo = new System.Windows.Forms.Label();
            this.lbl_ResultadoProfesion = new System.Windows.Forms.Label();
            this.txtResultadoHora = new System.Windows.Forms.TextBox();
            this.lbl_ResultadoHora = new System.Windows.Forms.Label();
            this.txtResultadoCodigo = new System.Windows.Forms.TextBox();
            this.grpIngresoProfesión = new System.Windows.Forms.GroupBox();
            this.btn_Guardar_DatosProfesion = new System.Windows.Forms.Button();
            this.btn_Limpiar_DatosProfesion = new System.Windows.Forms.Button();
            this.grpResultadoProfesion = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btn_Salir_ResultadodelRegistro = new System.Windows.Forms.Button();
            this.grpIngresoProfesión.SuspendLayout();
            this.grpResultadoProfesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IngresoCodigo
            // 
            this.lbl_IngresoCodigo.AutoSize = true;
            this.lbl_IngresoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngresoCodigo.Location = new System.Drawing.Point(237, 25);
            this.lbl_IngresoCodigo.Name = "lbl_IngresoCodigo";
            this.lbl_IngresoCodigo.Size = new System.Drawing.Size(146, 20);
            this.lbl_IngresoCodigo.TabIndex = 0;
            this.lbl_IngresoCodigo.Text = "Ingrese su codigo:";
            // 
            // txtIngresoHora
            // 
            this.txtIngresoHora.Location = new System.Drawing.Point(432, 128);
            this.txtIngresoHora.Name = "txtIngresoHora";
            this.txtIngresoHora.Size = new System.Drawing.Size(170, 27);
            this.txtIngresoHora.TabIndex = 1;
            this.txtIngresoHora.TextChanged += new System.EventHandler(this.txtIngresoHora_TextChanged);
            this.txtIngresoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresoHora_KeyPress);
            // 
            // lbl_IngresoProfesion
            // 
            this.lbl_IngresoProfesion.AutoSize = true;
            this.lbl_IngresoProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngresoProfesion.Location = new System.Drawing.Point(120, 77);
            this.lbl_IngresoProfesion.Name = "lbl_IngresoProfesion";
            this.lbl_IngresoProfesion.Size = new System.Drawing.Size(263, 20);
            this.lbl_IngresoProfesion.TabIndex = 2;
            this.lbl_IngresoProfesion.Text = "Ingrese el nombre de la profesión:";
            // 
            // txtIngresoProfesion
            // 
            this.txtIngresoProfesion.Location = new System.Drawing.Point(432, 77);
            this.txtIngresoProfesion.Name = "txtIngresoProfesion";
            this.txtIngresoProfesion.Size = new System.Drawing.Size(170, 27);
            this.txtIngresoProfesion.TabIndex = 3;
            this.txtIngresoProfesion.TextChanged += new System.EventHandler(this.txtIngresoProfesion_TextChanged);
            this.txtIngresoProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresoProfesion_KeyPress);
            // 
            // lbl_IngresoHora
            // 
            this.lbl_IngresoHora.AutoSize = true;
            this.lbl_IngresoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngresoHora.Location = new System.Drawing.Point(183, 128);
            this.lbl_IngresoHora.Name = "lbl_IngresoHora";
            this.lbl_IngresoHora.Size = new System.Drawing.Size(200, 20);
            this.lbl_IngresoHora.TabIndex = 4;
            this.lbl_IngresoHora.Text = "Ingrese el costo por hora:";
            // 
            // txtIngresoCodigo
            // 
            this.txtIngresoCodigo.Location = new System.Drawing.Point(432, 25);
            this.txtIngresoCodigo.Name = "txtIngresoCodigo";
            this.txtIngresoCodigo.Size = new System.Drawing.Size(170, 27);
            this.txtIngresoCodigo.TabIndex = 5;
            this.txtIngresoCodigo.TextChanged += new System.EventHandler(this.txtIngresoCodigo_TextChanged);
            // 
            // txtResultadoProfesión
            // 
            this.txtResultadoProfesión.Enabled = false;
            this.txtResultadoProfesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoProfesión.Location = new System.Drawing.Point(611, 45);
            this.txtResultadoProfesión.Name = "txtResultadoProfesión";
            this.txtResultadoProfesión.Size = new System.Drawing.Size(136, 27);
            this.txtResultadoProfesión.TabIndex = 6;
            // 
            // lbl_ResultadoCodigo
            // 
            this.lbl_ResultadoCodigo.AutoSize = true;
            this.lbl_ResultadoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultadoCodigo.Location = new System.Drawing.Point(35, 52);
            this.lbl_ResultadoCodigo.Name = "lbl_ResultadoCodigo";
            this.lbl_ResultadoCodigo.Size = new System.Drawing.Size(208, 20);
            this.lbl_ResultadoCodigo.TabIndex = 7;
            this.lbl_ResultadoCodigo.Text = "Su codigo de profesion es:";
            // 
            // lbl_ResultadoProfesion
            // 
            this.lbl_ResultadoProfesion.AutoSize = true;
            this.lbl_ResultadoProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultadoProfesion.Location = new System.Drawing.Point(428, 52);
            this.lbl_ResultadoProfesion.Name = "lbl_ResultadoProfesion";
            this.lbl_ResultadoProfesion.Size = new System.Drawing.Size(177, 20);
            this.lbl_ResultadoProfesion.TabIndex = 8;
            this.lbl_ResultadoProfesion.Text = "Ejerce la profesión de:";
            // 
            // txtResultadoHora
            // 
            this.txtResultadoHora.Enabled = false;
            this.txtResultadoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoHora.Location = new System.Drawing.Point(271, 93);
            this.txtResultadoHora.Name = "txtResultadoHora";
            this.txtResultadoHora.Size = new System.Drawing.Size(136, 27);
            this.txtResultadoHora.TabIndex = 9;
            // 
            // lbl_ResultadoHora
            // 
            this.lbl_ResultadoHora.AutoSize = true;
            this.lbl_ResultadoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultadoHora.Location = new System.Drawing.Point(36, 93);
            this.lbl_ResultadoHora.Name = "lbl_ResultadoHora";
            this.lbl_ResultadoHora.Size = new System.Drawing.Size(207, 20);
            this.lbl_ResultadoHora.TabIndex = 10;
            this.lbl_ResultadoHora.Text = "Su ingreso por hora es de:";
            // 
            // txtResultadoCodigo
            // 
            this.txtResultadoCodigo.Enabled = false;
            this.txtResultadoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoCodigo.Location = new System.Drawing.Point(271, 45);
            this.txtResultadoCodigo.Name = "txtResultadoCodigo";
            this.txtResultadoCodigo.Size = new System.Drawing.Size(136, 27);
            this.txtResultadoCodigo.TabIndex = 11;
            // 
            // grpIngresoProfesión
            // 
            this.grpIngresoProfesión.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpIngresoProfesión.Controls.Add(this.btn_Guardar_DatosProfesion);
            this.grpIngresoProfesión.Controls.Add(this.btn_Limpiar_DatosProfesion);
            this.grpIngresoProfesión.Controls.Add(this.lbl_IngresoCodigo);
            this.grpIngresoProfesión.Controls.Add(this.lbl_IngresoHora);
            this.grpIngresoProfesión.Controls.Add(this.lbl_IngresoProfesion);
            this.grpIngresoProfesión.Controls.Add(this.txtIngresoCodigo);
            this.grpIngresoProfesión.Controls.Add(this.txtIngresoProfesion);
            this.grpIngresoProfesión.Controls.Add(this.txtIngresoHora);
            this.grpIngresoProfesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngresoProfesión.Location = new System.Drawing.Point(12, 12);
            this.grpIngresoProfesión.Name = "grpIngresoProfesión";
            this.grpIngresoProfesión.Size = new System.Drawing.Size(776, 222);
            this.grpIngresoProfesión.TabIndex = 12;
            this.grpIngresoProfesión.TabStop = false;
            this.grpIngresoProfesión.Text = "Datos profesión";
            // 
            // btn_Guardar_DatosProfesion
            // 
            this.btn_Guardar_DatosProfesion.Location = new System.Drawing.Point(292, 171);
            this.btn_Guardar_DatosProfesion.Name = "btn_Guardar_DatosProfesion";
            this.btn_Guardar_DatosProfesion.Size = new System.Drawing.Size(101, 28);
            this.btn_Guardar_DatosProfesion.TabIndex = 17;
            this.btn_Guardar_DatosProfesion.Text = "Guardar";
            this.btn_Guardar_DatosProfesion.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar_DatosProfesion
            // 
            this.btn_Limpiar_DatosProfesion.Location = new System.Drawing.Point(408, 171);
            this.btn_Limpiar_DatosProfesion.Name = "btn_Limpiar_DatosProfesion";
            this.btn_Limpiar_DatosProfesion.Size = new System.Drawing.Size(101, 28);
            this.btn_Limpiar_DatosProfesion.TabIndex = 16;
            this.btn_Limpiar_DatosProfesion.Text = "Limpiar";
            this.btn_Limpiar_DatosProfesion.UseVisualStyleBackColor = true;
            this.btn_Limpiar_DatosProfesion.Click += new System.EventHandler(this.btn_Limpiar_DatosProfesion_Click_1);
            // 
            // grpResultadoProfesion
            // 
            this.grpResultadoProfesion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpResultadoProfesion.Controls.Add(this.btnModificar);
            this.grpResultadoProfesion.Controls.Add(this.btn_Salir_ResultadodelRegistro);
            this.grpResultadoProfesion.Controls.Add(this.lbl_ResultadoCodigo);
            this.grpResultadoProfesion.Controls.Add(this.txtResultadoCodigo);
            this.grpResultadoProfesion.Controls.Add(this.lbl_ResultadoHora);
            this.grpResultadoProfesion.Controls.Add(this.lbl_ResultadoProfesion);
            this.grpResultadoProfesion.Controls.Add(this.txtResultadoHora);
            this.grpResultadoProfesion.Controls.Add(this.txtResultadoProfesión);
            this.grpResultadoProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultadoProfesion.Location = new System.Drawing.Point(12, 257);
            this.grpResultadoProfesion.Name = "grpResultadoProfesion";
            this.grpResultadoProfesion.Size = new System.Drawing.Size(776, 181);
            this.grpResultadoProfesion.TabIndex = 13;
            this.grpResultadoProfesion.TabStop = false;
            this.grpResultadoProfesion.Text = "Resultado del registro";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(611, 147);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 28);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir_ResultadodelRegistro
            // 
            this.btn_Salir_ResultadodelRegistro.Location = new System.Drawing.Point(6, 147);
            this.btn_Salir_ResultadodelRegistro.Name = "btn_Salir_ResultadodelRegistro";
            this.btn_Salir_ResultadodelRegistro.Size = new System.Drawing.Size(101, 28);
            this.btn_Salir_ResultadodelRegistro.TabIndex = 15;
            this.btn_Salir_ResultadodelRegistro.Text = "Salir";
            this.btn_Salir_ResultadodelRegistro.UseVisualStyleBackColor = true;
            this.btn_Salir_ResultadodelRegistro.Click += new System.EventHandler(this.btn_Salir_ResultadodelRegistro_Click);
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpResultadoProfesion);
            this.Controls.Add(this.grpIngresoProfesión);
            this.Name = "frm5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de profesión";
            this.Load += new System.EventHandler(this.frm5_Load);
            this.grpIngresoProfesión.ResumeLayout(false);
            this.grpIngresoProfesión.PerformLayout();
            this.grpResultadoProfesion.ResumeLayout(false);
            this.grpResultadoProfesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_IngresoCodigo;
        private System.Windows.Forms.TextBox txtIngresoHora;
        private System.Windows.Forms.Label lbl_IngresoProfesion;
        private System.Windows.Forms.TextBox txtIngresoProfesion;
        private System.Windows.Forms.Label lbl_IngresoHora;
        private System.Windows.Forms.TextBox txtIngresoCodigo;
        private System.Windows.Forms.TextBox txtResultadoProfesión;
        private System.Windows.Forms.Label lbl_ResultadoCodigo;
        private System.Windows.Forms.Label lbl_ResultadoProfesion;
        private System.Windows.Forms.TextBox txtResultadoHora;
        private System.Windows.Forms.Label lbl_ResultadoHora;
        private System.Windows.Forms.TextBox txtResultadoCodigo;
        private System.Windows.Forms.GroupBox grpIngresoProfesión;
        private System.Windows.Forms.GroupBox grpResultadoProfesion;
        private System.Windows.Forms.Button btn_Limpiar_DatosProfesion;
        private System.Windows.Forms.Button btn_Guardar_DatosProfesion;
        private System.Windows.Forms.Button btn_Salir_ResultadodelRegistro;
        private System.Windows.Forms.Button btnModificar;
    }
}
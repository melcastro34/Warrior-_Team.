namespace Calculo_Nómina
{
    partial class frm6
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
            this.btn_SalirReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SalirReportes
            // 
            this.btn_SalirReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirReportes.Location = new System.Drawing.Point(12, 202);
            this.btn_SalirReportes.Name = "btn_SalirReportes";
            this.btn_SalirReportes.Size = new System.Drawing.Size(79, 30);
            this.btn_SalirReportes.TabIndex = 0;
            this.btn_SalirReportes.Text = "Salir";
            this.btn_SalirReportes.UseVisualStyleBackColor = true;
            this.btn_SalirReportes.Click += new System.EventHandler(this.btn_SalirReportes_Click);
            // 
            // frm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(505, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btn_SalirReportes);
            this.Name = "frm6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SalirReportes;
    }
}
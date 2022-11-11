namespace Calculo_Nómina
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDelEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDePlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProfesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ImagenPrincipal = new System.Windows.Forms.Label();
            this.lbl_ImagenCR = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ingresoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDelEmpleadoToolStripMenuItem,
            this.calculoDePlanillaToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // informaciónDelEmpleadoToolStripMenuItem
            // 
            this.informaciónDelEmpleadoToolStripMenuItem.Name = "informaciónDelEmpleadoToolStripMenuItem";
            this.informaciónDelEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.informaciónDelEmpleadoToolStripMenuItem.Text = "Información del empleado";
            this.informaciónDelEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.informaciónDelEmpleadoToolStripMenuItem_Click);
            // 
            // calculoDePlanillaToolStripMenuItem
            // 
            this.calculoDePlanillaToolStripMenuItem.Name = "calculoDePlanillaToolStripMenuItem";
            this.calculoDePlanillaToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.calculoDePlanillaToolStripMenuItem.Text = "Calculo de planilla";
            this.calculoDePlanillaToolStripMenuItem.Click += new System.EventHandler(this.calculoDePlanillaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEmpleadoToolStripMenuItem,
            this.registroDeProfesiónToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // registroDeEmpleadoToolStripMenuItem
            // 
            this.registroDeEmpleadoToolStripMenuItem.Name = "registroDeEmpleadoToolStripMenuItem";
            this.registroDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.registroDeEmpleadoToolStripMenuItem.Text = "Registro de empleado";
            this.registroDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registroDeEmpleadoToolStripMenuItem_Click);
            // 
            // registroDeProfesiónToolStripMenuItem
            // 
            this.registroDeProfesiónToolStripMenuItem.Name = "registroDeProfesiónToolStripMenuItem";
            this.registroDeProfesiónToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.registroDeProfesiónToolStripMenuItem.Text = "Registro de profesión";
            this.registroDeProfesiónToolStripMenuItem.Click += new System.EventHandler(this.registroDeProfesiónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeEmpleadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ingresoDeEmpleadosToolStripMenuItem
            // 
            this.ingresoDeEmpleadosToolStripMenuItem.Name = "ingresoDeEmpleadosToolStripMenuItem";
            this.ingresoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ingresoDeEmpleadosToolStripMenuItem.Text = "Ingreso de empleados";
            this.ingresoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeEmpleadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(429, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // lbl_ImagenPrincipal
            // 
            this.lbl_ImagenPrincipal.AutoSize = true;
            this.lbl_ImagenPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ImagenPrincipal.Image")));
            this.lbl_ImagenPrincipal.Location = new System.Drawing.Point(139, 83);
            this.lbl_ImagenPrincipal.Name = "lbl_ImagenPrincipal";
            this.lbl_ImagenPrincipal.Size = new System.Drawing.Size(355, 288);
            this.lbl_ImagenPrincipal.TabIndex = 4;
            this.lbl_ImagenPrincipal.Text = ".                                                                                " +
    "                                  .\r\n\r\n\r\n\r\n\r\n\r\n.\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n.";
            // 
            // lbl_ImagenCR
            // 
            this.lbl_ImagenCR.AutoSize = true;
            this.lbl_ImagenCR.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ImagenCR.Image")));
            this.lbl_ImagenCR.Location = new System.Drawing.Point(45, 70);
            this.lbl_ImagenCR.Name = "lbl_ImagenCR";
            this.lbl_ImagenCR.Size = new System.Drawing.Size(88, 64);
            this.lbl_ImagenCR.TabIndex = 5;
            this.lbl_ImagenCR.Text = "\r\n\r\n\r\n.                         .";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ImagenCR);
            this.Controls.Add(this.lbl_ImagenPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÁLCULO DE NÓMINA EMPLEOS COSTA RICA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDelEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDePlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProfesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ImagenPrincipal;
        private System.Windows.Forms.Label lbl_ImagenCR;
    }
}


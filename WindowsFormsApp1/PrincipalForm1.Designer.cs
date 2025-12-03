namespace WindowsFormsApp1
{
    partial class PrincipalForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolsEquipos = new System.Windows.Forms.ToolStripButton();
            this.toolsMantenimientos = new System.Windows.Forms.ToolStripButton();
            this.toolsTecnicos = new System.Windows.Forms.ToolStripButton();
            this.toolsProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolsUbicaciones = new System.Windows.Forms.ToolStripButton();
            this.toolsEdificios = new System.Windows.Forms.ToolStripButton();
            this.toolsBajas = new System.Windows.Forms.ToolStripButton();
            this.toolsResponsables = new System.Windows.Forms.ToolStripButton();
            this.toolsTransferencias = new System.Windows.Forms.ToolStripButton();
            this.toolsTipoEquipo = new System.Windows.Forms.ToolStripButton();
            this.marcas = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsEquipos,
            this.toolsMantenimientos,
            this.toolsTecnicos,
            this.toolsProvedores,
            this.toolsUbicaciones,
            this.toolsEdificios,
            this.toolsBajas,
            this.toolsResponsables,
            this.toolsTransferencias,
            this.toolsTipoEquipo,
            this.marcas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1073, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolsEquipos
            // 
            this.toolsEquipos.Image = ((System.Drawing.Image)(resources.GetObject("toolsEquipos.Image")));
            this.toolsEquipos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsEquipos.Name = "toolsEquipos";
            this.toolsEquipos.Size = new System.Drawing.Size(69, 22);
            this.toolsEquipos.Text = "Equipos";
            this.toolsEquipos.Click += new System.EventHandler(this.toolsEquipos_Click);
            // 
            // toolsMantenimientos
            // 
            this.toolsMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("toolsMantenimientos.Image")));
            this.toolsMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsMantenimientos.Name = "toolsMantenimientos";
            this.toolsMantenimientos.Size = new System.Drawing.Size(109, 22);
            this.toolsMantenimientos.Text = "Mantenimiento";
            this.toolsMantenimientos.Click += new System.EventHandler(this.toolsMantenimientos_Click);
            // 
            // toolsTecnicos
            // 
            this.toolsTecnicos.Image = ((System.Drawing.Image)(resources.GetObject("toolsTecnicos.Image")));
            this.toolsTecnicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsTecnicos.Name = "toolsTecnicos";
            this.toolsTecnicos.Size = new System.Drawing.Size(72, 22);
            this.toolsTecnicos.Text = "Tecnicos";
            this.toolsTecnicos.Click += new System.EventHandler(this.toolsTecnicos_Click);
            // 
            // toolsProvedores
            // 
            this.toolsProvedores.Image = ((System.Drawing.Image)(resources.GetObject("toolsProvedores.Image")));
            this.toolsProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsProvedores.Name = "toolsProvedores";
            this.toolsProvedores.Size = new System.Drawing.Size(92, 22);
            this.toolsProvedores.Text = "Proveedores";
            this.toolsProvedores.Click += new System.EventHandler(this.toolsProvedores_Click);
            // 
            // toolsUbicaciones
            // 
            this.toolsUbicaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolsUbicaciones.Image")));
            this.toolsUbicaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsUbicaciones.Name = "toolsUbicaciones";
            this.toolsUbicaciones.Size = new System.Drawing.Size(91, 22);
            this.toolsUbicaciones.Text = "Ubicaciones";
            this.toolsUbicaciones.Click += new System.EventHandler(this.toolsUbicaciones_Click);
            // 
            // toolsEdificios
            // 
            this.toolsEdificios.Image = ((System.Drawing.Image)(resources.GetObject("toolsEdificios.Image")));
            this.toolsEdificios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsEdificios.Name = "toolsEdificios";
            this.toolsEdificios.Size = new System.Drawing.Size(71, 22);
            this.toolsEdificios.Text = "Edificios";
            this.toolsEdificios.Click += new System.EventHandler(this.toolsEdificios_Click);
            // 
            // toolsBajas
            // 
            this.toolsBajas.Image = ((System.Drawing.Image)(resources.GetObject("toolsBajas.Image")));
            this.toolsBajas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsBajas.Name = "toolsBajas";
            this.toolsBajas.Size = new System.Drawing.Size(54, 22);
            this.toolsBajas.Text = "Bajas";
            this.toolsBajas.Click += new System.EventHandler(this.toolsBajas_Click);
            // 
            // toolsResponsables
            // 
            this.toolsResponsables.Image = ((System.Drawing.Image)(resources.GetObject("toolsResponsables.Image")));
            this.toolsResponsables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsResponsables.Name = "toolsResponsables";
            this.toolsResponsables.Size = new System.Drawing.Size(98, 22);
            this.toolsResponsables.Text = "Responsables";
            this.toolsResponsables.Click += new System.EventHandler(this.toolsRepuestos_Click);
            // 
            // toolsTransferencias
            // 
            this.toolsTransferencias.Image = ((System.Drawing.Image)(resources.GetObject("toolsTransferencias.Image")));
            this.toolsTransferencias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsTransferencias.Name = "toolsTransferencias";
            this.toolsTransferencias.Size = new System.Drawing.Size(96, 22);
            this.toolsTransferencias.Text = "Tranferencias";
            this.toolsTransferencias.Click += new System.EventHandler(this.toolsTransferencias_Click);
            // 
            // toolsTipoEquipo
            // 
            this.toolsTipoEquipo.Image = ((System.Drawing.Image)(resources.GetObject("toolsTipoEquipo.Image")));
            this.toolsTipoEquipo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsTipoEquipo.Name = "toolsTipoEquipo";
            this.toolsTipoEquipo.Size = new System.Drawing.Size(92, 22);
            this.toolsTipoEquipo.Text = "Tipo_Equipo";
            this.toolsTipoEquipo.Click += new System.EventHandler(this.toolsTipoEquipo_Click);
            // 
            // marcas
            // 
            this.marcas.Image = ((System.Drawing.Image)(resources.GetObject("marcas.Image")));
            this.marcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(65, 22);
            this.marcas.Text = "Marcas";
            this.marcas.Click += new System.EventHandler(this.marcas_Click);
            // 
            // PrincipalForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm1";
            this.Text = "INVENTARIO DE EQUIPOS INFORMATICOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalForm1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolsEquipos;
        private System.Windows.Forms.ToolStripButton toolsMantenimientos;
        private System.Windows.Forms.ToolStripButton toolsTecnicos;
        private System.Windows.Forms.ToolStripButton toolsProvedores;
        private System.Windows.Forms.ToolStripButton toolsUbicaciones;
        private System.Windows.Forms.ToolStripButton toolsEdificios;
        private System.Windows.Forms.ToolStripButton toolsBajas;
        private System.Windows.Forms.ToolStripButton toolsResponsables;
        private System.Windows.Forms.ToolStripButton toolsTransferencias;
        private System.Windows.Forms.ToolStripButton toolsTipoEquipo;
        private System.Windows.Forms.ToolStripButton marcas;
    }
}


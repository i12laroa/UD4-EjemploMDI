namespace UD4_EjemploMDI
{
    partial class Almazara
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlmazara = new System.Windows.Forms.ToolStripMenuItem();
            this.aceitunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aceitunasCtrAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAceitunas = new System.Windows.Forms.ToolStripButton();
            this.tsbProduccion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCampana = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.MenuAlmazara,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //
            // salirToolStripMenuItem
            //
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeLaAplicaciónToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.salirToolStripMenuItem.Text = "&Archivo";
            //
            // salirDeLaAplicaciónToolStripMenuItem
            //
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "&Salir de la Aplicación";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            //
            // MenuAlmazara
            //
            this.MenuAlmazara.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aceitunasToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.toolStripSeparator2,
            this.inventarioToolStripMenuItem,
            this.facturaciónToolStripMenuItem});
            this.MenuAlmazara.Name = "MenuAlmazara";
            this.MenuAlmazara.Size = new System.Drawing.Size(73, 24);
            this.MenuAlmazara.Text = "&Gestión";
            //
            // aceitunasToolStripMenuItem
            //
            this.aceitunasToolStripMenuItem.Name = "aceitunasToolStripMenuItem";
            this.aceitunasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aceitunasToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.aceitunasToolStripMenuItem.Text = "&Aceitunas";
            this.aceitunasToolStripMenuItem.Click += new System.EventHandler(this.aceitunasToolStripMenuItem_Click);
            //
            // producciónToolStripMenuItem
            //
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.producciónToolStripMenuItem.Text = "&Producción";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            //
            // toolStripSeparator2
            //
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            //
            // inventarioToolStripMenuItem
            //
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.inventarioToolStripMenuItem.Text = "&Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.seccionEnDesarrollo_Click);
            //
            // facturaciónToolStripMenuItem
            //
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.facturaciónToolStripMenuItem.Text = "&Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.seccionEnDesarrollo_Click);
            //
            // ayudaToolStripMenuItem
            //
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            //
            // acercaDeToolStripMenuItem
            //
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca &de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aceitunasCtrAToolStripMenuItem,
            this.producciónCtrlPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 52);
            this.contextMenuStrip1.Text = "Menú Contextual";
            //
            // aceitunasCtrAToolStripMenuItem
            //
            this.aceitunasCtrAToolStripMenuItem.Name = "aceitunasCtrAToolStripMenuItem";
            this.aceitunasCtrAToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aceitunasCtrAToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.aceitunasCtrAToolStripMenuItem.Text = "Aceitunas";
            this.aceitunasCtrAToolStripMenuItem.Click += new System.EventHandler(this.aceitunasToolStripMenuItem_Click);
            //
            // producciónCtrlPToolStripMenuItem
            //
            this.producciónCtrlPToolStripMenuItem.Name = "producciónCtrlPToolStripMenuItem";
            this.producciónCtrlPToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.producciónCtrlPToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.producciónCtrlPToolStripMenuItem.Text = "Producción";
            this.producciónCtrlPToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            //
            // toolStrip1
            //
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAceitunas,
            this.tsbProduccion,
            this.toolStripSeparator1,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            //
            // tsbAceitunas
            //
            this.tsbAceitunas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAceitunas.Name = "tsbAceitunas";
            this.tsbAceitunas.Size = new System.Drawing.Size(105, 24);
            this.tsbAceitunas.Text = "Aceitunas";
            this.tsbAceitunas.ToolTipText = "Catálogo de variedades y calculadora (Ctrl+A)";
            this.tsbAceitunas.Click += new System.EventHandler(this.aceitunasToolStripMenuItem_Click);
            //
            // tsbProduccion
            //
            this.tsbProduccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbProduccion.Name = "tsbProduccion";
            this.tsbProduccion.Size = new System.Drawing.Size(110, 24);
            this.tsbProduccion.Text = "Producción";
            this.tsbProduccion.ToolTipText = "Producción de la almazara (Ctrl+P)";
            this.tsbProduccion.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            //
            // tsbSalir
            //
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(45, 24);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.ToolTipText = "Cerrar la aplicación (Ctrl+Q)";
            this.tsbSalir.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            //
            // statusStrip1
            //
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado,
            this.tsslCampana,
            this.tsslReloj});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            //
            // tsslEstado
            //
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(700, 20);
            this.tsslEstado.Spring = true;
            this.tsslEstado.Text = "Listo";
            this.tsslEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // tsslCampana
            //
            this.tsslCampana.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslCampana.Name = "tsslCampana";
            this.tsslCampana.Size = new System.Drawing.Size(150, 20);
            this.tsslCampana.Text = "Campaña";
            //
            // tsslReloj
            //
            this.tsslReloj.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslReloj.Name = "tsslReloj";
            this.tsslReloj.Size = new System.Drawing.Size(130, 20);
            this.tsslReloj.Text = "00:00:00";
            //
            // timerReloj
            //
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            //
            // Almazara
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Almazara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almazara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Almazara_FormClosing);
            this.Load += new System.EventHandler(this.Almazara_Load);
            this.Resize += new System.EventHandler(this.Almazara_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAlmazara;
        private System.Windows.Forms.ToolStripMenuItem aceitunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aceitunasCtrAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAceitunas;
        private System.Windows.Forms.ToolStripButton tsbProduccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslCampana;
        private System.Windows.Forms.ToolStripStatusLabel tsslReloj;
        private System.Windows.Forms.Timer timerReloj;
    }
}

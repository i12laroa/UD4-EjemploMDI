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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlmazara = new System.Windows.Forms.ToolStripMenuItem();
            this.aceitunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aceitunasCtrAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem,
            this.MenuAlmazara});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeLaAplicaciónToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.salirToolStripMenuItem.Text = "Archivo";
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Salir de la Aplicación";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // MenuAlmazara
            // 
            this.MenuAlmazara.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aceitunasToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.facturaciónToolStripMenuItem});
            this.MenuAlmazara.Name = "MenuAlmazara";
            this.MenuAlmazara.Size = new System.Drawing.Size(73, 24);
            this.MenuAlmazara.Text = "Gestión";
            // 
            // aceitunasToolStripMenuItem
            // 
            this.aceitunasToolStripMenuItem.Name = "aceitunasToolStripMenuItem";
            this.aceitunasToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.aceitunasToolStripMenuItem.Text = "Aceitunas Ctr+A";
            this.aceitunasToolStripMenuItem.Click += new System.EventHandler(this.aceitunasToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.producciónToolStripMenuItem.Text = "Producción Ctr+P";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
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
            this.aceitunasCtrAToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.aceitunasCtrAToolStripMenuItem.Text = "Aceitunas (Ctr+A)";
            this.aceitunasCtrAToolStripMenuItem.Click += new System.EventHandler(this.aceitunasToolStripMenuItem_Click);
            // 
            // producciónCtrlPToolStripMenuItem
            // 
            this.producciónCtrlPToolStripMenuItem.Name = "producciónCtrlPToolStripMenuItem";
            this.producciónCtrlPToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.producciónCtrlPToolStripMenuItem.Text = "Producción(Ctrl + P)";
            this.producciónCtrlPToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // Almazara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Almazara";
            this.Text = "Almazara";
            this.Load += new System.EventHandler(this.Almazara_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Almazara_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuAlmazara;
        private System.Windows.Forms.ToolStripMenuItem aceitunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aceitunasCtrAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónCtrlPToolStripMenuItem;
    }
}

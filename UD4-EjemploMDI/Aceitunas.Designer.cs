namespace UD4_EjemploMDI
{
    partial class Aceitunas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aceitunas));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCatalogo = new System.Windows.Forms.GroupBox();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.dgvVariedades = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRendimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUso = new System.Windows.Forms.ComboBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.grpCalculadora = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbTresFases = new System.Windows.Forms.RadioButton();
            this.rbDosFases = new System.Windows.Forms.RadioButton();
            this.tbMadurez = new System.Windows.Forms.TrackBar();
            this.lblMadurez = new System.Windows.Forms.Label();
            this.nudKilos = new System.Windows.Forms.NumericUpDown();
            this.lblKilos = new System.Windows.Forms.Label();
            this.cmbVariedadCalc = new System.Windows.Forms.ComboBox();
            this.lblVariedad = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariedades)).BeginInit();
            this.grpCalculadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMadurez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPOS DE ACEITUNAS DE LA ALMAZARA";
            //
            // pictureBox1
            //
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            //
            // grpCatalogo
            //
            this.grpCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCatalogo.Controls.Add(this.lblEstadisticas);
            this.grpCatalogo.Controls.Add(this.dgvVariedades);
            this.grpCatalogo.Controls.Add(this.cmbUso);
            this.grpCatalogo.Controls.Add(this.lblUso);
            this.grpCatalogo.Controls.Add(this.txtBuscar);
            this.grpCatalogo.Controls.Add(this.lblBuscar);
            this.grpCatalogo.Location = new System.Drawing.Point(20, 60);
            this.grpCatalogo.Name = "grpCatalogo";
            this.grpCatalogo.Size = new System.Drawing.Size(600, 520);
            this.grpCatalogo.TabIndex = 1;
            this.grpCatalogo.TabStop = false;
            this.grpCatalogo.Text = "Catálogo de variedades";
            //
            // lblEstadisticas
            //
            this.lblEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadisticas.BackColor = System.Drawing.Color.Honeydew;
            this.lblEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadisticas.Location = new System.Drawing.Point(15, 465);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Padding = new System.Windows.Forms.Padding(4);
            this.lblEstadisticas.Size = new System.Drawing.Size(570, 45);
            this.lblEstadisticas.TabIndex = 5;
            this.lblEstadisticas.Text = "Estadísticas";
            //
            // dgvVariedades
            //
            this.dgvVariedades.AllowUserToAddRows = false;
            this.dgvVariedades.AllowUserToDeleteRows = false;
            this.dgvVariedades.AllowUserToResizeRows = false;
            this.dgvVariedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVariedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVariedades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVariedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colOrigen,
            this.colUso,
            this.colRendimiento,
            this.colPrecio});
            this.dgvVariedades.Location = new System.Drawing.Point(15, 65);
            this.dgvVariedades.MultiSelect = false;
            this.dgvVariedades.Name = "dgvVariedades";
            this.dgvVariedades.ReadOnly = true;
            this.dgvVariedades.RowHeadersVisible = false;
            this.dgvVariedades.RowHeadersWidth = 51;
            this.dgvVariedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariedades.Size = new System.Drawing.Size(570, 390);
            this.dgvVariedades.TabIndex = 4;
            this.dgvVariedades.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVariedades_ColumnHeaderMouseClick);
            this.dgvVariedades.SelectionChanged += new System.EventHandler(this.dgvVariedades_SelectionChanged);
            //
            // colNombre
            //
            this.colNombre.FillWeight = 130F;
            this.colNombre.HeaderText = "Variedad";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // colOrigen
            //
            this.colOrigen.FillWeight = 130F;
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 6;
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.ReadOnly = true;
            this.colOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // colUso
            //
            this.colUso.HeaderText = "Uso";
            this.colUso.MinimumWidth = 6;
            this.colUso.Name = "colUso";
            this.colUso.ReadOnly = true;
            this.colUso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // colRendimiento
            //
            this.colRendimiento.HeaderText = "Rend. (%)";
            this.colRendimiento.MinimumWidth = 6;
            this.colRendimiento.Name = "colRendimiento";
            this.colRendimiento.ReadOnly = true;
            this.colRendimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // colPrecio
            //
            this.colPrecio.HeaderText = "Precio (€/kg)";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // cmbUso
            //
            this.cmbUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUso.FormattingEnabled = true;
            this.cmbUso.Items.AddRange(new object[] {
            "Todos",
            "Aceite",
            "Mesa",
            "Doble aptitud"});
            this.cmbUso.Location = new System.Drawing.Point(390, 29);
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(180, 24);
            this.cmbUso.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbUso, "Filtra las variedades por su uso principal");
            this.cmbUso.SelectedIndexChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // lblUso
            //
            this.lblUso.AutoSize = true;
            this.lblUso.Location = new System.Drawing.Point(345, 32);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(36, 16);
            this.lblUso.TabIndex = 2;
            this.lblUso.Text = "Uso:";
            //
            // txtBuscar
            //
            this.txtBuscar.Location = new System.Drawing.Point(80, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(230, 22);
            this.txtBuscar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtBuscar, "Busca por nombre u origen (no distingue tildes ni mayúsculas)");
            this.txtBuscar.TextChanged += new System.EventHandler(this.Filtros_Changed);
            //
            // lblBuscar
            //
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            //
            // grpCalculadora
            //
            this.grpCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCalculadora.Controls.Add(this.lblResultado);
            this.grpCalculadora.Controls.Add(this.btnCalcular);
            this.grpCalculadora.Controls.Add(this.rbTresFases);
            this.grpCalculadora.Controls.Add(this.rbDosFases);
            this.grpCalculadora.Controls.Add(this.tbMadurez);
            this.grpCalculadora.Controls.Add(this.lblMadurez);
            this.grpCalculadora.Controls.Add(this.nudKilos);
            this.grpCalculadora.Controls.Add(this.lblKilos);
            this.grpCalculadora.Controls.Add(this.cmbVariedadCalc);
            this.grpCalculadora.Controls.Add(this.lblVariedad);
            this.grpCalculadora.Location = new System.Drawing.Point(640, 195);
            this.grpCalculadora.Name = "grpCalculadora";
            this.grpCalculadora.Size = new System.Drawing.Size(300, 385);
            this.grpCalculadora.TabIndex = 2;
            this.grpCalculadora.TabStop = false;
            this.grpCalculadora.Text = "Calculadora de molturación";
            //
            // lblResultado
            //
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.BackColor = System.Drawing.Color.Ivory;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(15, 290);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(4);
            this.lblResultado.Size = new System.Drawing.Size(270, 85);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Introduce los datos y pulsa Calcular.";
            //
            // btnCalcular
            //
            this.btnCalcular.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(15, 245);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(270, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "&Calcular rendimiento";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            //
            // rbTresFases
            //
            this.rbTresFases.AutoSize = true;
            this.rbTresFases.Location = new System.Drawing.Point(150, 212);
            this.rbTresFases.Name = "rbTresFases";
            this.rbTresFases.Size = new System.Drawing.Size(92, 20);
            this.rbTresFases.TabIndex = 7;
            this.rbTresFases.Text = "Tres fases";
            this.toolTip1.SetToolTip(this.rbTresFases, "Decánter de tres fases (eficiencia aprox. 88 %)");
            this.rbTresFases.UseVisualStyleBackColor = true;
            //
            // rbDosFases
            //
            this.rbDosFases.AutoSize = true;
            this.rbDosFases.Checked = true;
            this.rbDosFases.Location = new System.Drawing.Point(15, 212);
            this.rbDosFases.Name = "rbDosFases";
            this.rbDosFases.Size = new System.Drawing.Size(89, 20);
            this.rbDosFases.TabIndex = 6;
            this.rbDosFases.TabStop = true;
            this.rbDosFases.Text = "Dos fases";
            this.toolTip1.SetToolTip(this.rbDosFases, "Decánter de dos fases (eficiencia aprox. 92 %)");
            this.rbDosFases.UseVisualStyleBackColor = true;
            //
            // tbMadurez
            //
            this.tbMadurez.LargeChange = 1;
            this.tbMadurez.Location = new System.Drawing.Point(15, 160);
            this.tbMadurez.Maximum = 7;
            this.tbMadurez.Name = "tbMadurez";
            this.tbMadurez.Size = new System.Drawing.Size(270, 56);
            this.tbMadurez.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbMadurez, "0 = aceituna verde intensa, 7 = negra con pulpa morada hasta el hueso");
            this.tbMadurez.Value = 4;
            this.tbMadurez.ValueChanged += new System.EventHandler(this.tbMadurez_ValueChanged);
            //
            // lblMadurez
            //
            this.lblMadurez.AutoSize = true;
            this.lblMadurez.Location = new System.Drawing.Point(15, 140);
            this.lblMadurez.Name = "lblMadurez";
            this.lblMadurez.Size = new System.Drawing.Size(129, 16);
            this.lblMadurez.TabIndex = 4;
            this.lblMadurez.Text = "Índice de madurez:";
            //
            // nudKilos
            //
            this.nudKilos.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudKilos.Location = new System.Drawing.Point(15, 105);
            this.nudKilos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKilos.Name = "nudKilos";
            this.nudKilos.Size = new System.Drawing.Size(270, 22);
            this.nudKilos.TabIndex = 3;
            this.nudKilos.ThousandsSeparator = true;
            this.nudKilos.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            //
            // lblKilos
            //
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(15, 85);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(117, 16);
            this.lblKilos.TabIndex = 2;
            this.lblKilos.Text = "Kilos de aceituna:";
            //
            // cmbVariedadCalc
            //
            this.cmbVariedadCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariedadCalc.FormattingEnabled = true;
            this.cmbVariedadCalc.Location = new System.Drawing.Point(15, 50);
            this.cmbVariedadCalc.Name = "cmbVariedadCalc";
            this.cmbVariedadCalc.Size = new System.Drawing.Size(270, 24);
            this.cmbVariedadCalc.TabIndex = 1;
            //
            // lblVariedad
            //
            this.lblVariedad.AutoSize = true;
            this.lblVariedad.Location = new System.Drawing.Point(15, 30);
            this.lblVariedad.Name = "lblVariedad";
            this.lblVariedad.Size = new System.Drawing.Size(65, 16);
            this.lblVariedad.TabIndex = 0;
            this.lblVariedad.Text = "Variedad:";
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            //
            // Aceitunas
            //
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.ControlBox = false;
            this.Controls.Add(this.grpCalculadora);
            this.Controls.Add(this.grpCatalogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Aceitunas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aceitunas";
            this.Load += new System.EventHandler(this.Aceitunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCatalogo.ResumeLayout(false);
            this.grpCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariedades)).EndInit();
            this.grpCalculadora.ResumeLayout(false);
            this.grpCalculadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMadurez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpCatalogo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblUso;
        private System.Windows.Forms.ComboBox cmbUso;
        private System.Windows.Forms.DataGridView dgvVariedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRendimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.GroupBox grpCalculadora;
        private System.Windows.Forms.Label lblVariedad;
        private System.Windows.Forms.ComboBox cmbVariedadCalc;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.NumericUpDown nudKilos;
        private System.Windows.Forms.Label lblMadurez;
        private System.Windows.Forms.TrackBar tbMadurez;
        private System.Windows.Forms.RadioButton rbDosFases;
        private System.Windows.Forms.RadioButton rbTresFases;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

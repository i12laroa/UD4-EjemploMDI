namespace UD4_EjemploMDI
{
    partial class Produccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblKilos = new System.Windows.Forms.Label();
            this.nudKilos = new System.Windows.Forms.NumericUpDown();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.lstProduccion = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCCIÓN DE LA ALMAZARA";
            //
            // monthCalendar1
            //
            this.monthCalendar1.Location = new System.Drawing.Point(43, 103);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            //
            // lblKilos
            //
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(360, 103);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(95, 16);
            this.lblKilos.TabIndex = 2;
            this.lblKilos.Text = "Kilos molidos:";
            //
            // nudKilos
            //
            this.nudKilos.Location = new System.Drawing.Point(360, 128);
            this.nudKilos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKilos.Name = "nudKilos";
            this.nudKilos.Size = new System.Drawing.Size(150, 22);
            this.nudKilos.TabIndex = 3;
            //
            // btnAnadir
            //
            this.btnAnadir.Location = new System.Drawing.Point(525, 124);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(100, 30);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            //
            // lstProduccion
            //
            this.lstProduccion.FormattingEnabled = true;
            this.lstProduccion.ItemHeight = 16;
            this.lstProduccion.Location = new System.Drawing.Point(360, 170);
            this.lstProduccion.Name = "lstProduccion";
            this.lstProduccion.Size = new System.Drawing.Size(265, 180);
            this.lstProduccion.TabIndex = 5;
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(360, 365);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: 0 kg";
            //
            // Produccion
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstProduccion);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.nudKilos);
            this.Controls.Add(this.lblKilos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.NumericUpDown nudKilos;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.ListBox lstProduccion;
        private System.Windows.Forms.Label lblTotal;
    }
}

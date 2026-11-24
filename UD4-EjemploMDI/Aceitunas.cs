using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD4_EjemploMDI
{
    public partial class Aceitunas : Form
    {
        public Aceitunas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Comprobamos que se ha elegido una variedad
            if (cmbVariedad.SelectedIndex == -1)
            {
                MessageBox.Show("Elige una variedad de aceituna");
                return;
            }

            // Rendimiento (% de aceite) según la variedad
            double rendimiento;
            switch (cmbVariedad.Text)
            {
                case "Picual": rendimiento = 23; break;
                case "Hojiblanca": rendimiento = 19; break;
                case "Arbequina": rendimiento = 20; break;
                default: rendimiento = 15; break; // Manzanilla
            }

            double litros = (double)nudKilos.Value * rendimiento / 100;
            lblResultado.Text = "Aceite estimado: " + litros.ToString("0.0") + " litros (" + rendimiento + " %)";
        }
    }
}

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
    public partial class Produccion : Form
    {
        private decimal totalKilos = 0;

        public Produccion()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (nudKilos.Value == 0)
            {
                MessageBox.Show("Introduce los kilos molidos");
                return;
            }

            // Añadimos la fecha elegida en el calendario y los kilos a la lista
            string fecha = monthCalendar1.SelectionStart.ToShortDateString();
            lstProduccion.Items.Add(fecha + " - " + nudKilos.Value + " kg");

            // Acumulamos el total
            totalKilos = totalKilos + nudKilos.Value;
            lblTotal.Text = "Total: " + totalKilos + " kg";

            nudKilos.Value = 0;
        }
    }
}

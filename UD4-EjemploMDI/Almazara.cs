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
    public partial class Almazara : Form
    {
       public Form paginaAceitunas, paginaProduccion;
     //   private Point posicionAceitunas;
     //   private Point posicionProduccion;

        public Almazara()
        {
            InitializeComponent();
        }

        private void aceitunasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (paginaAceitunas == null)
            {
                paginaAceitunas = new Aceitunas();
                paginaAceitunas.MdiParent = this;
                paginaAceitunas.Show();
          //      posicionAceitunas = paginaAceitunas.Location;

            }
            else
            {

                paginaAceitunas.Visible= true;
          //      paginaAceitunas.Location = posicionAceitunas;

            }

            //Cerramos las otros formularios
            if (paginaProduccion != null && paginaProduccion.Visible == true)
            {
                paginaProduccion.Visible = false;
            }

        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Almazara_KeyDown(object sender, KeyEventArgs e)
        {
            //Función para controlar los atajos de teclados
            if (e.Control && e.KeyCode == Keys.A) // Ctrl + A para Aceitunas
            {
                aceitunasToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.P) // Ctrl + P para Producccion
            {
                producciónToolStripMenuItem_Click (sender, e);
            }
        }

        private void Almazara_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Permite detectar pulsaciones de teclas

        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (paginaProduccion == null)
            {
                paginaProduccion = new Produccion();
                paginaProduccion.MdiParent = this;
                paginaProduccion.Show();
                //Tenemos que configurar la propiedad starposition en manual de
                //la ventana hija Producción
           //     posicionProduccion = paginaProduccion.Location;

            }
            else
            {
                paginaProduccion.Visible = true;
           //     paginaProduccion.Location = posicionProduccion;
            }

            //Comprobamos que la pagina anterior se quita
            if (paginaAceitunas != null && paginaAceitunas.Visible == true)
            {
                paginaAceitunas.Visible = false;
            }
        }
    }
}

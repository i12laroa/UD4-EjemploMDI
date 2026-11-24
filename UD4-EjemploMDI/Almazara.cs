using System;
using System.Drawing;
using System.Windows.Forms;

namespace UD4_EjemploMDI
{
    public partial class Almazara : Form
    {
        public Almazara()
        {
            InitializeComponent();
        }

        private void Almazara_Load(object sender, EventArgs e)
        {
            ActualizarBarraEstado();
            timerReloj.Start();
        }

        #region Gestión de formularios hijos (MDI)

        /// <summary>
        /// Muestra el formulario hijo de tipo T. Si ya existe lo reutiliza (no se crean duplicados)
        /// y oculta el resto de hijos para que solo haya una sección visible.
        /// </summary>
        private T MostrarFormulario<T>() where T : Form, new()
        {
            T formulario = null;

            // Búsqueda lineal del hijo entre los formularios MDI existentes
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is T)
                {
                    formulario = (T)hijo;
                    break;
                }
            }

            if (formulario == null)
            {
                formulario = new T();
                formulario.MdiParent = this;
            }

            // Ocultamos los demás formularios
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo != formulario && hijo.Visible)
                    hijo.Visible = false;
            }

            AjustarAlArea(formulario);
            formulario.Show();
            formulario.BringToFront();

            MarcarSeccionActiva(formulario);
            return formulario;
        }

        /// <summary>Hace que el hijo ocupe todo el área MDI disponible.</summary>
        private void AjustarAlArea(Form hijo)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    hijo.Location = Point.Empty;
                    hijo.Size = c.ClientSize;
                    return;
                }
            }
        }

        private void Almazara_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            foreach (Form hijo in this.MdiChildren)
                AjustarAlArea(hijo);
        }

        /// <summary>Marca en menú y barra de herramientas la sección que se está viendo.</summary>
        private void MarcarSeccionActiva(Form activo)
        {
            bool esAceitunas = activo is Aceitunas;
            bool esProduccion = activo is Produccion;

            aceitunasToolStripMenuItem.Checked = esAceitunas;
            tsbAceitunas.Checked = esAceitunas;
            producciónToolStripMenuItem.Checked = esProduccion;
            tsbProduccion.Checked = esProduccion;

            tsslEstado.Text = "Sección: " + activo.Text;
            this.Text = "Almazara - " + activo.Text;
        }

        private void aceitunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario<Aceitunas>();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario<Produccion>();
        }

        private void seccionEnDesarrollo_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            MessageBox.Show("La sección \"" + item.Text.Replace("&", "") + "\" está en desarrollo.",
                "Almazara", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Barra de estado

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            ActualizarBarraEstado();
        }

        private void ActualizarBarraEstado()
        {
            DateTime ahora = DateTime.Now;
            int dia;
            string campana = AlgoritmosAlmazara.CampanaOleicola(ahora, out dia);

            tsslCampana.Text = "Campaña " + campana + " · día " + dia;
            tsslReloj.Text = ahora.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #endregion

        #region Salir y ayuda

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Almazara_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solo preguntamos si es el usuario quien cierra (no Windows al apagar, etc.)
            if (e.CloseReason != CloseReason.UserClosing) return;

            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres salir de la aplicación?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.No)
                e.Cancel = true;
            else
                timerReloj.Stop();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Almazara - Ejemplo MDI (UD4)\r\n\r\n" +
                "Atajos:\r\n  Ctrl+A  Aceitunas\r\n  Ctrl+P  Producción\r\n  Ctrl+Q  Salir\r\n  F1      Acerca de",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}

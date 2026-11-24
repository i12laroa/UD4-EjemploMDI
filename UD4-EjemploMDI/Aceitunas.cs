using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UD4_EjemploMDI
{
    public partial class Aceitunas : Form
    {
        // Eficiencia aproximada de cada sistema de extracción
        private const double EficienciaDosFases = 0.92;
        private const double EficienciaTresFases = 0.88;

        private readonly List<Variedad> catalogo = Variedad.CatalogoInicial();
        private List<Variedad> visibles = new List<Variedad>();

        // Estado de la ordenación (columna y sentido)
        private int columnaOrden = 0;
        private bool ordenAscendente = true;

        public Aceitunas()
        {
            InitializeComponent();
        }

        private void Aceitunas_Load(object sender, EventArgs e)
        {
            cmbUso.SelectedIndex = 0;

            foreach (Variedad v in catalogo)
                cmbVariedadCalc.Items.Add(v);
            cmbVariedadCalc.SelectedIndex = 0;

            tbMadurez_ValueChanged(tbMadurez, EventArgs.Empty);
            ActualizarListado();
        }

        #region Catálogo: filtro, ordenación y estadísticas

        private void Filtros_Changed(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private UsoAceituna? UsoSeleccionado()
        {
            switch (cmbUso.SelectedIndex)
            {
                case 1: return UsoAceituna.Aceite;
                case 2: return UsoAceituna.Mesa;
                case 3: return UsoAceituna.DobleAptitud;
                default: return null; // "Todos"
            }
        }

        /// <summary>Filtra, ordena y vuelve a pintar la tabla y las estadísticas.</summary>
        private void ActualizarListado()
        {
            visibles = AlgoritmosAlmazara.Filtrar(catalogo, txtBuscar.Text, UsoSeleccionado());
            AlgoritmosAlmazara.OrdenarPorInsercion(visibles, CompararPorColumna);

            dgvVariedades.Rows.Clear();
            foreach (Variedad v in visibles)
            {
                int fila = dgvVariedades.Rows.Add(v.Nombre, v.Origen, v.UsoTexto,
                    v.Rendimiento.ToString("0.0"), v.PrecioKg.ToString("0.00"));
                dgvVariedades.Rows[fila].Tag = v;

                // Resaltamos las variedades de alto rendimiento graso
                if (v.Rendimiento >= 21)
                    dgvVariedades.Rows[fila].DefaultCellStyle.BackColor = Color.FromArgb(226, 240, 203);
            }

            // Indicador visual de la columna ordenada
            foreach (DataGridViewColumn col in dgvVariedades.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            dgvVariedades.Columns[columnaOrden].HeaderCell.SortGlyphDirection =
                ordenAscendente ? SortOrder.Ascending : SortOrder.Descending;

            if (visibles.Count == 0 && txtBuscar.Text.Trim().Length > 0)
                errorProvider1.SetError(txtBuscar, "No hay variedades que coincidan con la búsqueda");
            else
                errorProvider1.SetError(txtBuscar, "");

            MostrarEstadisticas();
        }

        private int CompararPorColumna(Variedad a, Variedad b)
        {
            int resultado;
            switch (columnaOrden)
            {
                case 1: resultado = string.Compare(a.Origen, b.Origen, StringComparison.CurrentCultureIgnoreCase); break;
                case 2: resultado = string.Compare(a.UsoTexto, b.UsoTexto, StringComparison.CurrentCultureIgnoreCase); break;
                case 3: resultado = a.Rendimiento.CompareTo(b.Rendimiento); break;
                case 4: resultado = a.PrecioKg.CompareTo(b.PrecioKg); break;
                default: resultado = string.Compare(a.Nombre, b.Nombre, StringComparison.CurrentCultureIgnoreCase); break;
            }
            return ordenAscendente ? resultado : -resultado;
        }

        private void dgvVariedades_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Pulsar la misma columna invierte el sentido; otra columna ordena ascendente
            if (e.ColumnIndex == columnaOrden)
                ordenAscendente = !ordenAscendente;
            else
            {
                columnaOrden = e.ColumnIndex;
                ordenAscendente = true;
            }
            ActualizarListado();
        }

        private void MostrarEstadisticas()
        {
            double media;
            Variedad mejor, peor;
            AlgoritmosAlmazara.Estadisticas(visibles, out media, out mejor, out peor);

            if (visibles.Count == 0)
            {
                lblEstadisticas.Text = "Sin resultados.";
                return;
            }

            lblEstadisticas.Text = string.Format(
                "{0} variedad(es) · Rendimiento medio: {1:0.0} %\r\nMayor: {2} ({3:0.0} %) · Menor: {4} ({5:0.0} %)",
                visibles.Count, media, mejor.Nombre, mejor.Rendimiento, peor.Nombre, peor.Rendimiento);
        }

        private void dgvVariedades_SelectionChanged(object sender, EventArgs e)
        {
            // Al seleccionar una variedad en la tabla se carga en la calculadora
            if (dgvVariedades.CurrentRow != null && dgvVariedades.CurrentRow.Tag is Variedad)
                cmbVariedadCalc.SelectedItem = dgvVariedades.CurrentRow.Tag;
        }

        #endregion

        #region Calculadora de molturación

        private void tbMadurez_ValueChanged(object sender, EventArgs e)
        {
            string[] descripcion = { "verde intenso", "verde amarillento", "envero inicial", "envero",
                                     "negra (piel)", "negra < 50 % pulpa", "negra > 50 % pulpa", "negra total" };
            lblMadurez.Text = string.Format("Índice de madurez: {0} ({1})", tbMadurez.Value, descripcion[tbMadurez.Value]);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Variedad v = cmbVariedadCalc.SelectedItem as Variedad;
            if (v == null)
            {
                errorProvider1.SetError(cmbVariedadCalc, "Selecciona una variedad");
                return;
            }
            errorProvider1.SetError(cmbVariedadCalc, "");

            double kilos = (double)nudKilos.Value;
            double eficiencia = rbDosFases.Checked ? EficienciaDosFases : EficienciaTresFases;

            double kgAceite, litros;
            double rendimientoReal = AlgoritmosAlmazara.CalcularMolturacion(
                kilos, v.Rendimiento, tbMadurez.Value, eficiencia, out kgAceite, out litros);

            double valorPartida = kilos * v.PrecioKg;
            double kilosPorLitro = kilos / litros;

            lblResultado.Text = string.Format(
                "Rendimiento real: {0:0.00} %\r\nAceite: {1:N1} kg  ≈  {2:N1} litros\r\n" +
                "Se necesitan {3:0.0} kg de aceituna por litro\r\nValor de la partida: {4:N2} €",
                rendimientoReal, kgAceite, litros, kilosPorLitro, valorPartida);

            // Aviso si la variedad no es la más adecuada para almazara
            if (v.Uso == UsoAceituna.Mesa)
            {
                lblResultado.BackColor = Color.MistyRose;
                toolTip1.SetToolTip(lblResultado, v.Nombre + " es una variedad de mesa: su rendimiento graso es bajo.");
            }
            else
            {
                lblResultado.BackColor = Color.Ivory;
                toolTip1.SetToolTip(lblResultado, "");
            }
        }

        #endregion
    }
}

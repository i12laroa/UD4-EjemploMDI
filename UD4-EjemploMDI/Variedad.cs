using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UD4_EjemploMDI
{
    /// <summary>
    /// Uso principal de una variedad de aceituna.
    /// </summary>
    public enum UsoAceituna
    {
        Aceite,
        Mesa,
        DobleAptitud
    }

    /// <summary>
    /// Representa una variedad de aceituna del catálogo de la almazara.
    /// Los valores de rendimiento y precio son orientativos (ejemplo didáctico).
    /// </summary>
    public class Variedad
    {
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public UsoAceituna Uso { get; set; }
        /// <summary>Rendimiento graso medio (% de aceite sobre el peso de la aceituna).</summary>
        public double Rendimiento { get; set; }
        /// <summary>Precio orientativo en origen (€/kg de aceituna).</summary>
        public double PrecioKg { get; set; }

        public Variedad(string nombre, string origen, UsoAceituna uso, double rendimiento, double precioKg)
        {
            Nombre = nombre;
            Origen = origen;
            Uso = uso;
            Rendimiento = rendimiento;
            PrecioKg = precioKg;
        }

        public string UsoTexto
        {
            get
            {
                switch (Uso)
                {
                    case UsoAceituna.Mesa: return "Mesa";
                    case UsoAceituna.DobleAptitud: return "Doble aptitud";
                    default: return "Aceite";
                }
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>Catálogo inicial de variedades.</summary>
        public static List<Variedad> CatalogoInicial()
        {
            return new List<Variedad>
            {
                new Variedad("Picual",           "Jaén",               UsoAceituna.Aceite,       23.5, 0.62),
                new Variedad("Hojiblanca",       "Córdoba / Málaga",   UsoAceituna.DobleAptitud, 19.0, 0.58),
                new Variedad("Arbequina",        "Cataluña",           UsoAceituna.Aceite,       20.5, 0.60),
                new Variedad("Cornicabra",       "Castilla-La Mancha", UsoAceituna.Aceite,       21.0, 0.57),
                new Variedad("Manzanilla",       "Sevilla",            UsoAceituna.Mesa,         15.0, 0.95),
                new Variedad("Gordal",           "Sevilla",            UsoAceituna.Mesa,         12.0, 1.20),
                new Variedad("Empeltre",         "Aragón",             UsoAceituna.DobleAptitud, 20.0, 0.65),
                new Variedad("Picudo",           "Córdoba",            UsoAceituna.Aceite,       20.0, 0.59),
                new Variedad("Verdial",          "Málaga",             UsoAceituna.Aceite,       18.0, 0.55),
                new Variedad("Manzanilla cacereña", "Extremadura",     UsoAceituna.DobleAptitud, 17.0, 0.80),
            };
        }
    }

    /// <summary>
    /// Algoritmos usados por los formularios: búsqueda, ordenación, estadísticas y cálculo de rendimiento.
    /// Se implementan "a mano" (sin LINQ) con fines didácticos.
    /// </summary>
    public static class AlgoritmosAlmazara
    {
        /// <summary>Densidad media del aceite de oliva (kg/l).</summary>
        public const double DensidadAceite = 0.916;

        /// <summary>
        /// Quita tildes y pasa a minúsculas para comparar textos sin tener en cuenta acentos ni mayúsculas.
        /// </summary>
        public static string Normalizar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return string.Empty;
            string descompuesto = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (char c in descompuesto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(char.ToLowerInvariant(c));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Búsqueda lineal con filtro: devuelve las variedades cuyo nombre u origen contienen el texto
        /// y cuyo uso coincide (null = cualquier uso).
        /// </summary>
        public static List<Variedad> Filtrar(List<Variedad> origen, string texto, UsoAceituna? uso)
        {
            string patron = Normalizar(texto.Trim());
            List<Variedad> resultado = new List<Variedad>();
            for (int i = 0; i < origen.Count; i++)
            {
                Variedad v = origen[i];
                bool coincideTexto = patron.Length == 0
                    || Normalizar(v.Nombre).Contains(patron)
                    || Normalizar(v.Origen).Contains(patron);
                bool coincideUso = !uso.HasValue || v.Uso == uso.Value;
                if (coincideTexto && coincideUso)
                    resultado.Add(v);
            }
            return resultado;
        }

        /// <summary>
        /// Ordenación por inserción (estable) según el criterio de comparación indicado.
        /// </summary>
        public static void OrdenarPorInsercion(List<Variedad> lista, Comparison<Variedad> comparar)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Variedad actual = lista[i];
                int j = i - 1;
                // Desplazamos a la derecha los elementos mayores que "actual"
                while (j >= 0 && comparar(lista[j], actual) > 0)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = actual;
            }
        }

        /// <summary>
        /// Calcula en una sola pasada la media de rendimiento y las variedades de mayor y menor rendimiento.
        /// </summary>
        public static void Estadisticas(List<Variedad> lista, out double media, out Variedad mejor, out Variedad peor)
        {
            media = 0;
            mejor = null;
            peor = null;
            if (lista.Count == 0) return;

            double suma = 0;
            mejor = lista[0];
            peor = lista[0];
            foreach (Variedad v in lista)
            {
                suma += v.Rendimiento;
                if (v.Rendimiento > mejor.Rendimiento) mejor = v;
                if (v.Rendimiento < peor.Rendimiento) peor = v;
            }
            media = suma / lista.Count;
        }

        /// <summary>
        /// Factor de corrección del rendimiento según el índice de madurez (0 = verde, 7 = muy madura).
        /// El rendimiento graso aumenta con la maduración hasta estabilizarse.
        /// </summary>
        public static double FactorMadurez(int indice)
        {
            double factor = 0.80 + 0.05 * indice;
            return Math.Min(factor, 1.10);
        }

        /// <summary>
        /// Calcula el aceite obtenido en una molturación.
        /// </summary>
        /// <param name="kilos">Kilos de aceituna.</param>
        /// <param name="rendimiento">Rendimiento graso de la variedad (%).</param>
        /// <param name="indiceMadurez">Índice de madurez (0-7).</param>
        /// <param name="eficienciaExtraccion">Eficiencia del sistema de extracción (0-1).</param>
        /// <param name="kgAceite">Kilos de aceite obtenidos.</param>
        /// <param name="litrosAceite">Litros de aceite obtenidos.</param>
        /// <returns>Rendimiento real aplicado (%).</returns>
        public static double CalcularMolturacion(double kilos, double rendimiento, int indiceMadurez,
            double eficienciaExtraccion, out double kgAceite, out double litrosAceite)
        {
            double rendimientoReal = rendimiento * FactorMadurez(indiceMadurez) * eficienciaExtraccion;
            kgAceite = kilos * rendimientoReal / 100.0;
            litrosAceite = kgAceite / DensidadAceite;
            return rendimientoReal;
        }

        /// <summary>
        /// Devuelve la campaña oleícola (1 de octubre - 30 de septiembre) y el día de campaña de una fecha.
        /// </summary>
        public static string CampanaOleicola(DateTime fecha, out int diaCampana)
        {
            int anioInicio = fecha.Month >= 10 ? fecha.Year : fecha.Year - 1;
            DateTime inicio = new DateTime(anioInicio, 10, 1);
            diaCampana = (fecha.Date - inicio).Days + 1;
            return anioInicio + "/" + (anioInicio + 1);
        }
    }
}

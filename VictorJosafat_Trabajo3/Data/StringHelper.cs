using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace VictorJosafat_Trabajo3.Data
{
    // Clase para formatear texto, como capitalizar nombres y apellidos
    public static class Formateador
    {
        public static string Capitalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return texto;

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(texto.ToLower());
        }
    };

    // Clase para formatear el RUT chileno
    public static class RutFormateador
    {
        public static string FormatearRut(string rut)
        {
            // 1. Limpieza total y máximo de 9 dígitos antes de formatear (8 cuerpo + 1 DV)
            string actual = rut.Replace(".", "").Replace("-", "").Replace(" ", "").ToUpper();

            // Evita procesar si es muy corto
            if (actual.Length < 2) return actual;

            // 2. Extraer DV (último carácter) y Cuerpo (todo lo anterior)
            string dv = actual.Substring(actual.Length - 1);
            string cuerpo = actual.Substring(0, actual.Length - 1);

            // 3. Formatear solo el cuerpo como número
            if (long.TryParse(cuerpo, out long cuerpoNum))
            {
                // Formatea el número con puntos y añade el guion con el DV
                return string.Format("{0:#,##0}-{1}", cuerpoNum, dv).Replace(",", ".");
            }

            // Si no es numérico (por error de tipeo), devolvemos el original limpio
            return actual;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VictorJosafat_Trabajo3.Models
{
    public class Empleado
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public int CodigoDepto { get; set; }
    }
}

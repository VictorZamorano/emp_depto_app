using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using VictorJosafat_Trabajo3.Data;

namespace VictorJosafat_Trabajo3.Models
{
    public class Empleado
    {
        private string _rut = string.Empty;
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;

        public string Rut {
            get => _rut;
            set => _rut = RutFormateador.FormatearRut(value ?? string.Empty);
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = Formateador.Capitalizar(value ?? string.Empty);
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = Formateador.Capitalizar(value ?? string.Empty);
        }   
        public decimal Sueldo { get; set; }
        public int CodigoDepto { get; set; }
    }
}

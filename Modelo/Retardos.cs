using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Retardos
    {
        public int IdRetardo { get; set; }
        public DateTime FechaRetardo { get; set; }
        public double MinutosRetardos { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
        public string Observacion { get; set; }
        public int IdAsistencia { get; set; }
        public int IdSede { get; set; }
    }
}

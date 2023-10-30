using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class HorasExtras
    {
        public int IdHoraExtra { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaHoraExtra { get; set; }
        public double MinutosExtras { get; set; }
        public bool Sincronizacion { get; set; }
        public bool Estado { get; set; }
        public int IdAsistencia { get; set; }
        public int IdSede { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TurnosAplicados
    {
        public int IdTurnoAplicado { get; set; }
        public DateTime FechaAplicada { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
        public string Documento { get; set; }
        public int IdTurno { get; set; }
        public int IdSede { get; set; }
    }
}

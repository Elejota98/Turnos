using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tarjetas
    {
        public string IdTarjeta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
    }
}

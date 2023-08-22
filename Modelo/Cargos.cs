using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cargos
    {
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
    }
}

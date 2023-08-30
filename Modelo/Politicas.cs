using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Politicas
    {
        public int IdPolitica { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
        public int Tiempo { get; set; }
        public int IdSede { get; set; }
    }
}

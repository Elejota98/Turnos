using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Asistencias
    {
        public int IdAsistencia { get; set; }
        public int IdSede { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
        public string Documento { get; set; }
        public int? IdTurnoAplicado { get; set; }
    }
}

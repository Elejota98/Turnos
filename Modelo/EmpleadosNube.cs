using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmpleadosNube
    {
        public string Documento { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public int IdCargo { get; set; }
        public string IdTarjeta { get; set; }
        public int IdSede { get; set; }
        public bool Sincronizacion { get; set; }
    }
}

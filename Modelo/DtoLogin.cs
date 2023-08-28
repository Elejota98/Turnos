using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DtoLogin
    {
        public string Documento { get; set; }
        public string Contraseña { get; set; }
        public string ContraseñaNueva { get; set; }
        public string NombresEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string CargoEmpleado { get; set; }

    }
}

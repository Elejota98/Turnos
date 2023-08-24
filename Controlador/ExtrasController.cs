using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ExtrasController
    {
        public static string RegistrarHorasExtras(HorasExtras horasExtras)
        {
            string rta = "";
            
            RepositorioHorasExtras Datos = new RepositorioHorasExtras();
            rta = Datos.RegistrarHorasExtras(horasExtras);
            if (rta.Equals("OK"))
            {
                rta = "OK";
            }
            else
            {
                return rta;
            }

            return rta;
        }
    }
}

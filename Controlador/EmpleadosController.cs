using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EmpleadosController
    {
        public static string RegistrarEmpleado(Empleados empleados)
        {
            string rta = "";
            RepositorioEmpleados Datos = new RepositorioEmpleados();
            rta = Datos.RegistrarEmpleado(empleados);
            if (rta.Equals("OK"))
            {
                rta = "OK";
            }
            else
            {
                rta = "ERROR";
            }
            return rta;

        }
    }
}

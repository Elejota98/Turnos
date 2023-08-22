using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class SedesController
    {
        public static string RegistrarSedes(Sedes sedes)
        {
            string rta = "";
            RepositorioSedes Datos = new RepositorioSedes();
            rta = Datos.RegistrarSedes(sedes);
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
        public static string ActualizarSede(Sedes sedes)
        {
            string rta = "";
            RepositorioSedes Datos = new RepositorioSedes();
            rta = Datos.ActualizarSede(sedes);
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
        public static DataTable ListarSedes()
        {
            DataTable dt = new DataTable();
            RepositorioSedes Datos = new RepositorioSedes();
            dt = Datos.ListarSedes();
            return dt;

        }
    }
}

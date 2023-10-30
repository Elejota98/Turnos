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
    public class RetardosController
    {
        public static DataTable ListarIdTurnoAplicado (Asistencias asistencias)
        {
            DataTable tabla = new DataTable ();
            RepositorioRetardos Datos = new RepositorioRetardos ();
            return tabla = Datos.ListarIdTurnoAplicado(asistencias);

        }

        public static string RegistrarRetardo(Retardos retardos)
        {
            string rta = "";

            RepositorioRetardos Datos = new RepositorioRetardos();
            rta = Datos.RegistrarRetardo(retardos);
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

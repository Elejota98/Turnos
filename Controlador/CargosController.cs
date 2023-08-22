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
    public class CargosController
    {
        public static string InsertarCargos(Cargos cargos)
        {
            string rta = "";
            RepositorioCargos Datos = new RepositorioCargos();

            rta = Datos.InsertarCargos(cargos);
            if (rta.Equals("OK"))
            {
                return rta;
            }
            else
            {
                return rta = "ERROR";
            }
        }
        public static string ActualizarCargos(Cargos cargos)
        {
            string rta = "";
            RepositorioCargos Datos = new RepositorioCargos();

            rta = Datos.ActualizarCargos(cargos);
            if (rta.Equals("OK"))
            {
                return rta;
            }
            else
            {
                return rta = "ERROR";
            }
        }
    }
}

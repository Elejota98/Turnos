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
    public class NovedadesController
    {
        public static string InsertarNovedades(Novedades novedades)
        {
            string rta = "";
            RepositorioNovedades Datos = new RepositorioNovedades();
            try
            {
                rta = Datos.InsertarNovedades(novedades);
                if (!rta.Equals("OK"))
                {
                    return rta = "ERROR";
                }
                else
                {
                    return rta;
                }

            }
            catch (Exception ex )
            {

                rta = "ERROR";
            }

            return rta;
        }
    }
}

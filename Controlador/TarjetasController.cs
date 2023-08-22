using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TarjetasController
    {
        public static string ObtenerIdTarjeta()
        {

            string rta = "";
            RepositorioTarjetas Datos = new RepositorioTarjetas();

            if (Datos.ConectarLectora())
            {
                if (Datos.DetectarTarjeta())
                {
                    rta = Datos.ObtenerIdTarjeta();
                    if (!rta.Equals("ERROR"))
                    {
                        return rta;
                    }
                    else
                    {
                        rta = "ERROR";
                    }
                }
                else
                {
                    rta = "ERROR";
                }
            }
            else
            {
                rta = "ERROR";
            }

            return rta;


        }
        public static bool PitarTarjeta()
        {
            bool ok = false;

            RepositorioTarjetas Datos = new RepositorioTarjetas();
            try
            {
                ok = Datos.PitarLectora();
                ok = true;
            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;


        }
    }
}

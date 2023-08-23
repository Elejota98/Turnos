using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable VerificarExisteTarjeta(Tarjetas tarjetas)
        {
            DataTable dt = new DataTable();
            RepositorioTarjetas Datos = new RepositorioTarjetas();
            dt = Datos.VerificarExisteTarjeta(tarjetas);
            return dt;
        }

        public static string RegistrarTarjetas(Tarjetas tarjetas)
        {
            string rta = "";
            RepositorioTarjetas Datos = new RepositorioTarjetas();
            
            rta = Datos.InsertarTarjetas(tarjetas);
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

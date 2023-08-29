using Modelo;
using ServiciosSincronizacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorSincronizacion
{


    public class SincronizacionController
    {

        #region Tarjetas 
        public static bool SincronizarTarjetas()
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            RepositorioTarjetas Datos = new RepositorioTarjetas();
            Tarjetas tarjetas = new Tarjetas(); 
            try
            {
                tabla = Datos.ObtenerDatosTarjetas();
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow row in tabla.Rows) 
                    {
                        tarjetas.IdTarjeta = row["IdTarjeta"].ToString();
                        tarjetas.FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]);
                        tarjetas.Estado = true;
                        tarjetas.Sincronizacion = true;
                    }

                    tabla = Datos.ValidarTarjetaSincronizacion(tarjetas);
                    if(tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoTarjetasSincronizacion(tarjetas);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            return ok;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarTarjetasSincronizacion(tarjetas);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTarjetasSincronizacion(tarjetas);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                return ok;

                            }
                        }
                        else
                        {
                            return ok;
                        }
                    }
                }



            }
            catch (Exception ex )
            {

                throw ex;
                ok = false;
            }
            return ok;

        }

        #endregion

    }
}

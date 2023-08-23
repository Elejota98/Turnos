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
    public class AsistenciaController
    {
        public static string RegistrarAsistencia(Asistencias asistencias)
        {
            string rta = "";
            int tiempoRetardo = 0;
            int minutosDiferencia = 0;
            TimeSpan horaIngreso = TimeSpan.Zero;
            DataTable tabla;

            RepositorioAsistencias Datos = new RepositorioAsistencias();
            try
            {
                //Traer la hora de ingreso

                tabla = Datos.ListarDatosTurnosAplicados(asistencias);
                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        if (Convert.ToDateTime(tabla.Rows[i]["FechaAplicada"]).ToString("yyyy-MM-dd") == asistencias.FechaEntrada.ToString("yyyy-MM-dd"))
                        {
                            horaIngreso = (TimeSpan)tabla.Rows[i]["HoraEntrada"];
                        }
                    }
                }
                else
                {
                    return rta = "No encuentran turnos asociados al empleado con documento " + asistencias.Documento + "";
                }


                tabla = PoliticasController.ListarPoliticas();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (tabla.Rows[i]["Nombre"].ToString() == "Retardo")
                    {
                        tiempoRetardo = Convert.ToInt32(tabla.Rows[i]["Tiempo"]);
                    }
                }

                //Calcular el tiempo de ingreso con la hora de ingreso para verificar si tiene retardo
                TimeSpan horaEntradaAsistencias = asistencias.FechaEntrada.TimeOfDay;

               minutosDiferencia = (int)(horaEntradaAsistencias - horaIngreso).TotalMinutes;

                if (minutosDiferencia > tiempoRetardo)
                {
                    //INSERTAR TABLA RETARDO;
                }
                else
                {
                    rta = Datos.RegistrarAsistencia(asistencias);
                    if (rta.Equals("OK"))
                    {
                        rta = "OK";
                    }
                    else
                    {
                        rta = "Error en el momento de registrar la asistencia";
                    }
                }

            }
            catch (Exception ex )
            {

                rta = ex.Message;
            }

            return rta;
        }

        public static DataTable ObtenerDocumentoPorTarjeta(string idTarjeta)
        {
            DataTable dt = new DataTable();
            RepositorioAsistencias Datos = new RepositorioAsistencias();
            return Datos.ObtenerDocumentoPorTarjeta(idTarjeta);
        }
    }
}

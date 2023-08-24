using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AsistenciaController
    {
        public static string RegistrarAsistencia(Asistencias asistencias, int idSede)
        {
            string rta = "";
            int tiempoRetardo = 0;
            int minutosDiferencia = 0;
            string idTarjeta = string.Empty;
            TimeSpan horaIngreso = TimeSpan.Zero;
            DataTable tabla;

            RepositorioAsistencias Datos = new RepositorioAsistencias();
            try
            {
                idTarjeta = TarjetasController.ObtenerIdTarjeta();

                tabla = AsistenciaController.ObtenerDocumentoPorTarjeta(idTarjeta);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstDatos in tabla.Rows)
                    {
                        asistencias.Documento = lstDatos["Documento"].ToString();
                    }
                }
                else
                {
                    return rta = "La Tarjeta no pertenece a ningún empleado";
                }


                //Traer la hora de ingreso

                tabla = Datos.ListarDatosTurnosAplicados(asistencias, idSede);
                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {

                        if (Convert.ToDateTime(tabla.Rows[i]["FechaAplicada"]).ToString("yyyy-MM-dd") == asistencias.FechaEntrada.ToString("yyyy-MM-dd"))
                        {
                            horaIngreso = (TimeSpan)tabla.Rows[i]["HoraEntrada"];
                            asistencias.IdTurnoAplicado = Convert.ToInt32(tabla.Rows[i]["IdTurnoAplicado"]);

                        }
                        else
                        {
                            return rta = "El empleado no tiene turnos asignado para el día de hoy";
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
                    if (tabla.Rows[i]["Nombre"].ToString() == "HoraExtra")
                    {
                        tiempoRetardo = Convert.ToInt32(tabla.Rows[i]["Tiempo"]);
                    }
                }

                //Calcular el tiempo de ingreso con la hora de ingreso para verificar si tiene retardo
                TimeSpan horaEntradaAsistencias = asistencias.FechaEntrada.TimeOfDay;

                minutosDiferencia = (int)(horaEntradaAsistencias - horaIngreso).TotalMinutes;

                if (minutosDiferencia > tiempoRetardo)
                {
                    //Registrar la asistencia 
                    rta = Datos.RegistrarAsistencia(asistencias);
                    if (rta.Equals("OK"))
                    {
                        tabla = RetardosController.ListarIdTurnoAplicado(asistencias, idSede);

                        if (tabla.Rows.Count > 0)
                        {
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                asistencias.IdAsistencia = Convert.ToInt32(tabla.Rows[i]["IdAsitencia"]);
                            }

                            // INSERTAR EN LA TABLA RETARDOS
                            Retardos retardos = new Retardos() {
                                FechaRetardo = DateTime.Now,
                                MinutosRetardos = Convert.ToDouble(minutosDiferencia),
                                IdAsistencia = asistencias.IdAsistencia

                            };

                            rta = RetardosController.RegistrarRetardo(retardos);

                            if (rta.Equals("OK"))
                            {
                                TimeSpan minutosRetardo = TimeSpan.FromMinutes(retardos.MinutosRetardos);
                                string tiempoRetardoFormateado = retardos.MinutosRetardos.ToString(@"hh\:mm");
                                return rta = "¡Registro exitoso! \n Hora de entrada: " + asistencias.FechaEntrada + "" +
                            " \n Tiempo de retardo: " + minutosRetardo + "";

                            }
                            else
                            {
                                rta = "ERROR";
                            }
                        }

                    }
                    else
                    {
                        rta = "ERROR";
                    }
                }
                else
                {
                    asistencias.FechaEntrada = asistencias.FechaEntrada.Date + horaIngreso;

                    rta = Datos.RegistrarAsistencia(asistencias);
                    if (rta.Equals("OK"))
                    {
                        return rta = "¡Registro exitoso! \n Hora de entrada: " + asistencias.FechaEntrada + "" +
                            " \n Tiempo de retardo: " + 0 + "";
                    }
                    else
                    {
                        rta = "ERROR";
                    }
                }

            }
            catch (Exception ex)
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
        public static string ActualizarSalidaAsistencia(Asistencias asistencias, int idSede)
        {
            string rta = "";
            int tiempoExtra = 0;
            int minutosDiferencia = 0;
            string idTarjeta = string.Empty;
            TimeSpan horaIngreso = TimeSpan.Zero;
            TimeSpan horaSalida = TimeSpan.Zero;
            DataTable tabla;
            RepositorioAsistencias Datos = new RepositorioAsistencias();
            try
            {
                idTarjeta = TarjetasController.ObtenerIdTarjeta();

                tabla = AsistenciaController.ObtenerDocumentoPorTarjeta(idTarjeta);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstDatos in tabla.Rows)
                    {
                        asistencias.Documento = lstDatos["Documento"].ToString();
                    }
                }
                else
                {
                    return rta = "La Tarjeta no pertenece a ningún empleado";
                }
                tabla = Datos.ValidarFechaSalida(asistencias, idSede);
                if (tabla.Rows.Count > 0)
                {

                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        horaIngreso = (TimeSpan)tabla.Rows[i]["HoraEntrada"];
                        horaSalida = (TimeSpan)tabla.Rows[i]["HoraSalida"];
                        asistencias.IdTurnoAplicado = Convert.ToInt32(tabla.Rows[i]["IdTurnoAplicado"]);
                        asistencias.IdAsistencia = Convert.ToInt32(tabla.Rows[i]["IdAsitencia"]);
                        
                    }

                    tabla = PoliticasController.ListarPoliticas();

                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        if (tabla.Rows[i]["Nombre"].ToString() == "HoraExtra")
                        {
                            tiempoExtra = Convert.ToInt32(tabla.Rows[i]["Tiempo"]);
                        }
                    }


                    TimeSpan horaEntradaAsistencias = asistencias.FechaSalida.TimeOfDay;

                    minutosDiferencia = (int)(horaEntradaAsistencias - horaSalida).TotalMinutes;

                    if (minutosDiferencia >= tiempoExtra)
                    {
                        //registrar hora extras

                        rta = Datos.ActualizaSalidaAsistencia(asistencias);
                        if (rta.Equals("OK"))
                        {
                            HorasExtras horasExtras = new HorasExtras()
                            {
                                FechaHoraExtra = DateTime.Now,
                                MinutosExtras = minutosDiferencia,
                                IdAsistencia = asistencias.IdAsistencia
                                
                            };


                            rta = ExtrasController.RegistrarHorasExtras(horasExtras);

                            if (rta.Equals("OK"))
                            {
                                TimeSpan minutosExtra = TimeSpan.FromMinutes(horasExtras.MinutosExtras);
                                string tiempoRetardoFormateado = horasExtras.MinutosExtras.ToString(@"hh\:mm");
                                return rta = "¡Registro exitoso! \n Hora de salida: " + asistencias.FechaSalida + "" +
                            " \n Tiempo extra: " + minutosExtra + "";

                            }
                            else
                            {
                                rta = "ERROR";
                            }

                        }
                    }
                    else
                    {
                        asistencias.FechaSalida = DateTime.Now;

                        rta = Datos.ActualizaSalidaAsistencia(asistencias);
                        if (rta.Equals("OK"))
                        {
                            return rta = "¡Registro exitoso! \n Hora de dalida: " + asistencias.FechaEntrada + "" +
                                " \n Tiempo extra: " + 0 + "";
                        }
                        else
                        {
                            rta = "ERROR";
                        }
                    }

                }
                
                else
                {
                    return rta = "El empleado no tiene salidas pendientes para esta sede";
                }
            }


            catch (Exception ex)
            {

                rta = ex.Message;
            }

            return rta;

        }


    }
}

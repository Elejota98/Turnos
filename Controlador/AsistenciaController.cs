﻿using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AsistenciaController
    {
        public static string RegistrarAsistencia(Asistencias asistencias)
        {
            Politicas politicas = new Politicas();
            Retardos retardo = new Retardos();
            string rta = "";
            int tiempoRetardo = 0;
            int minutosDiferencia = 0;
            string idTarjeta = string.Empty;
            TimeSpan horaSalida = TimeSpan.Zero;
            TimeSpan horaIngreso = TimeSpan.Zero;
            DataTable tabla;
            bool fechaEncontrada = false;

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

                tabla = Datos.ListarDatosTurnosAplicados(asistencias);
                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {

                        if (Convert.ToDateTime(tabla.Rows[i]["FechaAplicada"]).ToString("yyyy-MM-dd") == asistencias.FechaEntrada.ToString("yyyy-MM-dd"))
                        {
                            fechaEncontrada = true;
                            horaIngreso = (TimeSpan)tabla.Rows[i]["HoraEntrada"];
                            asistencias.IdTurnoAplicado = Convert.ToInt32(tabla.Rows[i]["IdTurnoAplicado"]);

                        }
                    }

                    if(fechaEncontrada)
                    {
                        politicas.IdSede = asistencias.IdSede;
                        tabla = PoliticasController.ListarPoliticas(politicas);

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
                                tabla = RetardosController.ListarIdTurnoAplicado(asistencias);

                                if (tabla.Rows.Count > 0)
                                {
                                    for (int i = 0; i < tabla.Rows.Count; i++)
                                    {
                                        asistencias.IdAsistencia = Convert.ToInt32(tabla.Rows[i]["IdAsistencia"]);
                                    }

                                    // INSERTAR EN LA TABLA RETARDOS
                                    Retardos retardos = new Retardos()
                                    {
                                        FechaRetardo = DateTime.Now,
                                        MinutosRetardos = Convert.ToDouble(minutosDiferencia),
                                        IdAsistencia = asistencias.IdAsistencia,
                                        IdSede = asistencias.IdSede
                                        

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
                    else
                    {

                        //INSERTAR IDTURNOAPLICADO NULL

                        rta = Datos.RegistrarAsistenciaSinTurnoAsignado(asistencias);
                        if (rta.Equals("OK"))
                        {
                            return rta = "¡Registro sin turno asignado exitoso! \n Hora de entrada: " + asistencias.FechaEntrada + "";

                        }
                        else
                        {
                            return rta = "ERROR";
                        }

                    }

                }
                else
                {

                    //INSERTAR IDTURNOAPLICADO NULL

                    rta = Datos.RegistrarAsistenciaSinTurnoAsignado(asistencias);
                    if (rta.Equals("OK"))
                    {
                        return rta = "¡Registro sin turno asignado exitoso! \n Hora de entrada: " + asistencias.FechaEntrada + "";

                    }
                    else
                    {
                        return rta = "ERROR";
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
        public static string ActualizarSalidaAsistencia(Asistencias asistencias, string documentoLogin)
        {
            Politicas politicas = new Politicas();
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
                    if (asistencias.Documento == documentoLogin)
                    {
                        tabla = Datos.ValidarFechaSalida(asistencias);
                        if (tabla.Rows.Count > 0)
                        {

                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                horaIngreso = (TimeSpan)tabla.Rows[i]["HoraEntrada"];
                                horaSalida = (TimeSpan)tabla.Rows[i]["HoraSalida"];
                                asistencias.IdTurnoAplicado = Convert.ToInt32(tabla.Rows[i]["IdTurnoAplicado"]);
                                asistencias.IdAsistencia = Convert.ToInt32(tabla.Rows[i]["IdAsistencia"]);

                            }





                            politicas.IdSede = asistencias.IdSede;

                            tabla = PoliticasController.ListarPoliticas(politicas);

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
                                        IdAsistencia = asistencias.IdAsistencia,
                                        IdSede = asistencias.IdSede

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
                                    return rta = "¡Registro exitoso! \n Hora de salida: " + asistencias.FechaSalida + "" +
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

                            //VALIDAR SALIDAS PENDIENTES IDTURNOAPLICADO NULL

                            tabla = Datos.ValidarFechSalidaSinTurnoAplicado(asistencias);
                            if (tabla.Rows.Count > 0)
                            {
                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    asistencias.IdAsistencia = Convert.ToInt32(tabla.Rows[i]["IdAsistencia"]);
                                }

                                rta = Datos.ActualizarSalidaSinTurnoAplicado(asistencias);

                                if (rta.Equals("OK"))
                                {
                                    return rta = "¡Registro sin turno aplicado exitoso! \n Hora de salida: " + asistencias.FechaSalida + "";
                                }
                                else
                                {
                                    return rta = "ERROR";
                                }
                            }
                            else
                            {
                                return rta = "SIN SALIDA";
                            }

                        }
                    }
                    else
                    {
                        return rta = "La tarjeta no pertenece al usuario que inició sesión";
                    }
                }
                else
                {
                    return rta = "La Tarjeta no pertenece a ningún empleado";
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

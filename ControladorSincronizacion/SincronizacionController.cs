using Modelo;
using ServiciosSincronizacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControladorSincronizacion
{


    public class SincronizacionController
    {


        #region Subida


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
                    if (tabla.Rows.Count > 0)
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
            catch (Exception ex)
            {

                throw ex;
                ok = false;
            }
            return ok;

        }

        #endregion

        #region Sedes
        public static bool SincronziacionSedes(Sedes sedes)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioSedes Datos = new RepositorioSedes();
            try
            {
                tabla = Datos.ObtenerDatosSedes(sedes);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstSedes in tabla.Rows)
                    {
                        sedes.IdSede = Convert.ToInt32(lstSedes["IdSede"]);
                        sedes.NombreSede = lstSedes["NombreSede"].ToString();
                        sedes.DireccionSede = lstSedes["DireccionSede"].ToString();
                        sedes.FechaCreacion = Convert.ToDateTime(lstSedes["FechaCreacion"].ToString());
                        sedes.Estado = Convert.ToBoolean(lstSedes["Estado"]);
                        sedes.Sincronizacion = true;

                    }

                    tabla = Datos.ValidarSedeSincronizacion(sedes);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoSedesSincronizacion(sedes);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarSedesSincronizacion(sedes);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoSedesSincronizacion(sedes);
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
            catch (Exception ex)
            {

                throw ex;
                ok = false;
            }
            return ok;
        }

        #endregion

        #region Empleados

        public static bool SincronizacionEmpleados(Empleados empleados)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioEmpleados Datos = new RepositorioEmpleados();
            {
                try
                {
                    tabla = Datos.ObtenerDatosEmpleados(empleados);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstEmpleados in tabla.Rows)
                        {
                            empleados.Documento = lstEmpleados["Documento"].ToString();
                            empleados.NombreEmpleado = lstEmpleados["NombreEmpleado"].ToString();
                            empleados.ApellidoEmpleado = lstEmpleados["ApellidoEmpleado"].ToString();
                            empleados.TelefonoEmpleado = lstEmpleados["TelefonoEmpleado"].ToString();
                            empleados.Contraseña = lstEmpleados["ContraseñaEmpleado"].ToString();
                            empleados.FechaCreacion = Convert.ToDateTime(lstEmpleados["FechaCreacion"].ToString());
                            empleados.Estado = Convert.ToBoolean(lstEmpleados["Estado"].ToString());
                            empleados.Sincronizacion = true;
                            empleados.IdCargo = Convert.ToInt32(lstEmpleados["IdCargo"]);
                            empleados.IdTarjeta = lstEmpleados["IdTarjeta"].ToString();
                            empleados.IdSede = Convert.ToInt32(lstEmpleados["IdSede"]);

                        }


                        tabla = Datos.ValidarEmpleadoSincronizacion(empleados);
                        if (tabla.Rows.Count > 0)
                        {

                            rta = Datos.ActualizarDatosEmpleado(empleados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoEmpleadosSincronizacion(empleados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }

                        }
                        else
                        {
                            rta = Datos.RegistrarEmpleadoSincronizacion(empleados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoEmpleadosSincronizacion(empleados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }

                    }

                }
                catch (Exception ex)
                {

                    return ok;
                }
                return ok;
            }

        }

        #endregion

        #region Turnos

        public static bool SincronizacionTurnos(Turnos turnos)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioTurnos Datos = new RepositorioTurnos();
            try
            {
                tabla = Datos.ObtenerDatosSincronizacionTurnos(turnos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstTurnos in tabla.Rows)
                    {

                        turnos.IdTurno = Convert.ToInt32(lstTurnos["IdTurno"]);
                        turnos.Descripcion = lstTurnos["Descripcion"].ToString();
                        turnos.HoraEntrada = TimeSpan.Parse(lstTurnos["HoraEntrada"].ToString());
                        turnos.HoraSalida = TimeSpan.Parse(lstTurnos["HoraSalida"].ToString());
                        turnos.Estado = Convert.ToBoolean(lstTurnos["Estado"]);
                        turnos.Lunes = Convert.ToBoolean(lstTurnos["Lunes"]);
                        turnos.Martes = Convert.ToBoolean(lstTurnos["Martes"]);
                        turnos.Miercoles = Convert.ToBoolean(lstTurnos["Miercoles"]);
                        turnos.Jueves = Convert.ToBoolean(lstTurnos["Jueves"]);
                        turnos.Viernes = Convert.ToBoolean(lstTurnos["Viernes"]);
                        turnos.Sabado = Convert.ToBoolean(lstTurnos["Sabado"]);
                        turnos.Domingo = Convert.ToBoolean(lstTurnos["Domingo"]);
                        turnos.Sincronizacion = Convert.ToBoolean(lstTurnos["Sincronizacion"]);
                        turnos.FechaCreacion = Convert.ToDateTime(lstTurnos["FechaCreacion"]);
                        turnos.IdSede = Convert.ToInt32(lstTurnos["IdSede"]);


                    }

                    tabla = Datos.ValidarTurnoSincronizacion(turnos);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizaDatosTurnosSincronizacion(turnos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosSincronizacion(turnos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarTurnosSincronizacion(turnos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosSincronizacion(turnos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }


                }

            }
            catch (Exception ex)
            {

                return ok;
            }
            return ok;

        }

        #endregion

        #region TurnosAplicados

        public static bool SincronizacionTurnosAplicados(TurnosAplicados turnosAplicados)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            TurnosAplicadosNube turnosAplicadosNube = new TurnosAplicadosNube();
            RepositorioTurnosAplicados Datos = new RepositorioTurnosAplicados();
            try
            {

                tabla = Datos.ObtenerTurnosAplicadosSincronizacion(turnosAplicados);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstTurnosAplicados in tabla.Rows)
                    {
                        turnosAplicados.IdTurnoAplicado = Convert.ToInt32(lstTurnosAplicados["IdTurnoAplicado"]);
                        turnosAplicados.FechaAplicada = Convert.ToDateTime(lstTurnosAplicados["FechaAplicada"]);
                        turnosAplicados.FechaCreacion = Convert.ToDateTime(lstTurnosAplicados["FechaCreacion"].ToString());
                        turnosAplicados.Estado = Convert.ToBoolean(lstTurnosAplicados["Estado"]);
                        turnosAplicados.Sincronizacion = true;
                        turnosAplicados.Documento = lstTurnosAplicados["Documento"].ToString();
                        turnosAplicados.IdTurno = Convert.ToInt32(lstTurnosAplicados["IdTurno"]);
                        turnosAplicados.IdSede = Convert.ToInt32(lstTurnosAplicados["IdSede"]);

                    }


                    tabla = Datos.ValidarTurnosAplicadosSincronizacion(turnosAplicados);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstTurnosAplicados in tabla.Rows)
                        {
                            turnosAplicadosNube.IdTurnoAplicado = Convert.ToInt32(lstTurnosAplicados["IdTurnoAplicado"]);
                            turnosAplicadosNube.FechaAplicada = Convert.ToDateTime(lstTurnosAplicados["FechaAplicada"]);
                            turnosAplicadosNube.FechaCreacion = Convert.ToDateTime(lstTurnosAplicados["FechaCreacion"]);
                            turnosAplicadosNube.Estado = Convert.ToBoolean(lstTurnosAplicados["Estado"]);
                            turnosAplicadosNube.Sincronizacion = true;
                            turnosAplicadosNube.Documento = lstTurnosAplicados["Documento"].ToString();
                            turnosAplicadosNube.IdTurno = Convert.ToInt32(lstTurnosAplicados["IdTurno"]);
                            turnosAplicadosNube.IdSede = Convert.ToInt32(lstTurnosAplicados["IdSede"]);

                        }

                        if (turnosAplicadosNube.FechaCreacion != turnosAplicados.FechaCreacion || turnosAplicadosNube.Documento != turnosAplicados.Documento || turnosAplicadosNube.IdSede != turnosAplicados.IdSede || turnosAplicados.IdTurno != turnosAplicadosNube.IdTurno)
                        {
                            rta = Datos.ActualizaDatosTurnosAplicadosSincronizacion(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacion(turnosAplicados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacion(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarTurnosAplicadosSincronizacion(turnosAplicados);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacion(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }


                    }

                }


            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;


        }



        #endregion

        #region Asistencia

        public static bool SincronizacionAsistencias(Asistencias asistencias)
        {
            AsistenciasNube asistenciasNube = new AsistenciasNube();
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioAsistencias Datos = new RepositorioAsistencias();
            try
            {
                tabla = Datos.ObtenerAsistenciasSincronizacion(asistencias);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstAsistencias in tabla.Rows)
                    {
                        asistencias.IdAsistencia = Convert.ToInt32(lstAsistencias["IdAsistencia"]);
                        asistencias.FechaEntrada = Convert.ToDateTime(lstAsistencias["FechaEntrada"]);
                        asistencias.FechaSalida = Convert.ToDateTime(lstAsistencias["FechaSalida"]);
                        asistencias.Estado = Convert.ToBoolean(lstAsistencias["Estado"]);
                        asistencias.Sincronizacion = Convert.ToBoolean(lstAsistencias["Sincronizacion"]);
                        asistencias.Documento = lstAsistencias["Documento"].ToString();
                        asistencias.IdTurnoAplicado = lstAsistencias["IdTurnoAplicado"] != DBNull.Value ? Convert.ToInt32(lstAsistencias["IdTurnoAplicado"]) : (int?)null;
                        asistencias.IdSede = Convert.ToInt32(lstAsistencias["IdSede"]);

                    }

                    tabla = Datos.ValidarAsistenciaSincronizacion(asistencias);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstAsistencias in tabla.Rows)
                        {
                            asistenciasNube.IdAsistencia = Convert.ToInt32(lstAsistencias["IdAsistencia"]);
                            asistenciasNube.FechaEntrada = Convert.ToDateTime(lstAsistencias["FechaEntrada"]);
                            asistenciasNube.FechaSalida = Convert.ToDateTime(lstAsistencias["FechaSalida"]);
                            asistenciasNube.Estado = Convert.ToBoolean(lstAsistencias["Estado"]);
                            asistenciasNube.Sincronizacion = Convert.ToBoolean(lstAsistencias["Sincronizacion"]);
                            asistenciasNube.Documento = lstAsistencias["Documento"].ToString();
                            asistenciasNube.IdTurnoAplicado = lstAsistencias["IdTurnoAplicado"] != DBNull.Value ? Convert.ToInt32(lstAsistencias["IdTurnoAplicado"]) : (int?)null;
                            asistenciasNube.IdSede = Convert.ToInt32(lstAsistencias["IdSede"]);

                        }

                        if (asistencias.Documento == asistenciasNube.Documento)
                        {
                            if (asistencias.IdSede == asistenciasNube.IdSede)
                            {
                                if (asistencias.FechaEntrada == asistenciasNube.FechaEntrada)
                                {
                                    if (asistencias.FechaSalida == asistenciasNube.FechaSalida)
                                    {

                                        rta = Datos.ActualizarEstadoAsistenciaSincronizacion(asistencias);
                                        if (rta.Equals("OK"))
                                        {
                                            ok = true;
                                        }
                                        else
                                        {
                                            ok = false;
                                        }
                                    }
                                    else
                                    {

                                        rta = Datos.ActualizaAsistenciaSalidaSincronizacion(asistencias);
                                        if (rta.Equals("OK"))
                                        {
                                            rta = Datos.ActualizarEstadoAsistenciaSincronizacion(asistencias);
                                            if (rta.Equals("OK"))
                                            {
                                                ok = true;
                                            }
                                            else
                                            {
                                                ok = false;
                                            }
                                        }
                                        else
                                        {
                                            ok = false;
                                        }

                                    }
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        //registrar asistencia 
                        rta = Datos.RegistrarAsistenciaSincronizacion(asistencias);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoAsistenciaSincronizacion(asistencias);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }




                }

            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;
        }

        #endregion

        #region Retardos 

        public static bool SincronizacionRetardos(Retardos retardos)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioRetardos Datos = new RepositorioRetardos();
            try
            {
                tabla = Datos.ObtenerRetardosSincronizacion(retardos);
                if(tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstRetardos in tabla.Rows)
                    {
                        retardos.IdRetardo = Convert.ToInt32(lstRetardos["IdRetardo"]);
                        retardos.FechaRetardo = Convert.ToDateTime(lstRetardos["FechaRetardo"]);
                        TimeSpan tiempoRetardos = (TimeSpan)lstRetardos["MinutosRegistrados"];
                        double minutosTotales = tiempoRetardos.TotalMinutes;
                        retardos.MinutosRetardos = minutosTotales;
                        retardos.Estado = Convert.ToBoolean(lstRetardos["Estado"]);
                        retardos.Sincronizacion = Convert.ToBoolean(lstRetardos["Sincronizacion"]);
                        retardos.Observacion = lstRetardos["Observacion"].ToString();
                        retardos.IdAsistencia = Convert.ToInt32(lstRetardos["IdAsistencia"]);
                        retardos.IdSede = Convert.ToInt32(lstRetardos["IdSede"]);

                    }

                    tabla = Datos.ValidarRetardoSincronizacion(retardos);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoRetardosSincronizacion(retardos);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }

                    }
                    else
                    {
                        rta = Datos.RegistrarRetardosSincronizacion(retardos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoRetardosSincronizacion(retardos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            catch (Exception ex )
            {

                ok = false;
            }

            return ok;

        }


        #endregion

        #region HorasExtras
        public static bool SincronizacionHorasExtras(HorasExtras horasExtras)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioExtras Datos = new RepositorioExtras();
            try
            {
                tabla = Datos.ObtenerExtrasSincronizacion(horasExtras);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstExtras in tabla.Rows)
                    {
                        horasExtras.IdHoraExtra = Convert.ToInt32(lstExtras["IdHoraExtra"]);
                        horasExtras.Observacion = lstExtras["Observacion"].ToString();
                        horasExtras.FechaHoraExtra = Convert.ToDateTime(lstExtras["FechaHoraExtra"]);
                        TimeSpan tiempoRetardos = (TimeSpan)lstExtras["MinutosExtras"];
                        double minutosTotales = tiempoRetardos.TotalMinutes;
                        horasExtras.MinutosExtras = minutosTotales;
                        horasExtras.Sincronizacion = Convert.ToBoolean(lstExtras["Sincronizacion"]);
                        horasExtras.Estado = Convert.ToBoolean(lstExtras["Estado"]);
                        horasExtras.IdAsistencia = Convert.ToInt32(lstExtras["IdAsistencia"]);
                        horasExtras.IdSede = Convert.ToInt32(lstExtras["IdSede"]);

                    }

                    tabla = Datos.ValidarExtrasSincronizacion(horasExtras);
                    if(tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoExtraSincronizacion(horasExtras);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarHorasExtrasSincronizacion(horasExtras);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoExtraSincronizacion(horasExtras);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            catch (Exception ex )
            {

                ok = false;
            }

            return ok;
                 
        }

        #endregion


        #endregion

        #region Bajada

        #region Sedes
        public static bool SincronziacionSedesBajada(Sedes sedes)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioSedes Datos = new RepositorioSedes();
            try
            {
                tabla = Datos.ObtenerDatosSedesBajada(sedes);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstSedes in tabla.Rows)
                    {
                        sedes.IdSede = Convert.ToInt32(lstSedes["IdSede"]);
                        sedes.NombreSede = lstSedes["NombreSede"].ToString();
                        sedes.DireccionSede = lstSedes["DireccionSede"].ToString();
                        sedes.FechaCreacion = Convert.ToDateTime(lstSedes["FechaCreacion"].ToString());
                        sedes.Estado = Convert.ToBoolean(lstSedes["Estado"]);
                        sedes.Sincronizacion = true;

                    }

                    tabla = Datos.ValidarSedeSincronizacionBajada(sedes);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoSedesSincronizacionBajada(sedes);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarSedesSincronizacionBajada(sedes);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoSedesSincronizacionBajada(sedes);
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
            catch (Exception ex)
            {

                throw ex;
                ok = false;
            }
            return ok;
        }

        #endregion

        #region Empleados 

        public static bool SincronizacionEmpleadosBajada(Empleados empleados)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioEmpleados Datos = new RepositorioEmpleados();
            {
                try
                {
                    tabla = Datos.ObtenerDatosEmpleadosBjada(empleados);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstEmpleados in tabla.Rows)
                        {
                            empleados.Documento = lstEmpleados["Documento"].ToString();
                            empleados.NombreEmpleado = lstEmpleados["NombreEmpleado"].ToString();
                            empleados.ApellidoEmpleado = lstEmpleados["ApellidoEmpleado"].ToString();
                            empleados.TelefonoEmpleado = lstEmpleados["TelefonoEmpleado"].ToString();
                            empleados.Contraseña = lstEmpleados["ContraseñaEmpleado"].ToString();
                            empleados.FechaCreacion = Convert.ToDateTime(lstEmpleados["FechaCreacion"].ToString());
                            empleados.Estado = Convert.ToBoolean(lstEmpleados["Estado"].ToString());
                            empleados.Sincronizacion = true;
                            empleados.IdCargo = Convert.ToInt32(lstEmpleados["IdCargo"]);
                            empleados.IdTarjeta = lstEmpleados["IdTarjeta"].ToString();
                            empleados.IdSede = Convert.ToInt32(lstEmpleados["IdSede"]);

                        }


                        tabla = Datos.ValidarEmpleadoSincronizacionBajada(empleados);
                        if (tabla.Rows.Count > 0)
                        {

                            rta = Datos.ActualizarDatosEmpleadoBajada(empleados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoEmpleadosSincronizacionBajada(empleados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }

                        }
                        else
                        {
                            rta = Datos.RegistrarEmpleadoSincronizacionBajada(empleados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoEmpleadosSincronizacionBajada(empleados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }

                    }

                }
                catch (Exception ex)
                {

                    return ok;
                }
                return ok;
            }

        }


        #endregion

        #region Turnos

        public static bool SincronizacionTurnosBajada(Turnos turnos)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioTurnos Datos = new RepositorioTurnos();
            try
            {
                tabla = Datos.ObtenerDatosSincronizacionTurnosBajada(turnos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstTurnos in tabla.Rows)
                    {

                        turnos.IdTurno = Convert.ToInt32(lstTurnos["IdTurno"]);
                        turnos.Descripcion = lstTurnos["Descripcion"].ToString();
                        turnos.HoraEntrada = TimeSpan.Parse(lstTurnos["HoraEntrada"].ToString());
                        turnos.HoraSalida = TimeSpan.Parse(lstTurnos["HoraSalida"].ToString());
                        turnos.Estado = Convert.ToBoolean(lstTurnos["Estado"]);
                        turnos.Lunes = Convert.ToBoolean(lstTurnos["Lunes"]);
                        turnos.Martes = Convert.ToBoolean(lstTurnos["Martes"]);
                        turnos.Miercoles = Convert.ToBoolean(lstTurnos["Miercoles"]);
                        turnos.Jueves = Convert.ToBoolean(lstTurnos["Jueves"]);
                        turnos.Viernes = Convert.ToBoolean(lstTurnos["Viernes"]);
                        turnos.Sabado = Convert.ToBoolean(lstTurnos["Sabado"]);
                        turnos.Domingo = Convert.ToBoolean(lstTurnos["Domingo"]);
                        turnos.Sincronizacion = Convert.ToBoolean(lstTurnos["Sincronizacion"]);
                        turnos.FechaCreacion = Convert.ToDateTime(lstTurnos["FechaCreacion"]);
                        turnos.IdSede = Convert.ToInt32(lstTurnos["IdSede"]);


                    }

                    tabla = Datos.ValidarTurnoSincronizacionBajada(turnos);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizaDatosTurnosSincronizacionBajada(turnos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosSincronizacionBajada(turnos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarTurnosSincronizacionBajada(turnos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosSincronizacionBajada(turnos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }


                }

            }
            catch (Exception ex)
            {

                return ok;
            }
            return ok;

        }

        #endregion

        #region TurnosAplicados
        public static bool SincronizacionTurnosAplicadosBajada(TurnosAplicados turnosAplicados)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            TurnosAplicadosNube turnosAplicadosNube = new TurnosAplicadosNube();
            RepositorioTurnosAplicados Datos = new RepositorioTurnosAplicados();
            try
            {

                tabla = Datos.ObtenerTurnosAplicadosSincronizacionBajada(turnosAplicados);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstTurnosAplicados in tabla.Rows)
                    {
                        turnosAplicados.IdTurnoAplicado = Convert.ToInt32(lstTurnosAplicados["IdTurnoAplicado"]);
                        turnosAplicados.FechaAplicada = Convert.ToDateTime(lstTurnosAplicados["FechaAplicada"]);
                        turnosAplicados.FechaCreacion = Convert.ToDateTime(lstTurnosAplicados["FechaCreacion"].ToString());
                        turnosAplicados.Estado = Convert.ToBoolean(lstTurnosAplicados["Estado"]);
                        turnosAplicados.Sincronizacion = true;
                        turnosAplicados.Documento = lstTurnosAplicados["Documento"].ToString();
                        turnosAplicados.IdTurno = Convert.ToInt32(lstTurnosAplicados["IdTurno"]);
                        turnosAplicados.IdSede = Convert.ToInt32(lstTurnosAplicados["IdSede"]);

                    }


                    tabla = Datos.ValidarTurnosAplicadosSincronizacionBajada(turnosAplicados);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstTurnosAplicados in tabla.Rows)
                        {
                            turnosAplicadosNube.IdTurnoAplicado = Convert.ToInt32(lstTurnosAplicados["IdTurnoAplicado"]);
                            turnosAplicadosNube.FechaAplicada = Convert.ToDateTime(lstTurnosAplicados["FechaAplicada"]);
                            turnosAplicadosNube.FechaCreacion = Convert.ToDateTime(lstTurnosAplicados["FechaCreacion"]);
                            turnosAplicadosNube.Estado = Convert.ToBoolean(lstTurnosAplicados["Estado"]);
                            turnosAplicadosNube.Sincronizacion = true;
                            turnosAplicadosNube.Documento = lstTurnosAplicados["Documento"].ToString();
                            turnosAplicadosNube.IdTurno = Convert.ToInt32(lstTurnosAplicados["IdTurno"]);
                            turnosAplicadosNube.IdSede = Convert.ToInt32(lstTurnosAplicados["IdSede"]);

                        }

                        if (turnosAplicadosNube.FechaCreacion != turnosAplicados.FechaCreacion || turnosAplicadosNube.Documento != turnosAplicados.Documento || turnosAplicadosNube.IdSede != turnosAplicados.IdSede || turnosAplicados.IdTurno != turnosAplicadosNube.IdTurno)
                        {
                            rta = Datos.ActualizaDatosTurnosAplicadosSincronizacionBajada(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacionBajada(turnosAplicados);
                                if (rta.Equals("OK"))
                                {
                                    ok = true;
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacionBajada(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarTurnosAplicadosSincronizacionBajada(turnosAplicados);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoTurnosAplicadosSincronizacionBajada(turnosAplicados);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }


                    }

                }


            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;


        }

        #endregion

        #region Asistencia

        public static bool SincronizacionAsistenciasBajada(Asistencias asistencias)
        {
            AsistenciasNube asistenciasNube = new AsistenciasNube();
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioAsistencias Datos = new RepositorioAsistencias();
            try
            {
                tabla = Datos.ObtenerAsistenciasSincronizacionBajada(asistencias);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstAsistencias in tabla.Rows)
                    {
                        asistencias.IdAsistencia = Convert.ToInt32(lstAsistencias["IdAsistencia"]);
                        asistencias.FechaEntrada = Convert.ToDateTime(lstAsistencias["FechaEntrada"]);
                        asistencias.FechaSalida = Convert.ToDateTime(lstAsistencias["FechaSalida"]);
                        asistencias.Estado = Convert.ToBoolean(lstAsistencias["Estado"]);
                        asistencias.Sincronizacion = Convert.ToBoolean(lstAsistencias["Sincronizacion"]);
                        asistencias.Documento = lstAsistencias["Documento"].ToString();
                        asistencias.IdTurnoAplicado = lstAsistencias["IdTurnoAplicado"] != DBNull.Value ? Convert.ToInt32(lstAsistencias["IdTurnoAplicado"]) : (int?)null;
                        asistencias.IdSede = Convert.ToInt32(lstAsistencias["IdSede"]);

                    }

                    tabla = Datos.ValidarAsistenciaSincronizacionBajada(asistencias);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow lstAsistencias in tabla.Rows)
                        {
                            asistenciasNube.IdAsistencia = Convert.ToInt32(lstAsistencias["IdAsistencia"]);
                            asistenciasNube.FechaEntrada = Convert.ToDateTime(lstAsistencias["FechaEntrada"]);
                            asistenciasNube.FechaSalida = Convert.ToDateTime(lstAsistencias["FechaSalida"]);
                            asistenciasNube.Estado = Convert.ToBoolean(lstAsistencias["Estado"]);
                            asistenciasNube.Sincronizacion = Convert.ToBoolean(lstAsistencias["Sincronizacion"]);
                            asistenciasNube.Documento = lstAsistencias["Documento"].ToString();
                            asistenciasNube.IdTurnoAplicado = lstAsistencias["IdTurnoAplicado"] != DBNull.Value ? Convert.ToInt32(lstAsistencias["IdTurnoAplicado"]) : (int?)null;
                            asistenciasNube.IdSede = Convert.ToInt32(lstAsistencias["IdSede"]);

                        }

                        if (asistencias.Documento == asistenciasNube.Documento)
                        {
                            if (asistencias.IdSede == asistenciasNube.IdSede)
                            {
                                if (asistencias.FechaEntrada == asistenciasNube.FechaEntrada)
                                {
                                    if (asistencias.FechaSalida == asistenciasNube.FechaSalida)
                                    {

                                        rta = Datos.ActualizarEstadoAsistenciaSincronizacionBajada(asistencias);
                                        if (rta.Equals("OK"))
                                        {
                                            ok = true;
                                        }
                                        else
                                        {
                                            ok = false;
                                        }
                                    }
                                    else
                                    {

                                        rta = Datos.ActualizaAsistenciaSalidaSincronizacionBajada(asistencias);
                                        if (rta.Equals("OK"))
                                        {
                                            rta = Datos.ActualizarEstadoAsistenciaSincronizacionBajada(asistencias);
                                            if (rta.Equals("OK"))
                                            {
                                                ok = true;
                                            }
                                            else
                                            {
                                                ok = false;
                                            }
                                        }
                                        else
                                        {
                                            ok = false;
                                        }

                                    }
                                }
                                else
                                {
                                    ok = false;
                                }
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        //registrar asistencia 
                        rta = Datos.RegistrarAsistenciaSincronizacionBajada(asistencias);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoAsistenciaSincronizacionBajada(asistencias);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }




                }

            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;
        }


        #endregion

        #region Retardos

        public static bool SincronizacionRetardosBajada(Retardos retardos)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioRetardos Datos = new RepositorioRetardos();
            try
            {
                tabla = Datos.ObtenerRetardosSincronizacionBajada(retardos);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstRetardos in tabla.Rows)
                    {
                        retardos.IdRetardo = Convert.ToInt32(lstRetardos["IdRetardo"]);
                        retardos.FechaRetardo = Convert.ToDateTime(lstRetardos["FechaRetardo"]);
                        TimeSpan tiempoRetardos = (TimeSpan)lstRetardos["MinutosRegistrados"];
                        double minutosTotales = tiempoRetardos.TotalMinutes;
                        retardos.MinutosRetardos = minutosTotales;
                        retardos.Estado = Convert.ToBoolean(lstRetardos["Estado"]);
                        retardos.Sincronizacion = Convert.ToBoolean(lstRetardos["Sincronizacion"]);
                        retardos.Observacion = lstRetardos["Observacion"].ToString();
                        retardos.IdAsistencia = Convert.ToInt32(lstRetardos["IdAsistencia"]);
                        retardos.IdSede = Convert.ToInt32(lstRetardos["IdSede"]);

                    }

                    tabla = Datos.ValidarRetardoSincronizacionBajada(retardos);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoRetardosSincronizacionBajada(retardos);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }

                    }
                    else
                    {
                        rta = Datos.RegistrarRetardosSincronizacionBajada(retardos);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoRetardosSincronizacionBajada(retardos);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                ok = false;
            }

            return ok;

        }


        #endregion

        #region HorasExtras

        public static bool SincronizacionHorasExtrasBajada(HorasExtras horasExtras)
        {
            bool ok = false;
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            RepositorioExtras Datos = new RepositorioExtras();
            try
            {
                tabla = Datos.ObtenerExtrasSincronizacionBajada(horasExtras);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstExtras in tabla.Rows)
                    {
                        horasExtras.IdHoraExtra = Convert.ToInt32(lstExtras["IdHoraExtra"]);
                        horasExtras.Observacion = lstExtras["Observacion"].ToString();
                        horasExtras.FechaHoraExtra = Convert.ToDateTime(lstExtras["FechaHoraExtra"]);
                        TimeSpan tiempoRetardos = (TimeSpan)lstExtras["MinutosExtras"];
                        double minutosTotales = tiempoRetardos.TotalMinutes;
                        horasExtras.MinutosExtras = minutosTotales;
                        horasExtras.Sincronizacion = Convert.ToBoolean(lstExtras["Sincronizacion"]);
                        horasExtras.Estado = Convert.ToBoolean(lstExtras["Estado"]);
                        horasExtras.IdAsistencia = Convert.ToInt32(lstExtras["IdAsistencia"]);
                        horasExtras.IdSede = Convert.ToInt32(lstExtras["IdSede"]);

                    }

                    tabla = Datos.ValidarExtrasSincronizacionBajada(horasExtras);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = Datos.ActualizarEstadoExtraSincronizacionBajada(horasExtras);
                        if (rta.Equals("OK"))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        rta = Datos.RegistrarHorasExtrasSincronizacionBajada(horasExtras);
                        if (rta.Equals("OK"))
                        {
                            rta = Datos.ActualizarEstadoExtraSincronizacionBajada(horasExtras);
                            if (rta.Equals("OK"))
                            {
                                ok = true;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                ok = false;
            }

            return ok;

        }

        #endregion

        #endregion
    }
}

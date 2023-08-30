using Modelo;
using ServiciosSincronizacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                    if(tabla.Rows.Count > 0)
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
                                if(rta.Equals("OK"))
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


    }
}

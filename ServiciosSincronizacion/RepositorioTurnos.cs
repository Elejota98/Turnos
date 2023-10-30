using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSincronizacion
{
    public class RepositorioTurnos
    {

        #region Subida
        public DataTable ObtenerDatosSincronizacionTurnos(Turnos turnos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerTurnosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ValidarTurnoSincronizacion(Turnos turnos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarTurnoSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = turnos.Descripcion;
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string ActualizarEstadoTurnosSincronizacion(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = turnos.Descripcion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }

        public string ActualizaDatosTurnosSincronizacion(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizaDatosTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 150).Value = turnos.Descripcion;
                comando.Parameters.Add("@HoraEntrada", SqlDbType.Time).Value = turnos.HoraEntrada;
                comando.Parameters.Add("@HoraSalida", SqlDbType.Time).Value = turnos.HoraSalida;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnos.Estado;
                comando.Parameters.Add("@Lunes", SqlDbType.Bit).Value = turnos.Lunes;
                comando.Parameters.Add("@Martes", SqlDbType.Bit).Value = turnos.Martes;
                comando.Parameters.Add("@Miercoles", SqlDbType.Bit).Value = turnos.Miercoles;
                comando.Parameters.Add("@Jueves", SqlDbType.Bit).Value = turnos.Jueves;
                comando.Parameters.Add("@Viernes", SqlDbType.Bit).Value = turnos.Viernes;
                comando.Parameters.Add("@Sabado", SqlDbType.Bit).Value = turnos.Sabado;
                comando.Parameters.Add("@Domingo", SqlDbType.Bit).Value = turnos.Domingo;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = true;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnos.FechaCreacion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }

        public string RegistrarTurnosSincronizacion(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 150).Value = turnos.Descripcion;
                comando.Parameters.Add("@HoraEntrada", SqlDbType.Time).Value = turnos.HoraEntrada;
                comando.Parameters.Add("@HoraSalida", SqlDbType.Time).Value = turnos.HoraSalida;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnos.Estado;
                comando.Parameters.Add("@Lunes", SqlDbType.Bit).Value = turnos.Lunes;
                comando.Parameters.Add("@Martes", SqlDbType.Bit).Value = turnos.Martes;
                comando.Parameters.Add("@Miercoles", SqlDbType.Bit).Value = turnos.Miercoles;
                comando.Parameters.Add("@Jueves", SqlDbType.Bit).Value = turnos.Jueves;
                comando.Parameters.Add("@Viernes", SqlDbType.Bit).Value = turnos.Viernes;
                comando.Parameters.Add("@Sabado", SqlDbType.Bit).Value = turnos.Sabado;
                comando.Parameters.Add("@Domingo", SqlDbType.Bit).Value = turnos.Domingo;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = true;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnos.FechaCreacion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }

        #endregion

        #region Bajada

        public DataTable ObtenerDatosSincronizacionTurnosBajada(Turnos turnos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ObtenerTurnosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ValidarTurnoSincronizacionBajada(Turnos turnos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarTurnoSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = turnos.Descripcion;
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string ActualizarEstadoTurnosSincronizacionBajada(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = turnos.Descripcion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }

        public string ActualizaDatosTurnosSincronizacionBajada(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizaDatosTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 150).Value = turnos.Descripcion;
                comando.Parameters.Add("@HoraEntrada", SqlDbType.Time).Value = turnos.HoraEntrada;
                comando.Parameters.Add("@HoraSalida", SqlDbType.Time).Value = turnos.HoraSalida;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnos.Estado;
                comando.Parameters.Add("@Lunes", SqlDbType.Bit).Value = turnos.Lunes;
                comando.Parameters.Add("@Martes", SqlDbType.Bit).Value = turnos.Martes;
                comando.Parameters.Add("@Miercoles", SqlDbType.Bit).Value = turnos.Miercoles;
                comando.Parameters.Add("@Jueves", SqlDbType.Bit).Value = turnos.Jueves;
                comando.Parameters.Add("@Viernes", SqlDbType.Bit).Value = turnos.Viernes;
                comando.Parameters.Add("@Sabado", SqlDbType.Bit).Value = turnos.Sabado;
                comando.Parameters.Add("@Domingo", SqlDbType.Bit).Value = turnos.Domingo;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = true;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnos.FechaCreacion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }

        public string RegistrarTurnosSincronizacionBajada(Turnos turnos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarTurnosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnos.IdSede;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 150).Value = turnos.Descripcion;
                comando.Parameters.Add("@HoraEntrada", SqlDbType.Time).Value = turnos.HoraEntrada;
                comando.Parameters.Add("@HoraSalida", SqlDbType.Time).Value = turnos.HoraSalida;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnos.Estado;
                comando.Parameters.Add("@Lunes", SqlDbType.Bit).Value = turnos.Lunes;
                comando.Parameters.Add("@Martes", SqlDbType.Bit).Value = turnos.Martes;
                comando.Parameters.Add("@Miercoles", SqlDbType.Bit).Value = turnos.Miercoles;
                comando.Parameters.Add("@Jueves", SqlDbType.Bit).Value = turnos.Jueves;
                comando.Parameters.Add("@Viernes", SqlDbType.Bit).Value = turnos.Viernes;
                comando.Parameters.Add("@Sabado", SqlDbType.Bit).Value = turnos.Sabado;
                comando.Parameters.Add("@Domingo", SqlDbType.Bit).Value = turnos.Domingo;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = true;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnos.FechaCreacion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }




        #endregion
    }
}

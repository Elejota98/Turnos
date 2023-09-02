using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSincronizacion
{
    public class RepositorioTurnosAplicados
    {
        #region Subida
        public DataTable ObtenerTurnosAplicadosSincronizacion(TurnosAplicados turnosAplicados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerTurnosAplicadosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
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

        public DataTable ValidarTurnosAplicadosSincronizacion(TurnosAplicados turnosAplicados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarTurnosAplicadosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = turnosAplicados.Documento;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;

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

        public string ActualizaDatosTurnosAplicadosSincronizacion(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizaDatosTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaAplicada", SqlDbType.DateTime).Value = turnosAplicados.FechaAplicada;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnosAplicados.Estado;
                comando.Parameters.Add("@IdTurno", SqlDbType.Int).Value = turnosAplicados.IdTurno;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
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

        public string ActualizarEstadoTurnosAplicadosSincronizacion(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.VarChar).Value = turnosAplicados.IdTurnoAplicado;
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

        public string RegistrarTurnosAplicadosSincronizacion(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaAplicada", SqlDbType.DateTime).Value = turnosAplicados.FechaAplicada;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnosAplicados.Estado;
                comando.Parameters.Add("@IdTurno", SqlDbType.Int).Value = turnosAplicados.IdTurno;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = turnosAplicados.Sincronizacion;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = turnosAplicados.Documento;
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

        public DataTable ObtenerTurnosAplicadosSincronizacionBajada(TurnosAplicados turnosAplicados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ObtenerTurnosAplicadosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
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

        public DataTable ValidarTurnosAplicadosSincronizacionBajada(TurnosAplicados turnosAplicados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarTurnosAplicadosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = turnosAplicados.Documento;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;

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

        public string ActualizaDatosTurnosAplicadosSincronizacionBajada(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizaDatosTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaAplicada", SqlDbType.DateTime).Value = turnosAplicados.FechaAplicada;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnosAplicados.Estado;
                comando.Parameters.Add("@IdTurno", SqlDbType.Int).Value = turnosAplicados.IdTurno;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
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

        public string ActualizarEstadoTurnosAplicadosSincronizacionBajada(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.VarChar).Value = turnosAplicados.IdTurnoAplicado;
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

        public string RegistrarTurnosAplicadosSincronizacionBajada(TurnosAplicados turnosAplicados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarTurnosAplicadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaAplicada", SqlDbType.DateTime).Value = turnosAplicados.FechaAplicada;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = turnosAplicados.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = turnosAplicados.Estado;
                comando.Parameters.Add("@IdTurno", SqlDbType.Int).Value = turnosAplicados.IdTurno;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = turnosAplicados.IdSede;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = turnosAplicados.Sincronizacion;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = turnosAplicados.Documento;
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

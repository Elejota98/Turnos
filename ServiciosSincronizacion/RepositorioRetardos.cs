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
    public class RepositorioRetardos
    {
        #region Subida

        public DataTable ObtenerRetardosSincronizacion(Retardos retardos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerRetardosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
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

        public DataTable ValidarRetardoSincronizacion(Retardos retardos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarRetardoSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = retardos.IdSede;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.VarChar).Value = retardos.FechaRetardo;
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

        public string ActualizarEstadoRetardosSincronizacion(Retardos retardos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoRetardosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.DateTime).Value = retardos.FechaRetardo;
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

        public string RegistrarRetardosSincronizacion(Retardos retardos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarRetardosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.DateTime).Value = retardos.FechaRetardo;
                TimeSpan minutosRetardo = TimeSpan.FromMinutes(retardos.MinutosRetardos);
                comando.Parameters.Add("@MinutosRetardo", SqlDbType.Time).Value = minutosRetardo;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = retardos.IdAsistencia;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
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

        public DataTable ObtenerRetardosSincronizacionBajada(Retardos retardos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ObtenerRetardosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
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
        public DataTable ValidarRetardoSincronizacionBajada(Retardos retardos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarRetardoSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = retardos.IdSede;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.VarChar).Value = retardos.FechaRetardo;
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
        public string ActualizarEstadoRetardosSincronizacionBajada(Retardos retardos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoRetardosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.DateTime).Value = retardos.FechaRetardo;
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
        public string RegistrarRetardosSincronizacionBajada(Retardos retardos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarRetardosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.DateTime).Value = retardos.FechaRetardo;
                TimeSpan minutosRetardo = TimeSpan.FromMinutes(retardos.MinutosRetardos);
                comando.Parameters.Add("@MinutosRetardo", SqlDbType.Time).Value = minutosRetardo;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = retardos.IdAsistencia;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = retardos.IdSede;
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

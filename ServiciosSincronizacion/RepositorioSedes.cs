using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace ServiciosSincronizacion
{
    public class RepositorioSedes
    {
        #region Subida
        public DataTable ObtenerDatosSedes(Sedes sedes)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerSedesSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public DataTable ValidarSedeSincronizacion(Sedes sedes)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarSedeSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public string ActualizarEstadoSedesSincronizacion(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoSedesSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public string RegistrarSedesSincronizacion(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarSedesSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
                comando.Parameters.Add("@NombreSede", SqlDbType.Bit).Value = sedes.NombreSede;
                comando.Parameters.Add("@DireccionSede", SqlDbType.Bit).Value = sedes.DireccionSede;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = sedes.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = sedes.Estado;
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
        public DataTable ObtenerDatosSedesBajada(Sedes sedes)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ObtenerSedesSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public DataTable ValidarSedeSincronizacionBajada(Sedes sedes)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarSedeSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public string ActualizarEstadoSedesSincronizacionBajada(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoSedesSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
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

        public string RegistrarSedesSincronizacionBajada(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarSedesSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = sedes.IdSede;
                comando.Parameters.Add("@NombreSede", SqlDbType.Bit).Value = sedes.NombreSede;
                comando.Parameters.Add("@DireccionSede", SqlDbType.Bit).Value = sedes.DireccionSede;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = sedes.FechaCreacion;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = sedes.Estado;
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

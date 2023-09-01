
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
    public class RepositorioExtras
    {
        public DataTable ObtenerExtrasSincronizacion(HorasExtras horasExtras)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerExtrasSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = horasExtras.IdSede;
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

        public DataTable ValidarExtrasSincronizacion(HorasExtras horasExtras)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarExtrasSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = horasExtras.IdSede;
                comando.Parameters.Add("@FechaExtra", SqlDbType.VarChar).Value = horasExtras.FechaHoraExtra;
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

        public string ActualizarEstadoExtraSincronizacion(HorasExtras horasExtras)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoExtraSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = horasExtras.IdSede;
                comando.Parameters.Add("@FechaExtra", SqlDbType.DateTime).Value = horasExtras.FechaHoraExtra;
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

        public string RegistrarHorasExtrasSincronizacion(HorasExtras horasExtras)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarHorasExtrasSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaExtras", SqlDbType.DateTime).Value = horasExtras.FechaHoraExtra;
                TimeSpan minutosRetardo = TimeSpan.FromMinutes(horasExtras.MinutosExtras);
                comando.Parameters.Add("@MinutosExtras", SqlDbType.Time).Value = minutosRetardo;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = horasExtras.IdAsistencia;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = horasExtras.IdSede;
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
    }
}

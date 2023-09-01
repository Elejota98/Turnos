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
    public class RepositorioAsistencias
    {
        public DataTable ObtenerAsistenciasSincronizacion(Asistencias asistencias)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerAsistenciasSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = asistencias.IdSede;
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

        public DataTable ValidarAsistenciaSincronizacion(Asistencias asistencias)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarAsistenciaSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = asistencias.IdSede;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@FechaEntrada", SqlDbType.DateTime).Value = asistencias.FechaEntrada;
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

        public string ActualizarEstadoAsistenciaSincronizacion(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoAsistenciaSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.VarChar).Value = asistencias.IdAsistencia;
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

        public string ActualizaAsistenciaSalidaSincronizacion(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizaAsistenciaSalidaSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = asistencias.IdAsistencia;
                comando.Parameters.Add("@FechaSalida", SqlDbType.DateTime).Value = asistencias.FechaSalida;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                if (asistencias.IdTurnoAplicado.HasValue)
                {
                    comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = asistencias.IdTurnoAplicado.Value;
                }
                else
                {
                    comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = DBNull.Value;
                }
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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

        public string RegistrarAsistenciaSincronizacion(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {

                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarAsistenciaSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaEntrada", SqlDbType.DateTime).Value = asistencias.FechaEntrada;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                if (asistencias.IdTurnoAplicado.HasValue) 
                {
                    comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = asistencias.IdTurnoAplicado.Value;
                }
                else
                {
                    comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = DBNull.Value;
                }
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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

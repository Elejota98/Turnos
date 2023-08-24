using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Servicios
{
    public class RepositorioAsistencias
    {
       
        public DataTable ListarDatosTurnosAplicados(Asistencias asistencias, int idSede)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ListarDatosTurnosAplicados", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = idSede;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string RegistrarAsistencia(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarAsistencia", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaEntrada",SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-dd-mm HH:mm:ss");
                comando.Parameters.Add("@FechaSalida", SqlDbType.DateTime).Value = DateTime.Now;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = asistencias.IdTurnoAplicado;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                rta = "ERROR";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

        public DataTable ObtenerDocumentoPorTarjeta(string idTarjeta)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerDocumentoEmpleadoPorTarjeta", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = idTarjeta;
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

    }
}

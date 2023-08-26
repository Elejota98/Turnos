using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Security.Cryptography;

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

        public string RegistrarAsistenciaSinTurnoAsignado(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("INSERT INTO T_Asistencias(FechaEntrada,FechaSalida,Estado,Sincronizacion,Documento,IdTurnoAplicado) " +
                    "VALUES(" + asistencias.FechaEntrada + ",'1900-01-01 00:00:00.000',1,0," + asistencias.Documento
                    + ", NULL)");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
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

        public string RegistrarAsistencia(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarAsistencia", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaEntrada", SqlDbType.DateTime).Value = asistencias.FechaEntrada;
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

        public string ActualizaSalidaAsistencia(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarSalidaAsistencia", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = asistencias.IdAsistencia;
                comando.Parameters.Add("@FechaSalida", SqlDbType.DateTime).Value = asistencias.FechaSalida;
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

        public  DataTable ValidarFechaSalida(Asistencias asistencias, int idSede)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarFechaSalidaAsistencia", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = idSede;
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

        public DataTable ValidarFechSalidaSinTurnoAplicado(Asistencias asistencias)
        {

            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                string cadena = ("SELECT  TOP(1) dbo.T_Asistencias.IdAsitencia FROM    dbo.T_Asistencias INNER JOIN" +
                    "   dbo.T_Empleados ON dbo.T_Asistencias.Documento = dbo.T_Empleados.Documento INNER JOIN" +
                    " dbo.T_Sedes ON dbo.T_Empleados.IdSede = dbo.T_Sedes.IdSede" +
                    " WHERE dbo.T_Asistencias.Documento='"+asistencias.Documento+"' and dbo.T_Asistencias.IdTurnoAplicado IS NULL" +
                    "ORDER BY 1 DESC ");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
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

        public string ActualizarSalidaSinTurnoAplicado(Asistencias asistencias)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                string cadena = ("UPDATE T_Asistencias SET FechaSalida=@FechaSalida WHERE IdAsitencia="+asistencias.IdAsistencia+" AND ");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

    }
}

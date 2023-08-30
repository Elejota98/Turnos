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
       
        public DataTable ListarDatosTurnosAplicados(Asistencias asistencias)
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
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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
                SqlCommand comando = new SqlCommand("P_RegistrarAsistenciaSinTurnoAsignado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;

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
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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

        public  DataTable ValidarFechaSalida(Asistencias asistencias)
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
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarFechSalidaSinTurnoAplicado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarSalidaSinTurnoAplicado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = asistencias.IdAsistencia;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
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

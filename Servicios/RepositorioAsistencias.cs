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
       
        public DataTable ListarDatosTurnosAplicados(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("SELECT dbo.T_Turnos.HoraEntrada, dbo.T_Turnos.HoraSalida, dbo.T_TurnosAplicados.FechaAplicada," +
                    " dbo.T_TurnosAplicados.IdTurnoAplicado FROM     dbo.T_Turnos INNER JOIN" +
                    " dbo.T_TurnosAplicados ON dbo.T_Turnos.IdTurno = dbo.T_TurnosAplicados.IdTurno INNER JOIN" +
                    " dbo.T_Empleados ON dbo.T_TurnosAplicados.Documento = dbo.T_Empleados.Documento  WHERE dbo.T_Empleados.Documento="+empleados.Documento+"");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
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
                SqlCommand comando = new SqlCommand("P_RegistrarTarjetas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaEntrada",SqlDbType.DateTime).Value= DateTime.Now;
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

    }
}

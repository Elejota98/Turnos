using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioRetardos
    {
        public DataTable ListarIdTurnoAplicado(Asistencias asistencias)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("SELECT      top (1)  dbo.T_Asistencias.IdAsistencia " +
                            " FROM dbo.T_Turnos INNER JOIN " +
                         "dbo.T_TurnosAplicados ON dbo.T_Turnos.IdTurno = dbo.T_TurnosAplicados.IdTurno INNER JOIN "+
                         "dbo.T_Empleados ON dbo.T_TurnosAplicados.Documento = dbo.T_Empleados.Documento INNER JOIN "+
                         "dbo.T_Sedes ON dbo.T_Turnos.IdSede = dbo.T_Sedes.IdSede AND dbo.T_Empleados.IdSede = dbo.T_Sedes.IdSede INNER JOIN " +
                         "dbo.T_Asistencias ON dbo.T_TurnosAplicados.IdTurnoAplicado = dbo.T_Asistencias.IdTurnoAplicado AND dbo.T_Empleados.Documento = dbo.T_Asistencias.Documento WHERE  dbo.T_Sedes.IdSede="+asistencias.IdSede+" and dbo.T_TurnosAplicados.IdTurnoAplicado="+asistencias.IdTurnoAplicado+" " +
                    "AND dbo.T_TurnosAplicados.Documento ="+asistencias.Documento+" ORDER BY T_Asistencias.FechaEntrada DESC");
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

        public string RegistrarRetardo(Retardos retardos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarRetardos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaRetardo", SqlDbType.DateTime).Value = retardos.FechaRetardo;
                TimeSpan minutosRetardo = TimeSpan.FromMinutes(retardos.MinutosRetardos);
                comando.Parameters.Add("@MinutosRetardo", SqlDbType.Time).Value = minutosRetardo;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = retardos.IdAsistencia;
                comando.Parameters.Add("@IdSede",SqlDbType.Int).Value = retardos.IdSede;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                rta = ex.ToString();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

    }
}

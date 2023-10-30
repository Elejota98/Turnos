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
                SqlCommand comando = new SqlCommand("P_ListarIdTurnoAplicado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = asistencias.Documento;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = asistencias.IdSede;
                comando.Parameters.Add("@IdTurnoAplicado", SqlDbType.Int).Value = asistencias.IdTurnoAplicado;
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

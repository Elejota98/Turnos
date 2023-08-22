using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioSedes
    {
        public string RegistrarSedes(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarSedes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreSede", SqlDbType.VarChar).Value = sedes.NombreSede;
                comando.Parameters.Add("@DireccionSede", SqlDbType.VarChar).Value = sedes.DireccionSede;
                sqlCon.Open();
                rta = comando.ExecuteNonQuery() == 1 ? "OK" : "ERROR";

            }
            catch (Exception ex )
            {

                rta = "ERROR";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;

        }
        public string ActualizarSede(Sedes sedes)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarSedes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreSede", SqlDbType.VarChar).Value = sedes.NombreSede;
                comando.Parameters.Add("@DireccionSede", SqlDbType.VarChar).Value = sedes.DireccionSede;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = sedes.IdSede;
                sqlCon.Open();
                rta = comando.ExecuteNonQuery() == 1 ? "OK" : "ERROR";

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

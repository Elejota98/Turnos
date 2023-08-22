using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioNovedades
    {
        public string InsertarNovedades(Novedades novedades)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarNovedades", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreNovedad", SqlDbType.VarChar).Value = novedades.NombreNovedad;
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
    }
}

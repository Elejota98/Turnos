using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioPoliticas
    {
        public DataTable ListarPoliticas(Politicas politicas)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ListarPoliticas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdSede", SqlDbType.VarChar).Value = politicas.IdSede;
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

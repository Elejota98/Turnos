using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioHorasExtras
    {
        public string RegistrarHorasExtras(HorasExtras horasExtras)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarHorasExtras", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@FechaExtras", SqlDbType.DateTime).Value = horasExtras.FechaHoraExtra;
                TimeSpan minutosRetardo = TimeSpan.FromMinutes(horasExtras.MinutosExtras);
                comando.Parameters.Add("@MinutosExtras", SqlDbType.Time).Value = minutosRetardo;
                comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = horasExtras.IdAsistencia;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = horasExtras.IdSede;
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

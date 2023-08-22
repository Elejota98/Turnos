using EGlobalT.Device.SmartCard;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioCargos
    {
        public string InsertarCargos(Cargos cargos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarCargos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreCargo", SqlDbType.VarChar).Value = cargos.NombreCargo;
                sqlCon.Open();
                rta = comando.ExecuteNonQuery() == 1 ? "OK" : "ERROR";

            }
            catch (Exception ex )
            {

                rta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

        public string ActualizarCargos(Cargos cargos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarCargos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreCargo", SqlDbType.VarChar).Value = cargos.NombreCargo;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = cargos.Estado;
                comando.Parameters.Add("@IdCargo", SqlDbType.Int).Value = cargos.IdCargo;
                sqlCon.Open();
                rta = comando.ExecuteNonQuery() == 1 ? "OK" : "ERROR";

            }
            catch (Exception ex)
            {

                rta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

        public DataTable ListarCargos()
        {
            DataTable tabla = new DataTable();
            SqlDataReader resultado;
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ListarCargos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex )
            {

                throw ex ;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

        }
    }
}

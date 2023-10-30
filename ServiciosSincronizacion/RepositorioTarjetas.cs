using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSincronizacion
{
    public class RepositorioTarjetas
    {
        public DataTable ObtenerDatosTarjetas()
        {
        DataTable tabla = new DataTable();
        SqlConnection sqlCon = new SqlConnection();
        SqlDataReader resultado;
        try
        {
            sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
            SqlCommand comando = new SqlCommand("P_ObtenerTarjetasSincronizacion", sqlCon);
            comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable ValidarTarjetaSincronizacion(Tarjetas tarjetas)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;

            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarTarjetaSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
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

        public string RegistrarTarjetasSincronizacion(Tarjetas tarjetas)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarTarjetasSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = tarjetas.Estado;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = tarjetas.Sincronizacion;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = tarjetas.FechaCreacion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex )
            {

                throw ex ;
            }

            return rta;
        }

        public string ActualizarEstadoTarjetasSincronizacion(Tarjetas tarjetas)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTarjetasSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return rta;
        }
    }
}

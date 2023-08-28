using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using EGlobalT.Device.SmartCardReaders;
using EGlobalT.Device.SmartCardReaders.Entities;
using System.Security.Cryptography;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Servicios
{
    public class RepositorioTarjetas
    {

        public string ObtenerIdTarjeta()
        {
            string idTarjeta = string.Empty;

            Lectora_ACR122 lectora = new Lectora_ACR122();
            Rspsta_Conexion_LECTOR resultado = new Rspsta_Conexion_LECTOR();
            Rspsta_DetectarTarjeta_LECTOR detectar = new Rspsta_DetectarTarjeta_LECTOR();
            Rspsta_CodigoTarjeta_LECTOR codigoTarjeta = new Rspsta_CodigoTarjeta_LECTOR();

            codigoTarjeta = lectora.ObtenerIDTarjeta();

            if (codigoTarjeta.CodigoTarjeta != null && codigoTarjeta.CodigoTarjeta != string.Empty)
            {
                idTarjeta = codigoTarjeta.CodigoTarjeta;
            }
            else
            {
                idTarjeta = "ERROR";
            }

            return idTarjeta;
        }
        public bool DetectarTarjeta()
        {
            bool ok = false;
            Rspsta_Conexion_LECTOR resultado = new Rspsta_Conexion_LECTOR();
            Lectora_ACR122 lectora = new Lectora_ACR122();
            Rspsta_DetectarTarjeta_LECTOR detectar = new Rspsta_DetectarTarjeta_LECTOR();
            try
            {
                detectar = lectora.DetectarTarjeta();
                if (detectar.TarjetaDetectada)
                {
                    ok = true;

                }
                else
                {
                    ok = false;
                }
            }
            catch (Exception ex)
            {

                ok = false;

            }
            return ok;

        }
        public bool ConectarLectora()
        {
            bool ok = false;

            Lectora_ACR122U lectora = new Lectora_ACR122U();
            Rspsta_Conexion_LECTOR res = lectora.Conectar(false);
            try
            {
                if (res.Conectado)
                {
                    ok = true;
                }
                else
                {
                    ok = true;
                }

            }
            catch (Exception ex)
            {

                ok = false;
            }
            return ok;
        }
        public bool PitarLectora()
        {
            try
            {
                Lectora_ACR122 lectora = new Lectora_ACR122();
                Rspsta_Pitar_LECTOR pitar = new Rspsta_Pitar_LECTOR();
                
                pitar = lectora.Pitar();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }



        }
        public string InsertarTarjetas(Tarjetas tarjetas)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarTarjetas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = true;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = true;
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
        public string InactivarTarjetas(Tarjetas tarjetas)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoTarjetas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = false;
                comando.Parameters.Add("@Sincronizacion", SqlDbType.Bit).Value = false;
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
        public DataTable VerificarExisteTarjeta(Tarjetas tarjetas)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader Resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarExisteTarjeta", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = tarjetas.IdTarjeta;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
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

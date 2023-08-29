using EGlobalT.Device.SmartCard;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioEmpleados
    {
        public string RegistrarEmpleado(Empleados empleados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_RegistrarEmpleado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = empleados.NombreEmpleado;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = empleados.ApellidoEmpleado;
                comando.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = empleados.TelefonoEmpleado;
                comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = empleados.Contraseña;
                comando.Parameters.Add("@IdCargo", SqlDbType.Int).Value = empleados.IdCargo;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = empleados.IdTarjeta;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = empleados.IdSede;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex )
            {

                rta = ex.ToString();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return rta;
        }

        public string ActualizarDatosEmpleado(Empleados empleados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEmpleado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = empleados.NombreEmpleado;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = empleados.ApellidoEmpleado;
                comando.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = empleados.TelefonoEmpleado;
                //comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = empleados.Contraseña;
                comando.Parameters.Add("@IdCargo", SqlDbType.Int).Value = empleados.IdCargo;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = empleados.IdTarjeta;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = empleados.IdSede;
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

        public DataTable VerificarExisteEmpleadoPorTarjeta(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("SELECT * FROM T_Empleados WHERE IdTarjeta='" + empleados.IdTarjeta + "' AND Estado=1");
                SqlCommand comando = new SqlCommand(cadena,sqlCon);
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

        public DataTable VerificarExisteEmpleado(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ValidarExisteEmpleado", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
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

        public DataTable BuscarEmpleadosPorDocumento(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_BuscarEmpleadoPorDocumento", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
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

        public DataTable ListarEmpleados()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("SELECT        dbo.T_Empleados.Documento, dbo.T_Empleados.NombreEmpleado, dbo.T_Empleados.ApellidoEmpleado," +
                    " dbo.T_Empleados.TelefonoEmpleado, dbo.T_Empleados.IdTarjeta, dbo.T_Cargos.NombreCargo,  dbo.T_Sedes.NombreSede " +
                    " FROM   dbo.T_Empleados INNER JOIN dbo.T_Sedes ON dbo.T_Empleados.IdSede = dbo.T_Sedes.IdSede INNER JOIN  dbo.T_Cargos ON dbo.T_Empleados.IdCargo = dbo.T_Cargos.IdCargo" +
                    " WHERE dbo.T_Empleados.Estado=1 ");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
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

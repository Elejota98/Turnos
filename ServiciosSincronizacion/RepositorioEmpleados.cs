using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace ServiciosSincronizacion
{
    public class RepositorioEmpleados
    {
        public DataTable ObtenerDatosEmpleados(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ObtenerEmpleadosSincronizacion", sqlCon);
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = empleados.IdSede;
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

        public DataTable ValidarEmpleadoSincronizacion(Empleados empleados)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ValidarEmpleadoSincronizacion", sqlCon);
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
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

        public string ActualizarDatosEmpleado(Empleados empleados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_ActualizarDatosEmpleadosSincronizacion", sqlCon);
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

        public string ActualizarEstadoEmpleadosSincronizacion(Empleados empleados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                SqlCommand comando = new SqlCommand("P_ActualizarEstadoEmpleadosSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
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
        public string RegistrarEmpleadoSincronizacion(Empleados empleados)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionNube();
                SqlCommand comando = new SqlCommand("P_RegistrarEmpleadoSincronizacion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = empleados.Documento;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = empleados.NombreEmpleado;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = empleados.ApellidoEmpleado;
                comando.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = empleados.TelefonoEmpleado;
                comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = empleados.Contraseña;
                comando.Parameters.Add("@IdCargo", SqlDbType.Int).Value = empleados.IdCargo;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = empleados.IdTarjeta;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = empleados.IdSede;
                comando.Parameters.Add("@FechaCreacion", SqlDbType.Int).Value = empleados.FechaCreacion;

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

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
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = empleados.TelefonoEmpleado;
                comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = empleados.Contraseña;
                comando.Parameters.Add("@IdCargo", SqlDbType.Int).Value = empleados.IdCargo;
                comando.Parameters.Add("@IdTarjeta", SqlDbType.VarChar).Value = empleados.IdTarjeta;
                comando.Parameters.Add("@IdSede", SqlDbType.Int).Value = empleados.IdSede;
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

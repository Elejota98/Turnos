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
    public class RepositorioLogin
    {
        public DataTable ConsultarContraseñaPorDocumento(DtoLogin login)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            SqlDataReader resultado;
            try
            {
                sqlCon = RepositorioConexion.GetInstancia().CrearConexionLocal();
                string cadena = ("SELECT  dbo.T_Empleados.Documento, dbo.T_Empleados.NombreEmpleado, dbo.T_Empleados.ApellidoEmpleado, dbo.T_Empleados.ContraseñaEmpleado, dbo.T_Cargos.NombreCargo" +
                    " FROM dbo.T_Empleados INNER JOIN  dbo.T_Cargos ON dbo.T_Empleados.IdCargo = dbo.T_Cargos.IdCargo WHERE dbo.T_Empleados.Estado=1 and dbo.T_Empleados.Documento='" + login.Documento+"'");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
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

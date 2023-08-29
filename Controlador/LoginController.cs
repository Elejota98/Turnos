using BCrypt.Net;
using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class LoginController
    {
        public static string ValidarInicioSesion(DtoLogin login)
        {
            string rta = "";
            DataTable tabla = new DataTable();  

            RepositorioLogin Datos = new RepositorioLogin();

            try
            {
                tabla = Datos.ConsultarContraseñaPorDocumento(login);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow lstDatos in tabla.Rows)
                    {
                        login.Documento = lstDatos["Documento"].ToString();
                        login.Contraseña = lstDatos["ContraseñaEmpleado"].ToString();
                        login.NombresEmpleado = lstDatos["NombreEmpleado"].ToString();
                        login.ApellidosEmpleado = lstDatos["ApellidoEmpleado"].ToString();
                        login.CargoEmpleado = lstDatos["NombreCargo"].ToString();
                    }

                    if (VerificarClave(login))
                    {
                        return rta = "OK";
                    }

                    else
                    {
                        return rta = "Contraseña incorrecta";

                    }
                }
                else
                {
                    return rta = "Error en la valdación de los datos";

                }
            }
            catch (Exception ex)
            {

                rta = ex.ToString();
            }
            return rta;

        }

        static bool VerificarClave(DtoLogin login)
        {
            bool ok = false;

            try
            {
                login.ContraseñaNueva = EncriptarClave(login.ContraseñaNueva);

                bool contraseñaCorrecta = BCrypt.Net.BCrypt.Verify(login.ContraseñaNueva, login.Contraseña);

                if (contraseñaCorrecta)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            catch (Exception ex )
            {

                throw ex ;
            }
            return ok;

        }


        static string EncriptarClave(string clave)
        {
          

            // Generar un hash bcrypt para la clave
            string contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(clave);
            return contraseñaEncriptada;
        }
    }
}

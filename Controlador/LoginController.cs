using BCrypt.Net;
using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
                    }

                    if (VerificarClave(login))
                    {
                        rta = "OK";
                    }

                    else
                    {
                        return rta = "Contraeña incorrecta";
                    }
                }
                else
                {
                    return rta = "El documento " + login.Documento + " del empleado se encuentra inactivo \n" +
                        "O no se encuentra registrado en el sistema";
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
                if (login.Contraseña == login.ContraseñaNueva)
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
            string claveNew = clave.Substring(clave.Length - 4);

            // Generar un hash bcrypt para la clave
            string contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(claveNew);
            return contraseñaEncriptada;
        }
    }
}

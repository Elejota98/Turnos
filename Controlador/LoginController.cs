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

                if (Decrypt(login.Contraseña) == login.ContraseñaNueva)
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

        ///NRE ENCRIPTAR CLAVE 
        private static string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}

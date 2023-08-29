﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSincronizacion
{
    public class RepositorioConexion
    {
        private static RepositorioConexion con = null;

        public SqlConnection CrearConexionLocal()
        {
            SqlConnection cadena = new SqlConnection(ConfigurationManager.AppSettings["ConexionLocal"]);
            return cadena;
        }

        public SqlConnection CrearConexionNube()
        {
            SqlConnection cadena = new SqlConnection(ConfigurationManager.AppSettings["ConexionNube"]);
            return cadena;
        }

        public static RepositorioConexion GetInstancia()
        {
            if (con == null)
            {
                con = new RepositorioConexion();
            }
            return con;
        }

    }
}

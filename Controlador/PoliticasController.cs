using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PoliticasController
    {
        public static DataTable ListarPoliticas()
        {
            DataTable tabla;
            RepositorioPoliticas Datos = new RepositorioPoliticas();

            return tabla = Datos.ListarPoliticas();
        }
    }
}

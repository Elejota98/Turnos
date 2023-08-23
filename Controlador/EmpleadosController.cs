using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EmpleadosController
    {
        public static string RegistrarEmpleado(Empleados empleados)
        {
            string rta = "";
            RepositorioEmpleados Datos = new RepositorioEmpleados();
            DataTable tabla;            
            Tarjetas tarjetas = new Tarjetas();
            tarjetas.IdTarjeta = empleados.IdTarjeta;
            tabla = Datos.VerificarExisteEmpleado(empleados);
            if (tabla.Rows.Count > 0)
            {
                rta = "El empleado con Documento "+empleados.Documento+" ya se encuentra registrado";
            }
            else
            {

                tabla = TarjetasController.VerificarExisteTarjeta(tarjetas);
                if (tabla.Rows.Count > 0)
                {
                    tabla = Datos.VerificarExisteEmpleadoPorTarjeta(empleados);
                    if (tabla.Rows.Count > 0)
                    {
                        rta = "Esta tarjeta ya le pertenece a un empleado";
                    }
                    else
                    {
                        rta = Datos.RegistrarEmpleado(empleados);
                        if (rta.Equals("OK"))
                        {
                            rta = "OK";
                        }
                        else
                        {
                            rta = "ERROR";
                        }
                        return rta;
                    }
                }
                else
                {

                    rta = TarjetasController.RegistrarTarjetas(tarjetas);
                    if (rta.Equals("OK"))
                    {

                        rta = Datos.RegistrarEmpleado(empleados);
                        if (rta.Equals("OK"))
                        {
                            rta = "OK";
                        }
                        else
                        {
                            rta = "Error en el momento de registrar el empleado \n Informar a Tecnología";
                        }
                        return rta;
                    }
                    else
                    {
                        rta = "Error en el momento de guardar la tarjeta";
                    }
                }
            }

            return rta;

        }

        public static DataTable BuscarEmpleadosPorDocumento(Empleados empleados)
        {
            DataTable dt = new DataTable();
            RepositorioEmpleados Datos = new RepositorioEmpleados();
            
             return dt=Datos.BuscarEmpleadosPorDocumento(empleados);
        }

        public static DataTable ListarEmpleados()
        {
            DataTable dt = new DataTable();
            RepositorioEmpleados Datos = new RepositorioEmpleados();

            return dt = Datos.ListarEmpleados();
        }



    }
}

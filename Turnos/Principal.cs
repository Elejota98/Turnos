using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Diagnostics.Eventing.Reader;
using System.Configuration;

namespace Turnos
{
    public partial class Principal : Form
    {

        #region Definiciones 
        public int idSede = Convert.ToInt32(ConfigurationManager.AppSettings["IdSede"]);
        Tarjetas tarjetas = new Tarjetas();
        #endregion


        public Principal()
        {
            InitializeComponent();
            Inicio();
        }

        #region Funciones

        #region Tarjetas
        public string ObtenerIdTarjeta()
        {
            string idTarjeta = "";
            try
            {
                idTarjeta = TarjetasController.ObtenerIdTarjeta();

                if (idTarjeta != string.Empty && idTarjeta != null)
                {
                    if (idTarjeta != "ERROR")
                    {
                        tarjetas.IdTarjeta = idTarjeta;
                    }
                    else
                    {
                        MensajeError("Ocurrió un error al obtener la id de la tarjeta \n * Verifique si la lectora está conectada \n * Verifique quitando la tarjeta y volviendola a colocar o si no cambie de tarjeta");

                    }
                }
                else
                {
                    MensajeError("Ocurrió un error al obtener la id de la tarjeta \n * Verifique si la lectora está conectada \n * Verifique quitando la tarjeta y volviendola a colocar o si no cambie de tarjeta");

                }
            }
            catch (Exception ex)
            {

                MensajeError(ex.ToString());

            }

            return idTarjeta;

        }
        public bool VerificarTarjetaExiste(string idTarjeta)
        {
            Tarjetas tarjetas = new Tarjetas();
            tarjetas.IdTarjeta = idTarjeta;
            DataTable tabla;
            bool ok = false;
            try
            {
                tabla = TarjetasController.VerificarExisteTarjeta(tarjetas);
                if (tabla.Rows.Count > 0)
                {
                    ok = false;
                }
                else
                {
                    ok = true;
                }

            }
            catch (Exception ex )
            {

                MensajeError("Error" + ex.ToString());
            }
            return ok;

        }

        public bool RegistrarTarjetas(string idTarjeta)
        {
            bool ok = false;
            Tarjetas tarjetas = new Tarjetas();
            string rta = "";
            rta = TarjetasController.RegistrarTarjetas(tarjetas);
            if (rta.Equals("OK"))
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;

        }
        #endregion

        #region Sedes
        public void RegistrarSedes(Sedes sedes)
        {
            string rta = "";

            //Asignar valores a las variables

            rta = SedesController.RegistrarSedes(sedes);
            if (!rta.Equals("OK"))
            {
                MensajeError("Ocurrió un error en el momento de registrar la sede");
            }
            else
            {
                MensajeOk("Registro guardado correctamente");
            }
        }
        public void ActualizarSede(Sedes sedes)
        {
            string rta = "";
            //Asignar valores a las variables


            rta = SedesController.ActualizarSede(sedes);
            if (!rta.Equals("OK"))
            {
                MensajeError("Ocurrió un error en el momento de atualizar la sede");
            }
            else
            {
                MensajeOk("Registro guardado correctamente");
            }
        }

        #endregion

        #region Cargos
        public void RegistrarCargos(Cargos cargos)
        {
            string rta = "";
            
            rta = CargosController.InsertarCargos(cargos);

            if (!rta.Equals("OK"))
            {
                MensajeError("Ocurrió un error en el momento de registrar el cargo");
            }
            else
            {
                MensajeOk("Registro guardado correctamente");
            }
        }
        public void ActualizarCargos(Cargos cargos)
        {
            string rta = "";

            rta = CargosController.ActualizarCargos(cargos);

            if (!rta.Equals("OK"))
            {
                MensajeError("Ocurrió un error en el momento de registrar el cargo");

            }
            else
            {
                MensajeOk("Registro actualizado correctamente");
            }
        }


        #endregion

        #region Novedades


        #endregion

        #region Empleados

        public void ListarCargos()
        {
            try
            {
                cboCargo.DataSource = CargosController.ListarCargos();
                cboCargo.DisplayMember = "NombreCargo";
                cboCargo.ValueMember = "IdCargo";
            }
            catch (Exception ex )
            {

                MensajeError(ex.ToString());
            }


        }
        public void ListarSedes()
        {
            try
            {
                cboSede.DataSource = SedesController.ListarSedes();
                cboSede.DisplayMember = "NombreSede";
                cboSede.ValueMember = "IdSede";
            }
            catch (Exception ex )
            {

                MensajeError(ex.ToString());
            }
        }

        public void ListarEmpleados()
        {
            dvgListadoEmpleados.DataSource = EmpleadosController.ListarEmpleados();
        }
        public void RegistrarEmpleado()
        {
            string rta = "";
            Empleados empleados = new Empleados();
            empleados.Documento = txtDocumento.Text;
            empleados.NombreEmpleado = txtNombre.Text;
            empleados.ApellidoEmpleado = txtApellidos.Text;
            empleados.TelefonoEmpleado = txtTelefono.Text;
            empleados.IdCargo = Convert.ToInt32(cboCargo.SelectedValue.ToString());
            empleados.IdSede = Convert.ToInt32(cboCargo.SelectedValue.ToString());
            if (empleados.Documento == string.Empty)
            {
                MensajeError("Falta ingresar un documento");
                txtDocumento.Focus();
            }
            else if (empleados.NombreEmpleado == string.Empty || empleados.ApellidoEmpleado == string.Empty)
            {
                MensajeError("Falta ingresar por lo menos un nombre o un apellido");
                txtNombre.Focus();
            }
            else
            {
                empleados.Contraseña = EncriptarClave(empleados.Documento);

                rta = EmpleadosController.RegistrarEmpleado(empleados);

                if (rta.Equals("OK"))
                {
                    MensajeOk("Empleado guardado correctamente");
                    ListarEmpleados();
                }
                else
                {
                    MensajeError(rta);
                }
            }   

        }

        public void BuscarEmpleadosPorDocumento()
        {
            Empleados empleados = new Empleados();
            empleados.Documento = txtDocumentoBuscar.Text;

            dvgListadoEmpleados.AutoGenerateColumns = true;

            dvgListadoEmpleados.DataSource=EmpleadosController.BuscarEmpleadosPorDocumento(empleados);
        }

        #endregion

        #region EncriptarClave


        static string EncriptarClave(string clave)
        {
            string claveNew = clave.Substring(clave.Length - 4);

            // Generar un hash bcrypt para la clave
          string  contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(claveNew);
            return contraseñaEncriptada;
        }

        #endregion

        #region Asistencia

        public void RegistrarIngreso()
        {
            string rta = "";
            DataTable tabla;
            Asistencias asistencia = new Asistencias();
            asistencia.FechaEntrada = DateTime.Now;
            asistencia.FechaSalida=DateTime.Now;

            rta = AsistenciaController.RegistrarAsistencia(asistencia, idSede);

            if (!rta.Equals("ERROR"))
            {
                MensajeOk(rta.ToString());
            }
            else
            {
                MensajeError(rta);
            }

        }

        #endregion

        #endregion

        #region Parametros
        public void MedidasFormularios()
        {
            this.Size = new Size(1024, 768);

        }

        public void Inicio()
        {
            MedidasFormularios();
            if (CargarImagenes())
            {
               
            }
          
        }

        public bool CargarImagenes()
        {
            bool ok = false;
            //fondoEmpleado.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Imagenes\fondoEmpleados.png"));

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Imagenes\Encabezado.png");
            if (File.Exists(imagePath))
            {
                pnTitulo.BackgroundImage = Image.FromFile(imagePath);
                BackgroundImageLayout = ImageLayout.Stretch;
                ok = true;
            }

            else
            {
                ok = false;
            }
            return ok;

        }

  
        #endregion

        #region Mensajes
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Turnos - Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Turnos - Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void Principal_Load(object sender, EventArgs e)
        {
            Inicio();
            TabPrincipal.SelectedTab = Menu;
            TabPrincipal.Appearance = TabAppearance.FlatButtons;
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión empleados";
            lblTitulo.Visible = true;
            TabPrincipal.SelectedTab = Empleados;
            ListarCargos();
            ListarSedes();
            ListarEmpleados();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = ActualizarDatosEmpleado;         
        }

        private void cbActSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarSedes();
        }

        private void cboActCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarCargos();

        }

        private void txtDocumentoBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleadosPorDocumento();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            RegistrarIngreso();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Aistencia empleados";
            lblTitulo.Visible = true;
            TabPrincipal.SelectedTab = Asistencia;
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            string rta = "";
            DataTable tabla;
            Asistencias asistencia = new Asistencias();
            asistencia.FechaEntrada = DateTime.Now;
            asistencia.FechaSalida = DateTime.Now;

            rta = AsistenciaController.ActualizarSalidaAsistencia(asistencia, idSede);

            if (!rta.Equals("ERROR"))
            {
                MensajeOk(rta.ToString());
            }
            else
            {
                MensajeError(rta);
            }
        }
    }
}

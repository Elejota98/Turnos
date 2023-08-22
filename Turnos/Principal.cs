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

namespace Turnos
{
    public partial class Principal : Form
    {
        Tarjetas tarjetas = new Tarjetas();
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

        public void RegistrarEmpleado()
        {
            string rta = "";
            Empleados empleados = new Empleados();
            empleados.Documento = txtDocumento.Text;
            empleados.NombreEmpleado = txtNombre.Text;
            empleados.ApellidoEmpleado = txtApellidos.Text;
            empleados.TelefonoEmpleado = txtTelefono.Text;
            empleados.IdTarjeta = ObtenerIdTarjeta();
            empleados.IdCargo = Convert.ToInt32(cboCargo.SelectedValue.ToString());
            empleados.IdSede = Convert.ToInt32(cboCargo.SelectedValue.ToString());

            rta = 

                

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
            TabPrincipal.SelectedTab = Menu;
            TabPrincipal.Appearance = TabAppearance.FlatButtons;
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = Empleados;
            ListarCargos();
            ListarSedes();


        }
    }
}

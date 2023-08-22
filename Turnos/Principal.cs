using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            MedidasFormularios();
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

        #endregion

        #region Parametros
        public void MedidasFormularios()
        {
            this.Size = new Size(1024, 768);

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
            TabPrincipal.SelectedTab = Asistencia;
            TabPrincipal.Appearance = TabAppearance.FlatButtons;
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
        }
    }
}

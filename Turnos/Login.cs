using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rta = "";
             DtoLogin login = new DtoLogin();
            login.Documento = textBox1.Text;
            login.ContraseñaNueva = textBox2.Text;

            if (login.Documento != null || login.Documento != string.Empty || login.ContraseñaNueva != null || login.ContraseñaNueva != string.Empty)
            {

                DataTable tabla = new DataTable();
                rta = LoginController.ValidarInicioSesion(login);
                if (rta.Equals("OK"))
                {
                    Principal principal = new Principal();
                    principal.Nombre = login.NombresEmpleado.ToString();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MensajeError(rta.ToString());
                }
            }
            else
            {
                MensajeError("Faltan datos por ingresar");
            }
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Turnos - Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Turnos - Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timeFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblFooter.Text = "© " + DateTime.Now.Year + " - Parquearse Tecnología";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timeFecha.Enabled= true;
        }
    }
}

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
             DtoLogin login = new DtoLogin();
            login.Documento = textBox1.Text;
            login.ContraseñaNueva = textBox2.Text;
            
            string rta = "";
            rta = LoginController.ValidarInicioSesion(login);
            if (rta.Equals("OK"))
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MensajeError(rta);
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
    }
}

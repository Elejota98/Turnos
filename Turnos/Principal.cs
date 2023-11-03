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
using System.Security.Cryptography;
using System.Threading;

namespace Turnos
{
    public partial class Principal : Form
    {
       

        public string Nombre;
        public string Cargo;
        public string Documento;
        public long IdEstacionamiento;
        
        #region Definiciones 
        public int idSede = Convert.ToInt32(ConfigurationManager.AppSettings["IdSede"]);
        Tarjetas tarjetas = new Tarjetas();
        int conteo = 0;
        int tiempoMensaje = 5000;
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
                        idTarjeta = "NO TARJETA";


                        //return idTarjeta =("Ocurrió un error al obtener la id de la tarjeta \n * Verifique si la lectora está conectada \n * Verifique quitando la tarjeta y volviendola a colocar o si no cambie de tarjeta");

                    }
                }
                else
                {
                    idTarjeta = "ERROR";
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
        public bool DetectarTarjeta()
        {
            bool ok = false;

            try
            {
                ok = TarjetasController.DetectarTarjeta();

                if (ok)
                {
                    ok = true;
                }
                else
                {
                    return ok;
                }
            }
            catch (Exception ex )
            {

                MensajeError(ex.ToString());
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

        public void ListarCargosAct()
        {
            try
            {
                cboActCargo.DataSource = CargosController.ListarCargos();
                cboActCargo.DisplayMember = "NombreCargo";
                cboActCargo.ValueMember = "IdCargo";
            }
            catch (Exception ex)
            {

                MensajeError(ex.ToString());
            }


        }
        public void ListarSedesAct()
        {
            try
            {
                cbActSede.DataSource = SedesController.ListarSedes();
                cbActSede.DisplayMember = "NombreSede";
                cbActSede.ValueMember = "IdSede";
            }
            catch (Exception ex)
            {

                MensajeError(ex.ToString());
            }
        }

        public void ListarEmpleados()
        {
            DataTable tabla;
            tabla = EmpleadosController.ListarEmpleados();
            if (tabla.Rows.Count > 0)
            {
                dvgListadoEmpleados.DataSource = EmpleadosController.ListarEmpleados();
                dvgListadoEmpleados.Columns[0].Visible = true;

            }

        }
        public void ListarActEmpleados()
        {
            DataTable tabla;
            tabla = EmpleadosController.ListarEmpleados();
            if (tabla.Rows.Count > 0)
            {
                dvgActListadoEmpleados.DataSource = EmpleadosController.ListarEmpleados();
                dvgActListadoEmpleados.Columns[0].Visible = true;

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

        public void ActualizarEmpleado()
        {
            string rta = "";
            Empleados empleados = new Empleados();
            empleados.Documento = tbActDocumento.Text;
            empleados.NombreEmpleado = tbActNombres.Text;
            empleados.ApellidoEmpleado = tbActApellidos.Text;
            empleados.TelefonoEmpleado = tbActTelefono.Text;
            empleados.IdCargo = Convert.ToInt32(cboActCargo.SelectedValue.ToString());
            empleados.IdSede = Convert.ToInt32(cbActSede.SelectedValue.ToString());
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
                //empleados.Contraseña = EncriptarClave(empleados.Documento);

                rta = EmpleadosController.ActualizarEmpleados(empleados);

                if (rta.Equals("OK"))
                {
                    MensajeOk("Empleado actualizado correctamente");
                    //ListarActEmpleados();
                    lblTitulo.Text = "Gestión empleados";
                    lblTitulo.Visible = true;
                    TabPrincipal.SelectedTab = Empleados;
                    ListarCargos();
                    ListarSedes();
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

            #region Old

            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(claveNew);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    claveNew = Convert.ToBase64String(ms.ToArray());
                }
            }
            return claveNew;

            //// Generar un hash bcrypt para la clave
            //string contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(claveNew);
            //return contraseñaEncriptada;

            #endregion
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
            asistencia.IdSede = idSede;

            rta = AsistenciaController.RegistrarAsistencia(asistencia);


            if (!rta.Equals("ERROR"))
            {
                tmAsistencias.Stop();
                lblMensaje.Text = rta;
                lblMensaje.Visible = true;
                lblMensaje.BackColor = Color.FromArgb(139, 180, 77);
                lblMensaje.ForeColor = Color.White;
                lblMensaje.Update();
                Thread.Sleep(tiempoMensaje);
                Login login = new Login();
                login.Show();
                this.Hide();
                //tmAsistencias.Start();
            }
            else
            {
                tmAsistencias.Stop();
                lblMensaje.Text = rta;
                lblMensaje.Update();
                tmAsistencias.Start();
            }

        }
        public void AsistenciaEmpleado()
        {
            string rta = "";
            rta = ObtenerIdTarjeta();
            if (rta != "ERROR" && rta !="NO TARJETA")
            {
                
                DataTable tabla;
                Asistencias asistencia = new Asistencias();
                asistencia.FechaEntrada = DateTime.Now;
                asistencia.FechaSalida = DateTime.Now;
                asistencia.IdSede = idSede;

                rta = AsistenciaController.ActualizarSalidaAsistencia(asistencia, Documento);

                if (rta.Equals("SIN SALIDA"))
                {
                    RegistrarIngreso();
                }
                else if (!rta.Equals("ERROR"))
                {
                    tmAsistencias.Stop();
                    lblMensaje.Text = rta;
                    lblMensaje.BackColor = Color.FromArgb(122, 123, 123);
                    lblMensaje.ForeColor = Color.White;                    
                    lblMensaje.Visible=true;
                    //pnAsistencia.Visible = true;
                    lblMensaje.Text = rta.ToString();
                    lblMensaje.Update();
                    Thread.Sleep(tiempoMensaje);
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    

                }

                else
                {
                    //tmAsistencias.Stop();
                    //MensajeError(rta);
                    //tmAsistencias.Start();

                    tmAsistencias.Stop();
                    lblMensaje.BackColor = Color.FromArgb(122, 123, 123);
                    lblMensaje.Text = rta.ToString();
                    lblMensaje.ForeColor = Color.White;
                    //pnAsistencia.Visible = true;
                    lblMensaje.Visible=true;
                    lblMensaje.Text = rta.ToString();
                    lblMensaje.Update();
                Thread.Sleep(tiempoMensaje);
                    Login login = new Login();
                    login.Show();
                    this.Hide();

                }
            }
            else if(rta.Equals("NO TARJETA"))
            {
                rta = "No se encontró ninguna tarjeta en la lectora";
                    lblMensaje.BackColor = Color.FromArgb(122, 123, 123);
                tmAsistencias.Stop();
                lblMensaje.ForeColor = Color.White;
                lblMensaje.Text = rta.ToString();
                //pnAsistencia.Visible = true;
                    lblMensaje.Visible=true;
                lblMensaje.Update();
                Thread.Sleep(tiempoMensaje);
                Login login = new Login();
                login.Show();
                this.Hide();
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
                //label15.Visible = false;
            }
          
        }

        public bool CargarImagenes()
        {
            bool ok = false;
            //fondoEmpleado.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Imagenes\fondoEmpleados.png"));

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Imagenes\Encabezado.png");
            string imgFondoAsistencias = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Imagenes\FondoMenu.png");


            if (File.Exists(imagePath))
            {
                pnTitulo.BackgroundImage = Image.FromFile(imagePath);
                BackgroundImageLayout = ImageLayout.Stretch;
                imgFondoAsistencia.BackgroundImage = Image.FromFile(imgFondoAsistencias);
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

        #region Botones
        private void btnActEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }
        private void btnActVolver_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión empleados";
            lblTitulo.Visible = true;
            TabPrincipal.SelectedTab = Empleados;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dvgListadoEmpleados.Rows)
            {
                DataGridViewCheckBoxCell checkbox = fila.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkbox.Value))
                {
                    tbActDocumento.Text = fila.Cells[1].Value.ToString();
                    tbActNombres.Text = fila.Cells[2].Value.ToString();
                    tbActApellidos.Text = fila.Cells[3].Value.ToString();
                    tbActTelefono.Text = fila.Cells[4].Value.ToString();
                    tbActTarjeta.Text = fila.Cells[5].Value.ToString();
                    cboActCargo.Text = fila.Cells[6].Value.ToString();
                    cbActSede.Text = fila.Cells[7].Value.ToString();

                }
            }

            TabPrincipal.SelectedTab = ActualizarDatosEmpleado;
            lblTitulo.Text = "Actualizar datos empleados";
            ListarCargosAct();
            ListarSedesAct();
            ListarActEmpleados();


        }

        private void cboActCargo_MouseClick(object sender, MouseEventArgs e)
        {
            ListarCargos();
        }

        private void cbActSede_MouseClick(object sender, MouseEventArgs e)
        {
            ListarSedes();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Aistencia empleados";
            lblTitulo.Visible = true;
             lblMensaje.Visible=true;
            //pnAsistencia.Visible = false;
            TabPrincipal.SelectedTab = Asistencia;
            trmMenu.Stop();
            tmAsistencias.Start();
            conteo = 1;
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
            ListarActEmpleados();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            RegistrarIngreso();
        }
        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            string rta = "";
            DataTable tabla;
            Asistencias asistencia = new Asistencias();
            asistencia.FechaEntrada = DateTime.Now;
            asistencia.FechaSalida = DateTime.Now;
            asistencia.IdSede = idSede;

            rta = AsistenciaController.ActualizarSalidaAsistencia(asistencia, Documento);

            if (rta.Equals("SIN SALIDA"))
            {
                RegistrarIngreso();
            }
            else if (!rta.Equals("ERROR"))
            {
                MensajeOk(rta.ToString());
            }

            else
            {
                MensajeError(rta);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de turnos";
            lblTitulo.Visible = true;
            TabPrincipal.SelectedTab = Menu;
        }
        #endregion

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Nombre + "!";
            lblTitulo.Text = "Gestión de turnos";
            Inicio();
            TabPrincipal.SelectedTab = Menu;
            TabPrincipal.Appearance = TabAppearance.FlatButtons;
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
            trmMenu.Start();
            tmAsistencias.Stop();
            if(Cargo== "Empleado")
            {
                btnEmpleados.Visible = false;
            }
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

        private void tmAsistencias_Tick(object sender, EventArgs e)
        {
            conteo++;
         
            try
            {
                if (conteo >= 20)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    tmAsistencias.Stop();
                }
                AsistenciaEmpleado();
                
            }
            catch (Exception ex )
            {

                MensajeError(ex.ToString());
            }
        }  

        private void cboActCargo_MouseClick_1(object sender, MouseEventArgs e)
        {
            ListarCargosAct();

        }

        private void cbActSede_MouseClick_1(object sender, MouseEventArgs e)
        {
            ListarSedesAct();
        }

        private void trmMenu_Tick(object sender, EventArgs e)
        {
            conteo++;

            try
            {
                if (Cargo == "Empleado")
                {
                    if (conteo >= 50)
                    {
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                        trmMenu.Stop();
                        btnEmpleados.Visible = false;
                    }
                }
                else
                {

                }
               

            }
            catch (Exception ex)
            {

                MensajeError(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            trmMenu.Stop();
        }
    }
}

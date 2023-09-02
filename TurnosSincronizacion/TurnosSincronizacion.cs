using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Configuration;
using ControladorSincronizacion;
using Modelo;

namespace TurnosSincronizacion
{
    public partial class TurnosSincronizacion : ServiceBase
    {

        #region Definiciones
        private Timer oTimer;
        Sedes sedes = new Sedes();
        Empleados empleados = new Empleados();
        Turnos turnos = new Turnos();
        TurnosAplicados turnosAplicados = new TurnosAplicados();
        Asistencias asistencias =  new Asistencias();
        Retardos retardos = new Retardos();
        HorasExtras horasExtras= new HorasExtras();
        private static object objLock = new object();
        private static TurnosSincronizacion Agente = new TurnosSincronizacion();
        public string rta = string.Empty;
        

        #endregion


        private static int _PeriodoEjecucionSegundos
        {
            get
            {
                string sPeriodoEjecucionSegundos = ConfigurationManager.AppSettings["PeriodoEjecucionSegundos"];
                if (string.IsNullOrEmpty(sPeriodoEjecucionSegundos))
                {
                    return 10;
                }
                else
                {
                    return Convert.ToInt32(sPeriodoEjecucionSegundos);
                }
            }
        }

        private static int _IdSede
        {
            get
            {
                string sPeriodoEjecucionSegundos = ConfigurationManager.AppSettings["IdSede"];
                if (string.IsNullOrEmpty(sPeriodoEjecucionSegundos))
                {
                    return 10;
                }
                else
                {
                    return Convert.ToInt32(sPeriodoEjecucionSegundos);
                }
            }
        }



        public TurnosSincronizacion()
        {
            oTimer = new Timer(_PeriodoEjecucionSegundos * 1000);
            oTimer.Elapsed += new ElapsedEventHandler(oTimer_Elapsed);

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            oTimer.Enabled = true;

        }

        protected override void OnStop()
        {
            oTimer.Enabled = false;

        }

        static void Main(string[] args)
        {
            Process.GetCurrentProcess().Exited += new EventHandler(TurnosSincronizacion_Exited);

            try
            {
                if (System.Diagnostics.Process.GetProcessesByName
                    (System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
                    throw new ApplicationException("Existe otra instancia del servicio en ejecución.");

                if (!Environment.UserInteractive)
                    TurnosSincronizacion.Run(Agente);
                else
                {
                    if (Environment.UserInteractive)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Agente.OnStart(null);

                    if (Environment.UserInteractive)
                        Console.ForegroundColor = ConsoleColor.Green;

                    if (Environment.UserInteractive)
                        Console.WriteLine("El servicio se inicio correctamente y queda en espera de atender solicitudes.");

                    System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
                }
            }
            catch (Exception ex)
            {
                if (Environment.UserInteractive)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ocurrió un error iniciando el servicio.");
                    Console.WriteLine(ex.Message);
                    System.Threading.Thread.Sleep(new TimeSpan(0, 1, 0));
                }
            }
        }

        void oTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                oTimer.Enabled = false;

                if (Environment.UserInteractive)
                    Console.WriteLine("El servicio inicia revision");

                lock (objLock)
                {
                    sedes.IdSede = _IdSede;
                    empleados.IdSede=_IdSede;
                    turnos.IdSede = _IdSede;
                    turnosAplicados.IdSede= _IdSede;
                    asistencias.IdSede = _IdSede;
                    retardos.IdSede = _IdSede;
                    horasExtras.IdSede = _IdSede;

                    #region Subida 

                    #region Tarjetas
                    SincronizacionController.SincronizarTarjetas();
                    #endregion

                    #region Sedes
                    SincronizacionController.SincronziacionSedes(sedes);
                    #endregion

                    #region Empleados
                    SincronizacionController.SincronizacionEmpleados(empleados);
                    #endregion

                    #region Turnos

                    SincronizacionController.SincronizacionTurnos(turnos);
                    #endregion

                    #region TurnosAplicados
                    SincronizacionController.SincronizacionTurnosAplicados(turnosAplicados);

                    #endregion

                    #region Asistencia
                    SincronizacionController.SincronizacionAsistencias(asistencias);
                    #endregion

                    #region Retardos
                    SincronizacionController.SincronizacionRetardos(retardos);
                    #endregion

                    #region HorasExtras
                    SincronizacionController.SincronizacionHorasExtras(horasExtras);
                    #endregion


                    #endregion

                    #region Bajada

                    #region Empleados

                    #endregion


                    #endregion

                    oTimer.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                string sFechaFile = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
                //TraceHandler.WriteLine(LOG.NombreArchivoLogRegistraArchivos + sFechaFile, "SERVICIO WINDOWS: excepcion servicio: " + ex.Source + " " + ex.StackTrace + " " + ex.Message, TipoLog.TRAZA);

                oTimer.Enabled = true;
            }
        }

        static void TurnosSincronizacion_Exited(object sender, EventArgs e)
        {
            try
            {
                if (!Environment.UserInteractive)
                {
                    Agente.OnStop();
                    Agente = null;
                }
            }
            catch { }
        }
    }
}

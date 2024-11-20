using BusinessLayer;
using EntityLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PresentationLayer
{
    public partial class DetalleSolicitud : Form
    {
        // Propiedades para los datos de solicitud y empleado
        private readonly SolicitudDTO solicitud;
        private BL_Cargo cargo = new BL_Cargo();
        private BL_Sucursal sucursal = new BL_Sucursal();
        private BL_Solicitud solicitudBL = new BL_Solicitud();
        private BL_Usuario usuario = new BL_Usuario();
        private BL_Empleado empleado = new BL_Empleado();
        private BL_Prestamo prestamo = new BL_Prestamo();
        private decimal limite = 0;
        private string mensajeLimite = "";
        private Home _home;

        // Constructor que recibe la solicitud, el empleado y el límite de préstamo
        public DetalleSolicitud(SolicitudDTO solicitud, Home home)
        {
            this.solicitud = solicitud;

            InitializeComponent();
            CargarInformacion();
            _home = home;
        }

        private void CargarInformacion()
        {
            // Cargar los datos de la solicitud
            txtIdSolicitud.Text = solicitud.ID_Solicitud.ToString();
            txtFecha.Text = solicitud.Fecha_Solicitud.ToString("dd/MM/yyyy");
            txtMontoSolicitado.Text = solicitud.Monto_Solicitado.ToString("C");
            txtPeriodo.Text = solicitud.Periodo.ToString();
            txtEstadoSolicitud.Text = solicitud.Estado_Solicitud;

            Console.WriteLine(solicitud.ToString());
            Console.ReadLine();

            Empleado emp = empleado.getEmpleadoByID(solicitud.Empleado);
            // Cargar los datos del empleado
            txtIdEmpleado.Text = emp.ID_Empleado.ToString();
            txtNombreEmpleado.Text = emp.Nombre;
            txtSucursal.Text = sucursal.GetSucursal(emp.ID_Sucursal).Nombre_Sucursal;
            txtUsuario.Text = usuario.getUsuario(emp.ID_Usuario).Nombre_Usuario;
            txtCargo.Text = cargo.GetCargo(emp.ID_Cargo).Nombre_Cargo;

            switch (cargo.GetCargo(emp.ID_Cargo).Nombre_Cargo)
            {
                case "Operario":
                    limite = 10000000;
                    mensajeLimite = "Hasta $10,000,000";
                    break;
                case "Administrativo":
                    limite = 15000000;
                    mensajeLimite = "Hasta $15,000,000";
                    break;
                case "Ejecutivo":
                    limite = 20000000;
                    mensajeLimite = "Hasta $20,000,000";
                    break;
                case "Otros":
                    limite = 12000000;
                    mensajeLimite = "Hasta $12,000,000";
                    break;
                default:
                    mensajeLimite = "Cargo no reconocido";
                    break;
            }

            // Mostrar el límite de préstamo
            txtLimite.Text = $"{mensajeLimite:C}";

            if (solicitud.Monto_Solicitado <= limite)
            {
                txtLimite.BackColor = System.Drawing.Color.SpringGreen; // Si el monto es menor o igual al límite, el texto será verde
            }
            else
            {
                txtLimite.BackColor = System.Drawing.Color.Red; // Si el monto es mayor al límite, el texto será rojo
                btnAceptar.Enabled = false;
                btnAceptar.BackColor = System.Drawing.Color.Gray;
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( solicitud.ID_Solicitud > 0)
            {
                
                string idSolicitud = solicitud.ID_Solicitud.ToString();

                bool changeSolicitud = solicitudBL.cambiarEstadoSolicitud(idSolicitud, "3");

                if (changeSolicitud)
                {
                    EmailService emailService = new EmailService();
                    Empleado emp1 = empleado.getEmpleadoByID(solicitud.Empleado);
                    Decimal nuevoMonto = 0;

                    switch (solicitud.Periodo.ToString())
                    {
                        case "24":
                            nuevoMonto = Convert.ToDecimal(Convert.ToDouble(solicitud.Monto_Solicitado) * 1.07);
                            break;
                        case "36":
                            nuevoMonto = Convert.ToDecimal(Convert.ToDouble(solicitud.Monto_Solicitado) * 1.075);
                            break;
                        case "48":
                            nuevoMonto = Convert.ToDecimal(Convert.ToDouble(solicitud.Monto_Solicitado) * 1.08);
                            break;
                        case "60":
                            nuevoMonto = Convert.ToDecimal(Convert.ToDouble(solicitud.Monto_Solicitado) * 1.083);
                            break;
                        case "72":
                            nuevoMonto = Convert.ToDecimal(Convert.ToDouble(solicitud.Monto_Solicitado) * 1.086);
                            break;
                    }

                    bool crearPrestamo = CrearPrestamo(nuevoMonto, solicitud, emp1);


                    string htmlBody = emailService.CreateHtmlBody($"Apreciado {emp1.Nombre}", $"<p>Su solicitud ha sido aprobada. En {solicitud.Periodo} cuotas de {(int)Math.Round(nuevoMonto/solicitud.Periodo)} cada una.</p>");
                    bool success = emailService.SendEmail(emp1.Correo, "Prestamo aprobado", htmlBody);

                    // Verificar si se envió correctamente
                    if (success)
                    {
                        Console.WriteLine("Correo enviado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Hubo un problema al enviar el correo.");
                    }
                    Solicitudes solicitudes = new Solicitudes("3", _home);
                    _home.EmbedFormInPanel(solicitudes);
                }
                else
                {
                    MessageBox.Show("Error al revisar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de aprobar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Boolean CrearPrestamo(Decimal nuevoMonto, SolicitudDTO solicitud, Empleado empleado)
        {
            // Obtiene la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcula el mes siguiente
            int mesSiguiente = fechaActual.Month == 12 ? 1 : fechaActual.Month + 1;

            // Calcula el año, considerando el cambio de año si el mes actual es diciembre
            int anioSiguiente = fechaActual.Month == 12 ? fechaActual.Year + 1 : fechaActual.Year;

            // Define la fecha del día 3 del mes siguiente
            DateTime fechaDesembolso = new DateTime(anioSiguiente, mesSiguiente, 3);

            // Calcula la fecha de vencimiento sumando las cuotas a la fecha de desembolso
            DateTime fechaVencimiento = fechaDesembolso.AddMonths(solicitud.Periodo);

            var newPrestamo = new Prestamo()
            {
                ID_Solicitud = solicitud.ID_Solicitud,
                Cantidad_Cuotas = solicitud.Periodo,
                Monto_Desembolsado = solicitud.Monto_Solicitado,
                Monto_Restante = nuevoMonto,
                ID_Empleado = empleado.ID_Empleado,
                Fecha_Desembolso = fechaDesembolso,
                Fecha_Vencimiento = fechaVencimiento
            };

            return prestamo.CreatePrestamo(newPrestamo);

        }
        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (solicitud.ID_Solicitud > 0)
            {

                string idSolicitud = solicitud.ID_Solicitud.ToString();

                bool changeSolicitud = solicitudBL.cambiarEstadoSolicitud(idSolicitud, "4");

                if (changeSolicitud)
                {
                    EmailService emailService = new EmailService();
                    Empleado emp1 = empleado.getEmpleadoByID(solicitud.Empleado);

                    string htmlBody = emailService.CreateHtmlBody($"Apreciado {emp1.Nombre}", $"<p>Su solicitud ha sido rechazada, puede hacer una nueva solicitud si lo considera necesario</p>");
                    bool success = emailService.SendEmail(emp1.Correo, "Prestamo rechazado", htmlBody);

                    // Verificar si se envió correctamente
                    if (success)
                    {
                        Console.WriteLine("Correo enviado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Hubo un problema al enviar el correo.");
                    }
                    Solicitudes solicitudes = new Solicitudes("4", _home);
                    _home.EmbedFormInPanel(solicitudes);
                }
                else
                {
                    MessageBox.Show("Error al revisar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de cancelar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

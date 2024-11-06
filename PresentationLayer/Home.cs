using BusinessLayer;
using EntityLayer;
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

namespace PresentationLayer
{
    public partial class Home : Form
    {

        private static Usuario usuarioAct;
        public static Empleado infoUsuario;

        BL_Nivel bL_Nivel = new BL_Nivel();

        public Home( Usuario objUsuario, Empleado objEmpleado)
        {
            usuarioAct = objUsuario;
            infoUsuario = objEmpleado;
            InitializeComponent();
            ConfigureMenuForUserLevel();
            this.IsMdiContainer = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtNameUser.Text = infoUsuario.Nombre.ToString();
        }

        /// <summary>
        /// Configures the menu options based on the user's level.
        /// </summary>
        private void ConfigureMenuForUserLevel()
        {
            Nivel_Usuario nivel = bL_Nivel.GetNivelByID(usuarioAct.ID_Nivel);

            if (nivel != null)
            {
                switch (nivel.Nivel)
                {
                    case "Administrador(admin)":
                        EnableAdminOptions();
                        break;
                    case "Paramétricos(tesoreria)":
                        EnableParametricOptions();
                        break;
                    case "Esporádicos(empleado)":
                        EnableSporadicOptions();
                        break;
                    default:
                        MessageBox.Show("Nivel de usuario no reconocido.");
                        break;
                }
            }


        }

        /// <summary>
        /// Enables options available for the Administrator user.
        /// </summary>
        private void EnableAdminOptions()
        {
            // All options are enabled for the administrator
            transactions.Visible = true;
            requestLoan.Visible = true;
            payLoanInstallment.Visible = true;
            reports_consults.Visible = true;
            utils.Visible = true;
            help.Visible = true;
        }

        /// <summary>
        /// Enables options available for the Parametric user.
        /// </summary>
        private void EnableParametricOptions()
        {
            // Limited options for parametric users
            transactions.Visible = true;
            requestLoan.Visible = true;
            payLoanInstallment.Visible = true;
            reports_consults.Visible = true;
            utils.Visible = true;
            help.Visible = true;
        }

        /// <summary>
        /// Enables options available for the Sporadic user.
        /// </summary>
        private void EnableSporadicOptions()
        {
            // Habilitar opciones para usuarios esporádicos y ocultar las opciones no permitidas
            transactions.Visible = true;
            requestLoan.Visible = true;
            payLoanInstallment.Visible = true;
            reports_consults.Visible = true;
            utils.Visible = true;
            help.Visible = true;

            // Ocultar la opción 'solicitudesToolStripMenuItem' para usuarios esporádicos
            solicitudesToolStripMenuItem.Visible = false;
        }


        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Limpia el contenido actual del panel
            container.Controls.Clear();

            // Crea una instancia del formulario de reportes
            ReportsAndQueries reportsAndQueries = new ReportsAndQueries
            {
                TopLevel = false,        // Indica que no será el formulario superior
                FormBorderStyle = FormBorderStyle.None,  // Sin bordes
                Dock = DockStyle.Fill    // Expande el formulario en el panel
            };

            // Agrega el formulario al panel `container` y lo muestra
            container.Controls.Add(reportsAndQueries);
            reportsAndQueries.Show();
        }


        // Método para abrir la Calculadora
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la Calculadora. " + ex.Message);
            }
        }

        // Método para abrir el Calendario
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            // Limpia el contenido actual del panel
            container.Controls.Clear();

            // Agrega el calendario al panel `container`
            monthCalendar.Dock = DockStyle.Fill;
            monthCalendar.Visible = true;

            container.Controls.Add(monthCalendar);
        }


        // Método para abrir el formulario de solicitud de préstamo en el panel.
        private void requestLoan_Click(object sender, EventArgs e)
        {
            try
            {
                RequestLoanForm requestLoanForm = new RequestLoanForm();
                EmbedFormInPanel(requestLoanForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el formulario de solicitud de préstamo: {ex.Message}");
            }
        }

        // Método para abrir el formulario de pago de cuota en el panel.
        private void payLoanInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                PayLoanInstallmentForm payLoanInstallmentForm = new PayLoanInstallmentForm();
                EmbedFormInPanel(payLoanInstallmentForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el formulario de pago de cuota: {ex.Message}");
            }
        }

        // Método para abrir el formulario de mis solicitudes en el panel.
        private void misSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MisSolicitudes misSolicitudes = new MisSolicitudes();
            EmbedFormInPanel(misSolicitudes);
        }

        // Método para abrir el formulario de solicitudes en el panel.
        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            EmbedFormInPanel(solicitudes);
        }

        /// <summary>
        /// Embeds the specified form within the container panel on the Home form.
        /// </summary>
        /// <param name="form">The form to embed inside the container panel.</param>
        private void EmbedFormInPanel(Form form)
        {
            // Limpiar cualquier control previo en el panel.
            container.Controls.Clear();

            // Configurar el formulario para mostrarse dentro del panel.
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y mostrarlo.
            container.Controls.Add(form);
            form.Show();
        }
    }
}

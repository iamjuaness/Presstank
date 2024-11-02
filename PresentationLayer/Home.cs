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
        private static Empleado infoUsuario;

        BL_Nivel bL_Nivel = new BL_Nivel();

        public Home( Usuario objUsuario, Empleado objEmpleado)
        {
            usuarioAct = objUsuario;
            infoUsuario = objEmpleado;
            InitializeComponent();
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
            var nivel = bL_Nivel.GetNivelByID(usuarioAct.ID_Nivel);
            switch (nivel.Nivel)
            {
                case "Administrador(admin)":
                    EnableAdminOptions();
                    break;
                case "Paramétrico(tesoreria)":
                    EnableParametricOptions();
                    break;
                case "Esporádico(empleado)":
                    EnableSporadicOptions();
                    break;
                default:
                    MessageBox.Show("Nivel de usuario no reconocido.");
                    break;
            }
        }

        /// <summary>
        /// Enables options available for the Administrator user.
        /// </summary>
        private void EnableAdminOptions()
        {
            // All options are enabled for the administrator
            transactions.Enabled = true;
            requestLoan.Enabled = true;
            payLoanInstallment.Enabled = true;
            reports_consults.Enabled = true;
            utils.Enabled = true;
            help.Enabled = true;
        }

        /// <summary>
        /// Enables options available for the Parametric user.
        /// </summary>
        private void EnableParametricOptions()
        {
            // Limited options for parametric users
            transactions.Enabled = true;
            requestLoan.Enabled = true;
            payLoanInstallment.Enabled = true;
            reports_consults.Enabled = true;
            utils.Enabled = false; // Parametric users can't access the utilities
            help.Enabled = true;
        }

        /// <summary>
        /// Enables options available for the Sporadic user.
        /// </summary>
        private void EnableSporadicOptions()
        {
            // Only request loan and help options for sporadic users
            transactions.Enabled = true;
            requestLoan.Enabled = true;
            payLoanInstallment.Enabled = false;
            reports_consults.Enabled = false;
            utils.Enabled = false;
            help.Enabled = true;
        }


        // Método para abrir el formulario de solicitud de préstamo
        private void requestLoan_Click(object sender, EventArgs e)
        {
            try
            {
                RequestLoanForm requestLoanForm = new RequestLoanForm();
                requestLoanForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el formulario de solicitud de préstamo: {ex.Message}");
            }
        }

        private void payLoanInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                PayLoanInstallmentForm payLoanInstallmentForm = new PayLoanInstallmentForm();
                payLoanInstallmentForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el formulario de pago de cuota: {ex.Message}");
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsAndQueries reportsAndQueries = new ReportsAndQueries();
            reportsAndQueries.ShowDialog();
            
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
            try
            {
                this.monthCalendar.Visible = !this.monthCalendar.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el Calendario. " + ex.Message);
            }
        }

    }
}

using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    }
}

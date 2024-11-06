using BusinessLayer;
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
    public partial class RequestLoanForm : Form
    {

        BL_Solicitud solicitud = new BL_Solicitud();

        public RequestLoanForm()
        {
            InitializeComponent();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;
                Decimal monto = Convert.ToDecimal(txtLoanAmount.Text);
                int periodo = cmbLoanPeriod.SelectedIndex + 1;
                int estado = 1;
                int id_empleado = Home.infoUsuario.ID_Empleado;

                // Validar que los campos requeridos no estén vacíos
                if (monto <= 0 || string.IsNullOrWhiteSpace(Convert.ToString(monto))
                    || periodo <= 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSolicitud = new Solicitud
                {
                    Monto_Solicitado = monto,
                    Fecha_Solicitud = date,
                    ID_Empleado = id_empleado,
                    ID_Estado = estado,
                    ID_Periodo = periodo
                };

                bool resultado = solicitud.crearSolicitud(newSolicitud);

                // Verificar el resultado de la operación y mostrar un mensaje apropiado
                if (resultado)
                {
                    MessageBox.Show("Solicitud creada correctamente", "Solicitud exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al solicitar el prestamo. Verifique la información.", "Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch {
                MessageBox.Show("Error al solicitar el prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtLoanAmount.Clear();
            cmbLoanPeriod.SelectedIndex = -1;
        }

    }
}

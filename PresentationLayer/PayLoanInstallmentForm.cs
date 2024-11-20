using BusinessLayer;
using EntityLayer;
using iText.Kernel.Pdf.Canvas.Wmf;
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
    public partial class PayLoanInstallmentForm : Form
    {
        private BL_Prestamo prestamo = new BL_Prestamo();
        public PayLoanInstallmentForm()
        {
            InitializeComponent();
            CargarPrestamos();
        }

        private void btnRegisterPayment_Click(object sender, EventArgs e)
        {
            // Add your payment registration logic here
            MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void CargarPrestamos()
        {
            // Limpiar las columnas del DataGridView antes de agregar nuevas
            dgvLoans.Columns.Clear();

            // Obtener las solicitudes
            List<PrestamoDTO> prestamos = prestamo.GetPrestamos(Home.infoUsuario.ID_Empleado);

            if (prestamos.Count == 0)
            {
                // Crear una columna de mensaje si no hay datos
                dgvLoans.Columns.Add("Mensaje", "Mensaje");
                dgvLoans.Columns["Mensaje"].Width = 1452;
                dgvLoans.Rows.Add("No hay información para mostrar");
            }
            else
            {
                // Asignar la lista como el origen de datos
                dgvLoans.DataSource = prestamos;

                dgvLoans.Columns["ID_Prestamo"].Width = 230;
                dgvLoans.Columns["Cantidad_Cuotas"].Width = 275;
                dgvLoans.Columns["Monto_Restante"].Width = 275;
                dgvLoans.Columns["Fecha_Vencimiento"].Width = 275;
            }
        }
    }
}

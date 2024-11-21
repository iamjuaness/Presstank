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
        private BL_Pago pago = new BL_Pago();
        public PayLoanInstallmentForm()
        {
            InitializeComponent();
            CargarPrestamos();
        }

        private void btnRegisterPayment_Click(object sender, EventArgs e)
        {
            if (dgvLoans.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvLoans.SelectedRows[0];

                // Verificar si la columna "ID_Prestamo" y las otras necesarias existen en el DataGridView
                if (!dgvLoans.Columns.Contains("ID_Prestamo") || selectedRow.Cells["ID_Prestamo"].Value == null)
                {
                    MessageBox.Show("Acción no válida. No se encontró la columna de prestamo.", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idPrestamo = selectedRow.Cells["ID_Prestamo"].Value.ToString();

                Prestamo getPrestamo = prestamo.GetPrestamoById(Convert.ToInt32(idPrestamo));

                int valorCuota = (int)Math.Round((getPrestamo.Monto_Desembolsado * (1 + getPrestamo.Interes)) / Convert.ToDecimal(selectedRow.Cells["Total_Cuotas"].Value));


                if (Convert.ToDecimal(txtInstallmentAmount.Text) == valorCuota)
                {
                    int numeroCuota = pago.GetCountPago(Convert.ToInt32(idPrestamo));
                    Decimal nuevoMonto = Convert.ToDecimal(selectedRow.Cells["Monto_Restante"].Value.ToString()) - Convert.ToDecimal(txtInstallmentAmount.Text);

                    Pago_Cuota prestamoSeleccionado = new Pago_Cuota
                    {
                        ID_Prestamo = Convert.ToInt32(idPrestamo),
                        Valor_Pago = Convert.ToInt32(txtInstallmentAmount.Text),
                        Fecha_Pago = DateTime.Now,
                        Numero_Cuota = numeroCuota
                    };

                    bool actualizarPrestamo = prestamo.ModifyCuotaAndMontoRestante(nuevoMonto, Convert.ToInt32(idPrestamo));

                    if (actualizarPrestamo)
                    {
                        bool newPago = pago.CreatePago(prestamoSeleccionado);

                        if (newPago)
                        {
                            CargarPrestamos();
                            txtInstallmentAmount.Clear();
                            EmailService emailService = new EmailService();
                            string html = emailService.CreateHtmlBody("Querido Usuario", "<p>Hemos recibido su pago satisfactoriamente, recuerde hacer los pagos oportunamente" +
                                " para que su cuenta no sea reportada como morosa, es un placer contar con su confianza</p>");
                            bool success = emailService.SendEmail(Home.infoUsuario.Correo, "Pago Exitoso", html);

                            // Verificar si se envió correctamente
                            if (success)
                            {
                                Console.WriteLine("Correo enviado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("Hubo un problema al enviar el correo.");
                            }
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Hubo un error al procesar su pago, intente nuevamente y si el error persiste informe a tesorería", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else
                {
                    MessageBox.Show($"Monto de cuota no válido, su cuota debe ser de: ${valorCuota}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud primero.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                dgvLoans.Columns["Mensaje"].Width = 1100;
                dgvLoans.Rows.Add("No hay información para mostrar");
            }
            else
            {
                // Asignar la lista como el origen de datos
                dgvLoans.DataSource = prestamos;

                dgvLoans.Columns["ID_Prestamo"].Width = 180;
                dgvLoans.Columns["Cuotas_Restantes"].Width = 180;
                dgvLoans.Columns["Monto_Restante"].Width = 180;
                dgvLoans.Columns["Fecha_Vencimiento"].Width = 180;
                dgvLoans.Columns["Prestamo"].Width = 180;
                dgvLoans.Columns["Total_Cuotas"].Width = 180;
            }
        }
    }
}

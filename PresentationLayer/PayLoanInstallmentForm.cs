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
        public PayLoanInstallmentForm()
        {
            InitializeComponent();
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

    }
}

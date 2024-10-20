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
        public RequestLoanForm()
        {
            InitializeComponent();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // Add your loan request logic here
            MessageBox.Show("Solicitud de préstamo enviada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtNameUser.Text = infoUsuario.Nombre.ToString();
        }

        private void transactions_Click(object sender, EventArgs e)
        {

        }
    }
}

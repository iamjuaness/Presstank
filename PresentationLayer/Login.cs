using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new BL_Usuario().getUsuarios();

            Usuario usuario = new BL_Usuario().getUsuarios().Where(u => u.Nombre_Usuario == txtEmail.Text && u.Contrasenia ==
            txtClave.Text).FirstOrDefault();

            Empleado empleado = new BL_Empleado().getEmpleadoByID(usuario.ID_Usuario);

            if(usuario != null && empleado != null)
            {
                Home form = new Home(usuario, empleado);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            } else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtEmail.Text = "";
            txtClave.Text = "";
            this.Show();
        }
    }
}

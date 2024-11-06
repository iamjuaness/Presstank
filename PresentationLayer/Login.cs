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
        BL_Nivel bL_Nivel = new BL_Nivel();
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
            // Obtiene la lista de usuarios
            List<Usuario> usuarios = new BL_Usuario().getUsuarios();

            // Busca el usuario que coincide con el nombre de usuario y la contraseña ingresados
            Usuario usuario = usuarios.FirstOrDefault(u => u.Nombre_Usuario == txtEmail.Text && u.Contrasenia == txtClave.Text);

            // Verifica si el usuario es nulo (no existe o la contraseña es incorrecta)
            if (usuario == null)
            {
                // Muestra un mensaje de error y permite al usuario intentar de nuevo
                MessageBox.Show("Usuario o contraseña incorrectos, intente nuevamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Detiene la ejecución para permitir al usuario reintentar
            }

            // Obtiene el empleado asociado al usuario encontrado
            Empleado empleado = new BL_Empleado().getEmpleadoByID(usuario.ID_Usuario);

            // Obtiene el nivel de acceso del usuario
            var nivel = bL_Nivel.GetNivelByID(usuario.ID_Nivel);

            // Verifica si el empleado es nulo por alguna razón
            if (empleado == null)
            {
                MessageBox.Show("No se encontró el empleado asociado al usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Detiene la ejecución en caso de que el empleado no se haya encontrado
            }

            // Si el usuario y el empleado son válidos, abre la ventana principal 'Home'
            Home home = new Home(usuario, empleado);
            home.Show();
            this.Hide();

            // Asigna un evento al cierre de la ventana principal
            home.FormClosing += frm_closing;
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtEmail.Text = "";
            txtClave.Text = "";
            this.Show();
        }
    }
}

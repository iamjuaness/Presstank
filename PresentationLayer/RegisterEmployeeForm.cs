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
    public partial class RegisterEmployeeForm : Form
    {
        // Instancia de la lógica de negocio para el manejo de empleados
        private BL_Empleado _blEmpleado = new BL_Empleado();
        private BL_Sucursal _blSucursal = new BL_Sucursal();
        private BL_Cargo _blCargo = new BL_Cargo();
        private BL_Nivel _blNivel = new BL_Nivel();

        // Constructor del formulario
        public RegisterEmployeeForm()
        {
            InitializeComponent();
            LoadComboBoxes(); // Cargar los datos en los ComboBox al inicializar el formulario
        }

        // Método para cargar los datos en los ComboBox
        private void LoadComboBoxes()
        {
            try
            {
                // Cargar sucursales en el comboBox
                var sucursales = _blSucursal.GetSucursales();

                // Verificar si se han obtenido sucursales
                if (sucursales != null && sucursales.Count > 0)
                {
                    cmbIDSucursal.DataSource = sucursales;
                    cmbIDSucursal.DisplayMember = "Nombre_Sucursal";
                    cmbIDSucursal.ValueMember = "ID_Sucursal";
                    cmbIDSucursal.SelectedIndex = -1;
                    Console.WriteLine($"{sucursales.Count} sucursales cargadas.");
                }
                else
                {
                    Console.WriteLine("No se encontraron sucursales.");
                    MessageBox.Show("No se encontraron sucursales.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cargar cargos en el comboBox
                var cargos = _blCargo.GetCargos();

                if (cargos != null && cargos.Count > 0)
                {
                    cmbIDCargo.DataSource = cargos;
                    cmbIDCargo.DisplayMember = "Nombre_Cargo";
                    cmbIDCargo.ValueMember = "ID_Cargo";
                    cmbIDCargo.SelectedIndex = -1;
                    Console.WriteLine($"{cargos.Count} cargos cargados.");
                }
                else
                {
                    Console.WriteLine("No se encontraron cargos.");
                    MessageBox.Show("No se encontraron cargos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cargar niveles en el comboBox, excluyendo "admin"
                var niveles = _blNivel.GetNiveles();
                Console.WriteLine(niveles);

                if (niveles != null && niveles.Count > 0)
                {
                    cmbIDNivel.DataSource = niveles;
                    cmbIDNivel.DisplayMember = "Nivel";
                    cmbIDNivel.ValueMember = "ID_Nivel";
                    cmbIDNivel.SelectedIndex = -1;
                    Console.WriteLine($"{niveles.Count} niveles cargados.");
                }
                else
                {
                    Console.WriteLine("No se encontraron niveles.");
                    MessageBox.Show("No se encontraron niveles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para manejar el clic en el botón de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los valores ingresados en la interfaz
                int idEmpleado = Convert.ToInt32(txtIDEmpleado.Text);
                string nombre = txtNombre.Text;
                int idSucursal = (int)cmbIDSucursal.SelectedValue;
                int idCargo = (int)cmbIDCargo.SelectedValue;
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                int idNivel = (int)cmbIDNivel.SelectedValue;

                // Validar que los campos requeridos no estén vacíos
                if (idEmpleado <= 0 || string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(nombreUsuario) ||
                    string.IsNullOrWhiteSpace(contrasenia) || idNivel <= 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un objeto empleado con la información capturada
                var empleado = new Empleado()
                {
                    ID_Empleado = idEmpleado,
                    Nombre = nombre,
                    ID_Sucursal = idSucursal,
                    ID_Cargo = idCargo
                };

                // Crear un objeto usuario con la información capturada
                var usuario = new Usuario
                {
                    Nombre_Usuario = nombreUsuario,
                    Contrasenia = contrasenia,
                    ID_Nivel = idNivel
                };

                // Llamar al servicio para guardar el empleado y el usuario
                bool resultado = _blEmpleado.RegisterEmployeeAndUser(empleado, usuario);

                // Verificar el resultado de la operación y mostrar un mensaje apropiado
                if (resultado)
                {
                    MessageBox.Show("Empleado y usuario registrados exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Limpiar los campos después del registro

                    Login login = new Login();

                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el empleado y el usuario. Verifique la información.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra y mostrar un mensaje de error
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos del formulario después de un registro exitoso.
        private void ClearFields()
        {
            txtIDEmpleado.Clear();
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            cmbIDSucursal.SelectedIndex = -1;
            cmbIDCargo.SelectedIndex = -1;
            cmbIDNivel.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

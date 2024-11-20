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
    public partial class ManageSucursalForm : Form
    {
        BL_Sucursal _blSucursal = new BL_Sucursal();
        BL_Municipio bL_Municipio = new BL_Municipio();

        public ManageSucursalForm()
        {
            InitializeComponent();
            loadMunicipios();
            cargarSucursales();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Crear el objeto sucursal con los datos del formulario
            var sucursal = new Sucursal()
            {
                Nombre_Sucursal = txtNombreSucursal.Text,
                Direccion = txtDireccion.Text,
                ID_Municipio = (int)cmbIDMunicipio.SelectedValue
            };

            // Intentar crear la sucursal
            bool create = _blSucursal.crearSucursal(sucursal);

            if (create)
            {
                MessageBox.Show("Se creó la sucursal correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los datos del DataGridView para reflejar la nueva sucursal
                cargarSucursales();
            }
            else
            {
                MessageBox.Show("Hubo un error al crear la sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadMunicipios()
        {
            // Cargar sucursales en el comboBox
            var municipios = bL_Municipio.GetMunicipios();

            // Verificar si se han obtenido sucursales
            if (municipios != null && municipios.Count > 0)
            {
                cmbIDMunicipio.DataSource = municipios;
                cmbIDMunicipio.DisplayMember = "Nombre_Municipio";
                cmbIDMunicipio.ValueMember = "ID_Municipio";
                cmbIDMunicipio.SelectedIndex = -1;
                Console.WriteLine($"{municipios.Count} municipios cargadas.");
            }
            else
            {
                Console.WriteLine("No se encontraron municipios.");
                MessageBox.Show("No se encontraron municipios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarSucursales()
        {
            // Limpiar las columnas del DataGridView antes de agregar nuevas
            sucursalesDataView.Columns.Clear();

            // Obtener las solicitudes
            List<Sucursal> sucursales = _blSucursal.GetSucursales();

            if (sucursales.Count == 0)
            {
                // Crear una columna de mensaje si no hay datos
                sucursalesDataView.Columns.Add("Mensaje", "Mensaje");
                sucursalesDataView.Columns["Mensaje"].Width = 1452;
                sucursalesDataView.Rows.Add("No hay información para mostrar");
            }
            else
            {
                // Asignar la lista como el origen de datos
                sucursalesDataView.DataSource = sucursales;

                // Ajustar el ancho de las columnas
                sucursalesDataView.Columns["ID_Sucursal"].Width = 205;
                sucursalesDataView.Columns["Nombre_Sucursal"].Width = 205;
                sucursalesDataView.Columns["Direccion"].Width = 230;
                sucursalesDataView.Columns["ID_Municipio"].Width = 205;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (sucursalesDataView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = sucursalesDataView.SelectedRows[0];

                if (!sucursalesDataView.Columns.Contains("ID_Sucursal") || selectedRow.Cells["ID_Sucursal"].Value == null)
                {
                    MessageBox.Show("Acción no válida.", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idSucursal = selectedRow.Cells["ID_Sucursal"].Value.ToString();

                // Confirmar eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta sucursal?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar la sucursal
                    bool deleteSucursal = _blSucursal.EliminarSucursal(idSucursal);

                    if (deleteSucursal)
                    {
                        MessageBox.Show("La sucursal se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar los datos en el DataGridView
                        cargarSucursales();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal antes de eliminar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDireccion.Clear();
            txtNombreSucursal.Clear();
            cmbIDMunicipio.SelectedIndex = -1;
        }
    }
}

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
    public partial class Solicitudes : Form
    {
        BL_Solicitud solicitud = new BL_Solicitud();
        private Home _home;
        public Solicitudes(string estado, Home home)
        {
            InitializeComponent();
            CargarSolicitudes(estado);
            _home = home;

            switch (estado)
            {
                case "2":
                    button1.Visible = false;
                    button3.Visible = true;
                    break;
                
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];

                if (!solicitudesDataGridView.Columns.Contains("ID_Solicitud") || selectedRow.Cells["ID_Solicitud"].Value == null)
                {
                    MessageBox.Show("Acción no válida.", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idSolicitud = selectedRow.Cells["ID_Solicitud"].Value.ToString();


                bool changeSolicitud = solicitud.cambiarEstadoSolicitud(idSolicitud, "2");

                if (changeSolicitud)
                {
                    solicitudesDataGridView.Refresh();
                    Solicitudes solicitudes = new Solicitudes("2", _home);
                    _home.EmbedFormInPanel(solicitudes);

                } else
                {
                    MessageBox.Show("Error al revisar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para revisar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento para cancelar solicitud
        private void button2_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];

                if (!solicitudesDataGridView.Columns.Contains("ID_Solicitud") || selectedRow.Cells["ID_Solicitud"].Value == null)
                {
                    MessageBox.Show("Acción no válida.", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idSolicitud = selectedRow.Cells["ID_Solicitud"].Value.ToString();

                bool changeSolicitud = solicitud.cambiarEstadoSolicitud(idSolicitud, "4");

                if (changeSolicitud)
                {
                    solicitudesDataGridView.Refresh();
                    Solicitudes solicitudes = new Solicitudes("4", _home);
                    _home.EmbedFormInPanel(solicitudes);

                }
                else
                {
                    MessageBox.Show("Error al revisar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de cancelar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];

                // Verificar si la columna "ID_Solicitud" y las otras necesarias existen en el DataGridView
                if (!solicitudesDataGridView.Columns.Contains("ID_Solicitud") || selectedRow.Cells["ID_Solicitud"].Value == null)
                {
                    MessageBox.Show("Acción no válida. No se encontró la columna de solicitud.", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo objeto SolicitudDTO con los valores de la fila seleccionada
                SolicitudDTO solicitudSeleccionada = new SolicitudDTO
                {
                    ID_Solicitud = int.Parse(selectedRow.Cells["ID_Solicitud"].Value.ToString()),
                    Fecha_Solicitud = DateTime.Parse(selectedRow.Cells["Fecha_Solicitud"].Value.ToString()),
                    Monto_Solicitado = decimal.Parse(selectedRow.Cells["Monto_Solicitado"].Value.ToString()),
                    Periodo = int.Parse(selectedRow.Cells["Periodo"].Value.ToString()),
                    Estado_Solicitud = selectedRow.Cells["Estado_Solicitud"].Value.ToString()
                };

                DetalleSolicitud detalleSolicitud = new DetalleSolicitud(solicitudSeleccionada, _home);
                _home.EmbedFormInPanel(detalleSolicitud);
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud primero.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void CargarSolicitudes(string estado)
        {
            // Limpiar las columnas del DataGridView antes de agregar nuevas
            solicitudesDataGridView.Columns.Clear();

            // Obtener las solicitudes
            List<SolicitudDTO> solicitudes = solicitud.GetSolicitudes(estado);

            if (solicitudes.Count == 0)
            {
                // Crear una columna de mensaje si no hay datos
                solicitudesDataGridView.Columns.Add("Mensaje", "Mensaje");
                solicitudesDataGridView.Columns["Mensaje"].Width = 1452;
                solicitudesDataGridView.Rows.Add("No hay información para mostrar");
            }
            else
            {
                // Asignar la lista como el origen de datos
                solicitudesDataGridView.DataSource = solicitudes;

                // Ajustar el ancho de las columnas
                solicitudesDataGridView.Columns["ID_Solicitud"].Width = 240;
                solicitudesDataGridView.Columns["Fecha_Solicitud"].Width = 240;
                solicitudesDataGridView.Columns["Monto_Solicitado"].Width = 240;
                solicitudesDataGridView.Columns["Periodo"].Width = 240;
                solicitudesDataGridView.Columns["Estado_Solicitud"].Width = 240;
                solicitudesDataGridView.Columns["Empleado"].Width = 240;
            }
        }
    }
}

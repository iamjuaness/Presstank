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
    public partial class MisSolicitudes : Form
    {
        BL_Solicitud solicitud = new BL_Solicitud();

        public MisSolicitudes()
        {
            InitializeComponent();
            CargarSolicitudes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];
                string idSolicitud = selectedRow.Cells["ID_Solicitud"].Value.ToString();

                // Aquí procesarías la lógica para aceptar la solicitud.
                MessageBox.Show("Solicitud " + idSolicitud + " aceptada.");
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de aceptar.");
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
                }
                else
                {
                    MessageBox.Show("Error al revisar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de cancelar.");
            }
        }

        public void CargarSolicitudes()
        {
            // Limpiar las columnas del DataGridView antes de agregar nuevas
            solicitudesDataGridView.Columns.Clear();


            // Obtener las solicitudes
            List<MisSolicitudesDTO> solicitudes = solicitud.GetMisSolicitudes(Home.infoUsuario.ID_Empleado);

            if (solicitudes.Count == 0)
            {
                // Crear una columna de mensaje si no hay datos
                solicitudesDataGridView.Columns.Add("Mensaje", "Mensaje");
                solicitudesDataGridView.Columns["Mensaje"].Width = 1452;
                solicitudesDataGridView.Rows.Add("No hay información para mostrar");
            } else
            {
                // Asignar la lista como el origen de datos
                solicitudesDataGridView.DataSource = solicitudes;

                // El índice de las columnas puede variar según el orden en que se asignan los datos
                solicitudesDataGridView.Columns["ID_Solicitud"].Width = 290;
                solicitudesDataGridView.Columns["Fecha_Solicitud"].Width = 290;
                solicitudesDataGridView.Columns["Monto_Solicitado"].Width = 290;
                solicitudesDataGridView.Columns["Periodo"].Width = 230;
                solicitudesDataGridView.Columns["Estado_Solicitud"].Width = 290;
            }
        }
    }
}
